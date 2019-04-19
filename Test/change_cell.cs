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
    public partial class change_cell : Form
    {
        public string send_cell;
        public string ret_str;
        public change_cell()
      
        {
            InitializeComponent();
           
        }

        private void change_cell_Load(object sender, EventArgs e)
        {
            textBox1.Text = send_cell;
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            ret_str = textBox1.Text;
            this.Close();
        }

        private void Btn_Accept_Click(object sender, EventArgs e)
        {
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            ret_str = send_cell;
            this.Close();
        }

    }
}
