namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.TxB_Themengebiet = new System.Windows.Forms.TextBox();
            this.TxB_Frage = new System.Windows.Forms.TextBox();
            this.TxB_Antwort1 = new System.Windows.Forms.TextBox();
            this.TxB_Antwort2 = new System.Windows.Forms.TextBox();
            this.TxB_Antwort3 = new System.Windows.Forms.TextBox();
            this.TxB_Antwort4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_CreatXml = new System.Windows.Forms.Button();
            this.cBx_Dateipfad = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new Test.Data();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Key";
            this.dataGridViewTextBoxColumn1.HeaderText = "Key";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Themengebiet";
            this.dataGridViewTextBoxColumn2.HeaderText = "Themengebiet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Frage";
            this.dataGridViewTextBoxColumn3.HeaderText = "Frage";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Antwort1";
            this.dataGridViewTextBoxColumn4.HeaderText = "Antwort1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Antwort2";
            this.dataGridViewTextBoxColumn5.HeaderText = "Antwort2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Antwort3";
            this.dataGridViewTextBoxColumn6.HeaderText = "Antwort3";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Antwort4";
            this.dataGridViewTextBoxColumn7.HeaderText = "Antwort4";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(690, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_Load
            // 
            this.Btn_Load.Location = new System.Drawing.Point(12, 95);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(150, 35);
            this.Btn_Load.TabIndex = 1;
            this.Btn_Load.Text = "Load";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // TxB_Themengebiet
            // 
            this.TxB_Themengebiet.Location = new System.Drawing.Point(12, 320);
            this.TxB_Themengebiet.Name = "TxB_Themengebiet";
            this.TxB_Themengebiet.Size = new System.Drawing.Size(110, 20);
            this.TxB_Themengebiet.TabIndex = 2;
            // 
            // TxB_Frage
            // 
            this.TxB_Frage.Location = new System.Drawing.Point(128, 320);
            this.TxB_Frage.Name = "TxB_Frage";
            this.TxB_Frage.Size = new System.Drawing.Size(110, 20);
            this.TxB_Frage.TabIndex = 3;
            // 
            // TxB_Antwort1
            // 
            this.TxB_Antwort1.Location = new System.Drawing.Point(244, 320);
            this.TxB_Antwort1.Name = "TxB_Antwort1";
            this.TxB_Antwort1.Size = new System.Drawing.Size(110, 20);
            this.TxB_Antwort1.TabIndex = 4;
            // 
            // TxB_Antwort2
            // 
            this.TxB_Antwort2.Location = new System.Drawing.Point(360, 320);
            this.TxB_Antwort2.Name = "TxB_Antwort2";
            this.TxB_Antwort2.Size = new System.Drawing.Size(110, 20);
            this.TxB_Antwort2.TabIndex = 5;
            // 
            // TxB_Antwort3
            // 
            this.TxB_Antwort3.Location = new System.Drawing.Point(476, 320);
            this.TxB_Antwort3.Name = "TxB_Antwort3";
            this.TxB_Antwort3.Size = new System.Drawing.Size(110, 20);
            this.TxB_Antwort3.TabIndex = 6;
            // 
            // TxB_Antwort4
            // 
            this.TxB_Antwort4.Location = new System.Drawing.Point(592, 320);
            this.TxB_Antwort4.Name = "TxB_Antwort4";
            this.TxB_Antwort4.Size = new System.Drawing.Size(110, 20);
            this.TxB_Antwort4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Themengebiet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Antwort";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Frage1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Frage2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Frage3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Frage4";
            // 
            // Btn_CreatXml
            // 
            this.Btn_CreatXml.Location = new System.Drawing.Point(168, 95);
            this.Btn_CreatXml.Name = "Btn_CreatXml";
            this.Btn_CreatXml.Size = new System.Drawing.Size(150, 35);
            this.Btn_CreatXml.TabIndex = 14;
            this.Btn_CreatXml.Text = "Create_Xml";
            this.Btn_CreatXml.UseVisualStyleBackColor = true;
            this.Btn_CreatXml.Click += new System.EventHandler(this.Btn_CreatXml_Click);
            // 
            // cBx_Dateipfad
            // 
            this.cBx_Dateipfad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBx_Dateipfad.FormattingEnabled = true;
            this.cBx_Dateipfad.Location = new System.Drawing.Point(476, 103);
            this.cBx_Dateipfad.Name = "cBx_Dateipfad";
            this.cBx_Dateipfad.Size = new System.Drawing.Size(220, 21);
            this.cBx_Dateipfad.TabIndex = 15;
            this.cBx_Dateipfad.SelectedIndexChanged += new System.EventHandler(this.cBx_Dateipfad_SelectedIndexChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Create_Xml";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBx_Dateipfad);
            this.Controls.Add(this.Btn_CreatXml);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxB_Antwort4);
            this.Controls.Add(this.TxB_Antwort3);
            this.Controls.Add(this.TxB_Antwort2);
            this.Controls.Add(this.TxB_Antwort1);
            this.Controls.Add(this.TxB_Frage);
            this.Controls.Add(this.TxB_Themengebiet);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.TextBox TxB_Themengebiet;
        private System.Windows.Forms.TextBox TxB_Frage;
        private System.Windows.Forms.TextBox TxB_Antwort1;
        private System.Windows.Forms.TextBox TxB_Antwort2;
        private System.Windows.Forms.TextBox TxB_Antwort3;
        private System.Windows.Forms.TextBox TxB_Antwort4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_CreatXml;
        private System.Windows.Forms.ComboBox cBx_Dateipfad;
        private System.Windows.Forms.Button button1;
    }
}

