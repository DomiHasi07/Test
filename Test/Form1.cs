using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        string filepath;
        DataSet tempDs = new DataSet();
        bool geändert = false;
        Data Dateipfade = new Data();
        
        
        public Form1()
        {
            InitializeComponent();
            tempDs.ReadXml(@"C:\Users\DomiHasi\Documents\Arbeit\Visual Studio\XML_Dateien\Dateipfade.xml");
            int i = 0;
            foreach (DataRow row in tempDs.Tables[0].Rows)
            {
                DataRow tempRow = Dateipfade.Speicherort.NewRow();
                tempRow["Anzeige"] = tempDs.Tables[0].Rows[i]["Anzeige"].ToString();
                tempRow["Dateipfad"] = tempDs.Tables[0].Rows[i]["Dateipfad"].ToString();
                Dateipfade.Tables[0].Rows.Add(tempRow);
                i++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dateipfade.ReadXml(@"C:\Users\DomiHasi\Documents\Arbeit\Visual Studio\XML_Dateien\Dateipfade.xml");
            
            for (int i = 0; i<Dateipfade.Tables[0].Rows.Count;i++)
            {
                cBx_Dateipfad.Items.Add(Dateipfade.Tables[0].Rows[i][2]); 
            }

            dataGridView1.UserDeletedRow += DataGridView1_UserDeletedRow;
            
        }

        private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            geändert = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {

            DataRow dr = Dateipfade.Fragenkatalog.NewRow();
            if(TxB_Themengebiet.TextLength == 0 || TxB_Frage.TextLength == 0|| TxB_Antwort1.TextLength == 0 || TxB_Antwort2.TextLength == 0 || TxB_Antwort3.TextLength == 0 || TxB_Antwort4.TextLength == 0)
            {
                if(TxB_Themengebiet.TextLength == 0)
                {
                    MessageBox.Show("Themengebiet bitte ausfüllen");
                }
                else if (TxB_Frage.TextLength == 0)
                {
                    MessageBox.Show("Fragenfeld bitte ausfüllen");
                }
                else if (TxB_Antwort1.TextLength == 0)
                {
                    MessageBox.Show("Antwortfeld 1 bitte ausfüllen");
                }
                else if (TxB_Antwort2.TextLength == 0)
                {
                    MessageBox.Show("Antwortfeld 2 bitte ausfüllen");
                }
                else if (TxB_Antwort3.TextLength == 0)
                {
                    MessageBox.Show("Antwortfeld 3 bitte ausfüllen");
                }
                else if (TxB_Antwort4.TextLength == 0)
                {
                    MessageBox.Show("Antwortfeld 4 bitte ausfüllen");
                }
            }
            else
            {
                dr["Themengebiet"] = TxB_Themengebiet.Text;
                dr["Frage"] = TxB_Frage.Text;
                dr["Antwort1"] = TxB_Antwort1.Text;
                dr["Antwort2"] = TxB_Antwort4.Text;
                dr["Antwort3"] = TxB_Antwort2.Text;
                dr["Antwort4"] = TxB_Antwort3.Text;
                tempDs.Tables[0].Rows.Add(dr);
                TxB_Themengebiet.Text = "";
                TxB_Frage.Text = "";
                TxB_Antwort1.Text = "";
                TxB_Antwort2.Text = "";
                TxB_Antwort3.Text = "";
                TxB_Antwort4.Text = "";
                geändert = true;
            }
            dataGridView1.DataSource = tempDs.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CreatXml_Click(object sender, EventArgs e)
        {
            if (geändert)
            {
                tempDs.WriteXml(filepath);
                geändert = false;
            }
            else
            {
                MessageBox.Show("Bitte zuerst ändern");
            }
            
        }

        private void cBx_Dateipfad_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            Dateipfade.Fragenkatalog.Clear();
            switch(cBx_Dateipfad.Text)
            {
                case "Fragenkatalog Test1": filepath = Dateipfade.Speicherort.Rows[0]["Dateipfad"].ToString(); break;
                case "Fragenkatalog Test2": filepath = Dateipfade.Speicherort.Rows[1]["Dateipfad"].ToString(); break;
                case "Fragenkatalog Test3": filepath = Dateipfade.Speicherort.Rows[2]["Dateipfad"].ToString(); break;
                case "Fragenkatalog Test4": filepath = Dateipfade.Speicherort.Rows[3]["Dateipfad"].ToString(); break;
            }
           
            tempDs.Reset();
            
            tempDs.ReadXml(filepath);
            int j = 0;
            foreach (DataRow row in tempDs.Tables[0].Rows)
            {
                DataRow dr = Dateipfade.Fragenkatalog.NewRow();
                dr["Themengebiet"] = tempDs.Tables[0].Rows[j]["Themengebiet"];
                dr["Frage"] = tempDs.Tables[0].Rows[j]["Frage"];
                dr["Antwort1"] = tempDs.Tables[0].Rows[j]["Antwort1"];
                dr["Antwort2"] = tempDs.Tables[0].Rows[j]["Antwort2"];
                dr["Antwort3"] = tempDs.Tables[0].Rows[j]["Antwort3"];
                dr["Antwort4"] = tempDs.Tables[0].Rows[j]["Antwort4"];
                Dateipfade.Fragenkatalog.Rows.Add(dr);

            }
            dataGridView1.DataSource = Dateipfade.Fragenkatalog;

        }
    }
}