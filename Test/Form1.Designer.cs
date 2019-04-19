namespace Test
{
    partial class Fragen
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
            this.Btn_Change = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lable_7 = new System.Windows.Forms.Label();
            this.TxB_Nummer = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataSet1 = new Test.Data();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(705, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // Btn_Load
            // 
            this.Btn_Load.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Load.Location = new System.Drawing.Point(3, 3);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(170, 26);
            this.Btn_Load.TabIndex = 1;
            this.Btn_Load.Text = "Zeile hinzufügen";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // TxB_Themengebiet
            // 
            this.TxB_Themengebiet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxB_Themengebiet.Location = new System.Drawing.Point(3, 18);
            this.TxB_Themengebiet.Name = "TxB_Themengebiet";
            this.TxB_Themengebiet.Size = new System.Drawing.Size(94, 20);
            this.TxB_Themengebiet.TabIndex = 2;
            // 
            // TxB_Frage
            // 
            this.TxB_Frage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxB_Frage.Location = new System.Drawing.Point(203, 18);
            this.TxB_Frage.Name = "TxB_Frage";
            this.TxB_Frage.Size = new System.Drawing.Size(94, 20);
            this.TxB_Frage.TabIndex = 3;
            // 
            // TxB_Antwort1
            // 
            this.TxB_Antwort1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxB_Antwort1.Location = new System.Drawing.Point(303, 18);
            this.TxB_Antwort1.Name = "TxB_Antwort1";
            this.TxB_Antwort1.Size = new System.Drawing.Size(94, 20);
            this.TxB_Antwort1.TabIndex = 4;
            // 
            // TxB_Antwort2
            // 
            this.TxB_Antwort2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxB_Antwort2.Location = new System.Drawing.Point(403, 18);
            this.TxB_Antwort2.Name = "TxB_Antwort2";
            this.TxB_Antwort2.Size = new System.Drawing.Size(94, 20);
            this.TxB_Antwort2.TabIndex = 5;
            // 
            // TxB_Antwort3
            // 
            this.TxB_Antwort3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxB_Antwort3.Location = new System.Drawing.Point(503, 18);
            this.TxB_Antwort3.Name = "TxB_Antwort3";
            this.TxB_Antwort3.Size = new System.Drawing.Size(94, 20);
            this.TxB_Antwort3.TabIndex = 6;
            // 
            // TxB_Antwort4
            // 
            this.TxB_Antwort4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxB_Antwort4.Location = new System.Drawing.Point(603, 18);
            this.TxB_Antwort4.Multiline = true;
            this.TxB_Antwort4.Name = "TxB_Antwort4";
            this.TxB_Antwort4.Size = new System.Drawing.Size(99, 20);
            this.TxB_Antwort4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Themengebiet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(203, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Frage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(303, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Richtige Antwort";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(403, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Antwort 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(503, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Antwort 3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(603, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Antwort 4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_CreatXml
            // 
            this.Btn_CreatXml.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_CreatXml.Location = new System.Drawing.Point(179, 3);
            this.Btn_CreatXml.Name = "Btn_CreatXml";
            this.Btn_CreatXml.Size = new System.Drawing.Size(170, 26);
            this.Btn_CreatXml.TabIndex = 14;
            this.Btn_CreatXml.Text = "Create_Xml";
            this.Btn_CreatXml.UseVisualStyleBackColor = true;
            this.Btn_CreatXml.Click += new System.EventHandler(this.Btn_CreatXml_Click);
            // 
            // cBx_Dateipfad
            // 
            this.cBx_Dateipfad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cBx_Dateipfad.DropDownHeight = 120;
            this.cBx_Dateipfad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBx_Dateipfad.FormattingEnabled = true;
            this.cBx_Dateipfad.IntegralHeight = false;
            this.cBx_Dateipfad.Location = new System.Drawing.Point(531, 8);
            this.cBx_Dateipfad.Name = "cBx_Dateipfad";
            this.cBx_Dateipfad.Size = new System.Drawing.Size(171, 21);
            this.cBx_Dateipfad.TabIndex = 15;
            this.cBx_Dateipfad.SelectedIndexChanged += new System.EventHandler(this.cBx_Dateipfad_SelectedIndexChanged);
            // 
            // Btn_Change
            // 
            this.Btn_Change.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Change.Location = new System.Drawing.Point(355, 3);
            this.Btn_Change.Name = "Btn_Change";
            this.Btn_Change.Size = new System.Drawing.Size(170, 26);
            this.Btn_Change.TabIndex = 16;
            this.Btn_Change.Text = "Zeile verändern";
            this.Btn_Change.UseVisualStyleBackColor = true;
            this.Btn_Change.Click += new System.EventHandler(this.Btn_Change_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxB_Antwort1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxB_Antwort2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxB_Antwort3, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxB_Frage, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxB_Themengebiet, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxB_Antwort4, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lable_7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxB_Nummer, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 297);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 41);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lable_7
            // 
            this.lable_7.AutoSize = true;
            this.lable_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lable_7.Location = new System.Drawing.Point(103, 0);
            this.lable_7.Name = "lable_7";
            this.lable_7.Size = new System.Drawing.Size(94, 13);
            this.lable_7.TabIndex = 14;
            this.lable_7.Text = "Nummer";
            this.lable_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxB_Nummer
            // 
            this.TxB_Nummer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxB_Nummer.Location = new System.Drawing.Point(103, 18);
            this.TxB_Nummer.Name = "TxB_Nummer";
            this.TxB_Nummer.Size = new System.Drawing.Size(94, 20);
            this.TxB_Nummer.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_Load, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_CreatXml, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cBx_Dateipfad, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Change, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(705, 32);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Fragen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 363);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fragen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button Btn_Change;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lable_7;
        private System.Windows.Forms.TextBox TxB_Nummer;
    }
}

