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

namespace Test
{
    public partial class Fragen : Form
    {
        string filepath;
        DataSet Daten = new DataSet();
        DataTable first_table = new DataTable();
        bool geändert = false;
        Data Dateipfade = new Data();
        TextBox[] Eingabefelder;
        
        public Fragen()
        {
            InitializeComponent();

            Eingabefelder = new TextBox[] { TxB_Antwort1, TxB_Antwort2, TxB_Antwort3, TxB_Antwort4, TxB_Frage, TxB_Nummer, TxB_Themengebiet };

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            dataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
            dataGridView1.RowsAdded += DataGridView1_RowsAdded;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            geändert = true;
            Btn_CreatXml.Enabled = true;
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            geändert = true;
            Btn_CreatXml.Enabled = true;
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
            dr["Antwort1"] = TxB_Antwort1.Text.Trim();
            dr["Antwort2"] = TxB_Antwort4.Text.Trim();
            dr["Antwort3"] = TxB_Antwort2.Text.Trim();
            dr["Antwort4"] = TxB_Antwort3.Text.Trim();
            Daten.Tables[0].Rows.Add(dr);
            TxB_Nummer.Text = "";
            TxB_Themengebiet.Text = "";
            TxB_Frage.Text = "";
            TxB_Antwort1.Text = "";
            TxB_Antwort2.Text = "";
            TxB_Antwort3.Text = "";
            TxB_Antwort4.Text = "";
            Daten.Tables[0].DefaultView.Sort = "Nummer ASC";
            dataGridView1.DataSource = Daten.Tables[0];

        }

        private void Text_geändert(object sender, EventArgs e)
        {
            foreach (TextBox tb in Eingabefelder)
            {
                if (tb.TextLength == 0)
                {
                    Btn_Load.Enabled = false;
                    return;
                }
            }
            Btn_Load.Enabled = true;
        }

        private void Btn_CreatXml_Click(object sender, EventArgs e)
        {
            if (geändert)
            {
                Daten.WriteXml(filepath);
                Btn_CreatXml.Enabled = false;
                geändert = false;
            }
            else
            {
                MessageBox.Show("Bitte zuerst ändern");
            }
            
        }

        private void Btn_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.FilterIndex = 0;
            ofd.DefaultExt = "xml";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                if(String.Equals(Path.GetExtension(ofd.FileName),".xml",StringComparison.OrdinalIgnoreCase))
                {
                    filepath = ofd.FileName;
                    Daten.Clear();
                    Daten.Reset();
                    Daten.ReadXml(filepath);
                    Daten.Tables[0].DefaultView.Sort = "Nummer ASC";

                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = Daten.Tables[0];

                    Btn_CreatXml.Enabled = false;
                    geändert = false;
                }
                else
                {
                    MessageBox.Show("Dieser Dateityp wird nicht unterstützt. Wählen Sie bitte eine XML Datei aus", "Falscher Dateityp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void Btn_Change_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedCells.Count == 1)
            {
                change_cell form = new change_cell();
                form.send_cell = dataGridView1.SelectedCells[0].Value.ToString();
                form.ShowDialog();
                if (form.ret_str != form.send_cell)
                {
                    dataGridView1.SelectedCells[0].Value = form.ret_str.Trim();
                    
                    geändert = true;
                    Btn_CreatXml.Enabled = true;
                    
                }
                form.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedCells.Count == 1)
            {
                Btn_Change.Enabled = true;
            }
            else
            {
                Btn_Change.Enabled = false;
            }
        }
    }
}
