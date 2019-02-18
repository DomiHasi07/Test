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
            this.tbl_Eingabefelder = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Layout_Main = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tbl_Eingabefelder.SuspendLayout();
            this.tbl_Buttons.SuspendLayout();
            this.tbl_Layout_Main.SuspendLayout();
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
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(991, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // Btn_Load
            // 
            this.Btn_Load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Load.Location = new System.Drawing.Point(3, 3);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(241, 28);
            this.Btn_Load.TabIndex = 1;
            this.Btn_Load.Text = "Load";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // TxB_Themengebiet
            // 
            this.TxB_Themengebiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxB_Themengebiet.Location = new System.Drawing.Point(3, 23);
            this.TxB_Themengebiet.Name = "TxB_Themengebiet";
            this.TxB_Themengebiet.Size = new System.Drawing.Size(159, 20);
            this.TxB_Themengebiet.TabIndex = 2;
            // 
            // TxB_Frage
            // 
            this.TxB_Frage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxB_Frage.Location = new System.Drawing.Point(168, 23);
            this.TxB_Frage.Name = "TxB_Frage";
            this.TxB_Frage.Size = new System.Drawing.Size(159, 20);
            this.TxB_Frage.TabIndex = 3;
            // 
            // TxB_Antwort1
            // 
            this.TxB_Antwort1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxB_Antwort1.Location = new System.Drawing.Point(333, 23);
            this.TxB_Antwort1.Name = "TxB_Antwort1";
            this.TxB_Antwort1.Size = new System.Drawing.Size(159, 20);
            this.TxB_Antwort1.TabIndex = 4;
            // 
            // TxB_Antwort2
            // 
            this.TxB_Antwort2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxB_Antwort2.Location = new System.Drawing.Point(498, 23);
            this.TxB_Antwort2.Name = "TxB_Antwort2";
            this.TxB_Antwort2.Size = new System.Drawing.Size(159, 20);
            this.TxB_Antwort2.TabIndex = 5;
            // 
            // TxB_Antwort3
            // 
            this.TxB_Antwort3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxB_Antwort3.Location = new System.Drawing.Point(663, 23);
            this.TxB_Antwort3.Name = "TxB_Antwort3";
            this.TxB_Antwort3.Size = new System.Drawing.Size(159, 20);
            this.TxB_Antwort3.TabIndex = 6;
            // 
            // TxB_Antwort4
            // 
            this.TxB_Antwort4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxB_Antwort4.Location = new System.Drawing.Point(828, 23);
            this.TxB_Antwort4.Name = "TxB_Antwort4";
            this.TxB_Antwort4.Size = new System.Drawing.Size(160, 20);
            this.TxB_Antwort4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Themengebiet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(168, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Antwort";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(333, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "richtige Antwort";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(498, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Antwort 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(663, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Antwort 3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(828, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Antwort 4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_CreatXml
            // 
            this.Btn_CreatXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_CreatXml.Location = new System.Drawing.Point(250, 3);
            this.Btn_CreatXml.Name = "Btn_CreatXml";
            this.Btn_CreatXml.Size = new System.Drawing.Size(241, 28);
            this.Btn_CreatXml.TabIndex = 14;
            this.Btn_CreatXml.Text = "Create_Xml";
            this.Btn_CreatXml.UseVisualStyleBackColor = true;
            this.Btn_CreatXml.Click += new System.EventHandler(this.Btn_CreatXml_Click);
            // 
            // cBx_Dateipfad
            // 
            this.cBx_Dateipfad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBx_Dateipfad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBx_Dateipfad.FormattingEnabled = true;
            this.cBx_Dateipfad.Location = new System.Drawing.Point(744, 3);
            this.cBx_Dateipfad.Name = "cBx_Dateipfad";
            this.cBx_Dateipfad.Size = new System.Drawing.Size(244, 21);
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
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(497, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Create_Xml";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbl_Eingabefelder
            // 
            this.tbl_Eingabefelder.ColumnCount = 6;
            this.tbl_Eingabefelder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Eingabefelder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Eingabefelder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Eingabefelder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Eingabefelder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Eingabefelder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_Eingabefelder.Controls.Add(this.TxB_Themengebiet, 0, 1);
            this.tbl_Eingabefelder.Controls.Add(this.TxB_Frage, 1, 1);
            this.tbl_Eingabefelder.Controls.Add(this.TxB_Antwort1, 2, 1);
            this.tbl_Eingabefelder.Controls.Add(this.TxB_Antwort2, 3, 1);
            this.tbl_Eingabefelder.Controls.Add(this.TxB_Antwort3, 4, 1);
            this.tbl_Eingabefelder.Controls.Add(this.TxB_Antwort4, 5, 1);
            this.tbl_Eingabefelder.Controls.Add(this.label6, 5, 0);
            this.tbl_Eingabefelder.Controls.Add(this.label1, 0, 0);
            this.tbl_Eingabefelder.Controls.Add(this.label5, 4, 0);
            this.tbl_Eingabefelder.Controls.Add(this.label2, 1, 0);
            this.tbl_Eingabefelder.Controls.Add(this.label4, 3, 0);
            this.tbl_Eingabefelder.Controls.Add(this.label3, 2, 0);
            this.tbl_Eingabefelder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Eingabefelder.Location = new System.Drawing.Point(3, 426);
            this.tbl_Eingabefelder.Name = "tbl_Eingabefelder";
            this.tbl_Eingabefelder.RowCount = 2;
            this.tbl_Eingabefelder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Eingabefelder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Eingabefelder.Size = new System.Drawing.Size(991, 44);
            this.tbl_Eingabefelder.TabIndex = 17;
            // 
            // tbl_Buttons
            // 
            this.tbl_Buttons.ColumnCount = 4;
            this.tbl_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Buttons.Controls.Add(this.Btn_Load, 0, 0);
            this.tbl_Buttons.Controls.Add(this.Btn_CreatXml, 1, 0);
            this.tbl_Buttons.Controls.Add(this.button1, 2, 0);
            this.tbl_Buttons.Controls.Add(this.cBx_Dateipfad, 3, 0);
            this.tbl_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Buttons.Location = new System.Drawing.Point(3, 3);
            this.tbl_Buttons.Name = "tbl_Buttons";
            this.tbl_Buttons.RowCount = 1;
            this.tbl_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Buttons.Size = new System.Drawing.Size(991, 34);
            this.tbl_Buttons.TabIndex = 18;
            // 
            // tbl_Layout_Main
            // 
            this.tbl_Layout_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Layout_Main.ColumnCount = 1;
            this.tbl_Layout_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Layout_Main.Controls.Add(this.tbl_Buttons, 0, 0);
            this.tbl_Layout_Main.Controls.Add(this.dataGridView1, 0, 1);
            this.tbl_Layout_Main.Controls.Add(this.tbl_Eingabefelder, 0, 2);
            this.tbl_Layout_Main.Location = new System.Drawing.Point(12, 12);
            this.tbl_Layout_Main.Name = "tbl_Layout_Main";
            this.tbl_Layout_Main.RowCount = 3;
            this.tbl_Layout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Layout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Layout_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_Layout_Main.Size = new System.Drawing.Size(997, 473);
            this.tbl_Layout_Main.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 497);
            this.Controls.Add(this.tbl_Layout_Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tbl_Eingabefelder.ResumeLayout(false);
            this.tbl_Eingabefelder.PerformLayout();
            this.tbl_Buttons.ResumeLayout(false);
            this.tbl_Layout_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void DataGridView1_DataSourceChanged(object sender, System.EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                this.dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                this.dataGridView1.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
                {
                    //store autosized widths
                    int colw = dataGridView1.Columns[i].Width;
                    //remove autosizing
                    dataGridView1.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                    //set width to calculated by autosize
                    dataGridView1.Columns[i].Width = colw;
                }
            }
            
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
        private System.Windows.Forms.TableLayoutPanel tbl_Eingabefelder;
        private System.Windows.Forms.TableLayoutPanel tbl_Buttons;
        private System.Windows.Forms.TableLayoutPanel tbl_Layout_Main;
    }
}

