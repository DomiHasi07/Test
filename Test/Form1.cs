using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace Test
{
   

    public partial class Fragen : Form
    {
        string filepath, picturepath;
        DataSet Daten = new DataSet();
        DataTable first_table = new DataTable();
        bool geändert = false;
        bool new_file = false;
        bool row_is_edited;
        Data Dateipfade = new Data();
        TextBox[] Eingabefelder;
        
        public Fragen()
        {
            InitializeComponent();

            Eingabefelder = new TextBox[] { TxB_RichtigeAntwort, TxB_Antwort2, TxB_Antwort3, TxB_Antwort4, TxB_Frage, TxB_Nummer, TxB_Themengebiet };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DgV_1.RowsRemoved += DataGridView1_RowsRemoved;
            DgV_1.RowsAdded += DataGridView1_RowsAdded;
            DgV_1.AllowUserToAddRows = false;
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            geändert = true;
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            geändert = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {

            DataRow dr = Daten.Tables[0].NewRow();

            dr["Nummer"] = TxB_Nummer.Text.Trim();
            dr["Themengebiet"] = TxB_Themengebiet.Text.Trim();
            dr["Frage"] = TxB_Frage.Text.Trim();
            if(Pnl_Bild.Tag != null)
                dr["Bild"] = Pnl_Bild.Tag.ToString().Trim();
            else
                dr["Bild"] = "";
            dr["richtigeAntwort"] = TxB_RichtigeAntwort.Text.Trim();
            dr["Antwort2"] = TxB_Antwort4.Text.Trim();
            dr["Antwort3"] = TxB_Antwort2.Text.Trim();
            dr["Antwort4"] = TxB_Antwort3.Text.Trim();
            Daten.Tables[0].Rows.Add(dr);
            TxB_Nummer.Text = "";
            TxB_Themengebiet.Text = "";
            TxB_Frage.Text = "";
            Pnl_Bild.BackgroundImage = null;
            Pnl_Bild.Tag = "";
            TxB_RichtigeAntwort.Text = "";
            TxB_Antwort2.Text = "";
            TxB_Antwort3.Text = "";
            TxB_Antwort4.Text = "";
            Daten.Tables[0].DefaultView.Sort = "Nummer ASC";
            DgV_1.DataSource = Daten.Tables[0];
            if(row_is_edited)
                disable_change_row(false);

        }

        private void Text_geändert(object sender, EventArgs e)
        {
            foreach (TextBox tb in Eingabefelder)
            {
                if (tb.TextLength == 0)
                {
                    Btn_Add_Row.Enabled = false;
                    return;
                }
            }
            Btn_Add_Row.Enabled = true;
        }

        private void Btn_CreatXml_Click(object sender, EventArgs e)
        {
            if(DgV_1.Rows.Count == 0)
            {
                MessageBox.Show("Es muss mindestens eine Frage vorhanden sein", "keine Fragen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (geändert && !(new_file))
            {
                save_file();
            }
            else if(new_file)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML Files (*.xml)|*.xml";
                sfd.FilterIndex = 0;
                sfd.DefaultExt = "xml";
                sfd.Title = "Speicherort auswählen";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.FileName != "")
                    {
                        filepath = sfd.FileName;
                        save_file();
                        new_file = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte Datei zuerst ändern");
            }
            
        }

        private void Btn_File_Click(object sender, EventArgs e)
        {
            if(!geändert)
            {
                load_new_file();
            }
            else
            {
                switch(MessageBox.Show("Wollen Sie die veränderte Datei speichern","Änderungen speichern?",MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        save_file();
                        load_new_file();
                        break;

                    case DialogResult.No:
                        load_new_file();
                        break;

                    case DialogResult.Cancel: 
                        return;
                }
            }
        }

        private void Btn_Change_Click(object sender, EventArgs e)
        {
            if(DgV_1.SelectedCells.Count == 1)
            {
                change_cell form = new change_cell();
                form.send_cell = DgV_1.SelectedCells[0].Value.ToString();
                form.ShowDialog();
                if (form.ret_str != form.send_cell)
                {
                    DgV_1.SelectedCells[0].Value = form.ret_str.Trim();
                    
                    geändert = true;
                }
                form.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Btn_Change_Cell.Enabled = false;
            Btn_Change_Row.Enabled = false;
            Btn_Delete_Row.Enabled = false;

            Btn_Delete_Row.Text = "Zeile(n) entfernen";

            if (DgV_1.SelectedCells.Count == 1 || DgV_1.SelectedRows.Count == 1)
            {
                if(row_is_edited == false)
                {
                    if (DgV_1.SelectedCells.Count == 1)
                        Btn_Change_Cell.Enabled = true;
                    Btn_Delete_Row.Enabled = true;
                    Btn_Delete_Row.Text = "Zeile entfernen";
                }
                Btn_Change_Row.Enabled = true;

            }
            else if (DgV_1.SelectedRows.Count > 1 && row_is_edited == false)
            {
                Btn_Delete_Row.Enabled = true;
                Btn_Delete_Row.Text = "Zeilen entfernen";
            }
                
                
        }

        private void load_new_file()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.FilterIndex = 0;
            ofd.DefaultExt = "xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (String.Equals(Path.GetExtension(ofd.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        filepath = ofd.FileName;
                        Daten.Clear();
                        Daten.Reset();
                        Daten.ReadXml(filepath);
                        Daten.Tables[0].DefaultView.Sort = "Nummer ASC";
                        fill_DgV();
                        enable_Input(true);
                    }
                    catch
                    {
                        MessageBox.Show("Fehler beim lesen der Datei. Vergewissern Sie sich ob Sie die richtige Datei ausgewählt haben", "Dateifehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dieser Dateityp wird nicht unterstützt. Wählen Sie bitte eine XML Datei aus", "Falscher Dateityp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void create_new_file()
        {
            Daten.Clear();
            Daten.Reset();
            Daten.Tables.Add();
            Daten.Tables[0].Columns.AddRange(new DataColumn[]
            {
                    new DataColumn("Nummer"),
                    new DataColumn("Themengebiet"),
                    new DataColumn("Frage"),
                    new DataColumn("Bild"),
                    new DataColumn("RichtigeAntwort"),
                    new DataColumn("Antwort2"),
                    new DataColumn("Antwort3"),
                    new DataColumn("Antwort4"),
            });
            fill_DgV();
            new_file = true;
            enable_Input(true);
        }

        private void save_file()
        {
            DataView view = Daten.Tables[0].DefaultView;
            view.Sort = "Nummer ASC";
            DataTable sorted = view.ToTable();
            sorted.WriteXml(filepath);
            geändert = false;
            MessageBox.Show("Datei wurde gespeichert");
        }

        private void Fragen_ResizeEnd(object sender, EventArgs e)
        {
            if(DgV_1.DataSource!=null)
            {
                DgV_1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DgV_1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DgV_1.DoubleBuffered(false);
            }
        }

        private void Fragen_ResizeBegin(object sender, EventArgs e)
        {
            if(DgV_1.DataSource != null)
            {
                DgV_1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                DgV_1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                DgV_1.DoubleBuffered(true);
            }
        }

        private void Sc_Paint_Splitter(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            SplitContainer s = sender as SplitContainer;
            if (s != null)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, s.SplitterRectangle);
            }
        }


        private void Btn_Bild_Click(object sender, EventArgs e)
        {
            OpenFileDialog Bild = new OpenFileDialog();
            Bild.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            Bild.FilterIndex = 0;
            Bild.DefaultExt = "*.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (picturepath != "")
                Bild.InitialDirectory = picturepath;

            if(Bild.ShowDialog() == DialogResult.OK)
            {
                if (Bild.FileName.EndsWith(".jpg")|| Bild.FileName.EndsWith(".jpeg")|| Bild.FileName.EndsWith(".png")|| Bild.FileName.EndsWith(".jpe")|| Bild.FileName.EndsWith(".jfif"))
                {
                    Pnl_Bild.BackgroundImage = Image.FromFile(Bild.FileName);
                    Pnl_Bild.Tag = Path.GetFileName(Bild.FileName);
                    Btn_Delete_Picture.Enabled = true;
                    //TxB_Bild.Text = Path.GetFileName(Bild.FileName);
                }
                else
                {
                    MessageBox.Show("Dieser Dateityp wird nicht unterstützt. Wählen Sie bitte eine Bilddatei aus", "Falscher Dateityp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Btn_New_File_Click(object sender, EventArgs e)
        {
            if (!geändert)
            {
                create_new_file();
            }
            else
            {
                switch (MessageBox.Show("Wollen Sie die veränderte Datei speichern", "Änderungen speichern?", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        save_file();
                        create_new_file();
                        break;

                    case DialogResult.No:
                        create_new_file();
                        break;

                    case DialogResult.Cancel:
                        return;
                }
            }
        }

        private void Btn_Delete_Picture_Click(object sender, EventArgs e)
        {
            Pnl_Bild.BackgroundImage = null;
            Pnl_Bild.Tag = "";
            Btn_Delete_Picture.Enabled = false;
            Label_Bild.Visible = false;
        }


        private void Btn_Change_Row_Click(object sender, EventArgs e)
        {
            row_is_edited = true;
            DataGridViewRow sel_row;

            if (DgV_1.SelectedRows.Count == 1)
                sel_row = DgV_1.SelectedRows[0];
            else
                sel_row = DgV_1.SelectedCells[0].OwningRow;



            foreach (Control ctrl in Eingabefelder)
            {
                ctrl.Text = sel_row.Cells[ctrl.Name.Replace("TxB_","")].Value.ToString();
            }

            if(sel_row.Cells["Bild"].Value.ToString() != "")
            {
                try
                {
                    Label_Bild.Visible = false;
                    Pnl_Bild.Tag = sel_row.Cells["Bild"].Value.ToString();
                    Pnl_Bild.BackgroundImage = Image.FromFile(picturepath + "\\" + sel_row.Cells["Bild"].Value.ToString());
                    
                }
                catch
                {
                    Label_Bild.Visible = true;
                    Label_Bild.Text = "Bild kann nicht dargestellt werden! \n Überprüfen Sie ob Sie den richtigen Ordner ausgwählt haben";
                }
                Btn_Delete_Picture.Enabled = true;
            }
            else
            {
                Pnl_Bild.BackgroundImage = null;
                Pnl_Bild.Tag = "";
            }

            tbl_Eingabefelder.Tag = sel_row.Index;
            Btn_dismiss_changes_row.Enabled = true;
            Btn_save_changes_row.Enabled = true;
            Btn_Delete_Row.Enabled = false;
            Btn_Change_Cell.Enabled = false;
            
        }

        private void Btn_Delete_Row_Click(object sender, EventArgs e)
        {
            string text;

            if(row_is_edited)
            {
                MessageBox.Show("Es können keine Zeilen entfernt werden solang eine Zeile bearbeitet wird!","Fehler beim Entfernen",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            if (DgV_1.SelectedRows.Count == 1 || DgV_1.SelectedCells.Count == 1)
                text = "Wollen Sie diese Zeile wirklich entfernen?";
            else
                text = "Wollen Sie diese Zeilen wirklich entfernen";

            if (MessageBox.Show(text, "Entfernen", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            if(DgV_1.SelectedCells.Count == 1)
            {
                DgV_1.Rows.RemoveAt(DgV_1.SelectedCells[0].RowIndex);
            }
            else
            {
                foreach (DataGridViewRow item in DgV_1.SelectedRows)
                {
                    DgV_1.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void Btn_Picture_Path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Path.GetDirectoryName(filepath);

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                picturepath = fbd.SelectedPath;
                if(Pnl_Bild.Tag.ToString() != "")
                {
                    Pnl_Bild.BackgroundImage = Image.FromFile(picturepath + "\\" + Pnl_Bild.Tag.ToString());
                    Label_Bild.Visible = false;
                }
            }

        }

        private void enable_Input(Boolean enabled = true)
        {
            foreach (Control ctrl in Eingabefelder)
            {
                ctrl.Enabled = enabled;
                ctrl.Text = "";
            }
            Btn_dismiss_changes_row.Enabled = false;
            Btn_save_changes_row.Enabled = false;
            Pnl_Bild.BackgroundImage = null;
            Pnl_Bild.Tag = "";
            Label_Bild.Visible = false;
            row_is_edited = false;
        }

        private void disable_change_row(Boolean save_changes = true)
        {
            if (save_changes)
            {
                DataGridViewRow row = DgV_1.Rows[(int)tbl_Eingabefelder.Tag];

                Boolean changes = false;

                foreach (Control ctrl in Eingabefelder)
                {
                    string name = ctrl.Name.Replace("TxB_", "");
                    if (row.Cells[name].Value.ToString() != ctrl.Text)
                    {
                        changes = true;
                        row.Cells[name].Value = ctrl.Text;
                    }
                }
                if (row.Cells["Bild"].Value != Pnl_Bild.Tag)
                {
                    row.Cells["Bild"].Value = Pnl_Bild.Tag;
                    changes = true;
                }
                if (geändert == false)
                    geändert = changes;
                    

            }

            foreach (Control ctrl in Eingabefelder)
                ctrl.Text = "";

            Pnl_Bild.BackgroundImage = null;
            Pnl_Bild.Tag = "";
            Label_Bild.Visible = false;

            tbl_Eingabefelder.Tag = "";
            Btn_dismiss_changes_row.Enabled = false;
            Btn_save_changes_row.Enabled = false;
            row_is_edited = false;

            Btn_Delete_Row.Enabled = true;
            Btn_Change_Cell.Enabled = true;
            Btn_Delete_Picture.Enabled = false;
        }

        private void Change_row(object sender, EventArgs e)
        {
            if (sender == Btn_save_changes_row)
            {
                disable_change_row();
            }
            else
            {
                disable_change_row(false);
            }
        }

            

        private void fill_DgV()
        {
            DgV_1.DataSource = null;
            DgV_1.Rows.Clear();
            DgV_1.Refresh();
            DgV_1.DataSource = Daten.Tables[0];
            DgV_1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgV_1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            geändert = false;
            Btn_Add_Picture.Enabled = true;
            Btn_Picture_Path.Enabled = true;
        }
    }

    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
