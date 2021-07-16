
namespace SQL_TO_ZIP_v2__WF_
{
    partial class SQL_bd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQL_bd));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fIRSTROWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECONDROWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHIRDROWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itpDataSet1 = new SQL_TO_ZIP_v2__WF_.itpDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.itpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itpDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter1 = new SQL_TO_ZIP_v2__WF_.itpDataSet1TableAdapters.tableTableAdapter();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIRSTROWDataGridViewTextBoxColumn,
            this.sECONDROWDataGridViewTextBoxColumn,
            this.tHIRDROWDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 261);
            this.dataGridView1.TabIndex = 0;

            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // fIRSTROWDataGridViewTextBoxColumn
            // 
            this.fIRSTROWDataGridViewTextBoxColumn.DataPropertyName = "FIRST ROW";
            this.fIRSTROWDataGridViewTextBoxColumn.HeaderText = "FIRST ROW";
            this.fIRSTROWDataGridViewTextBoxColumn.Name = "fIRSTROWDataGridViewTextBoxColumn";
            // 
            // sECONDROWDataGridViewTextBoxColumn
            // 
            this.sECONDROWDataGridViewTextBoxColumn.DataPropertyName = "SECOND ROW";
            this.sECONDROWDataGridViewTextBoxColumn.HeaderText = "SECOND ROW";
            this.sECONDROWDataGridViewTextBoxColumn.Name = "sECONDROWDataGridViewTextBoxColumn";
            // 
            // tHIRDROWDataGridViewTextBoxColumn
            // 
            this.tHIRDROWDataGridViewTextBoxColumn.DataPropertyName = "THIRD ROW";
            this.tHIRDROWDataGridViewTextBoxColumn.HeaderText = "THIRD ROW";
            this.tHIRDROWDataGridViewTextBoxColumn.Name = "tHIRDROWDataGridViewTextBoxColumn";
            // 
            // tableBindingSource2
            // 
            this.tableBindingSource2.DataMember = "table";
            this.tableBindingSource2.DataSource = this.itpDataSet1;
            // 
            // itpDataSet1
            // 
            this.itpDataSet1.DataSetName = "itpDataSet1";
            this.itpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 160);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(855, 102);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 160);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(855, 309);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(273, 137);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(362, 360);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(168, 43);
            this.materialButton1.TabIndex = 10;
            this.materialButton1.Text = "CLEAR TEXTBOXES";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.MaterialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(7, 360);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(168, 43);
            this.materialButton2.TabIndex = 11;
            this.materialButton2.Text = "SAVE CHANGES";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(600, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Current cell";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(852, 75);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Header";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(852, 280);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(189, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Current cell column header";
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(183, 360);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(171, 43);
            this.materialButton3.TabIndex = 15;
            this.materialButton3.Text = "Delete all datatable files";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.MaterialButton3_Click);
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(183, 348);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(171, 5);
            this.materialProgressBar1.TabIndex = 16;
            // 
            // materialProgressBar2
            // 
            this.materialProgressBar2.Depth = 0;
            this.materialProgressBar2.Location = new System.Drawing.Point(4, 348);
            this.materialProgressBar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar2.Name = "materialProgressBar2";
            this.materialProgressBar2.Size = new System.Drawing.Size(171, 5);
            this.materialProgressBar2.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(600, 309);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(238, 137);
            this.textBox4.TabIndex = 18;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(600, 279);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(159, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Current column values";
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(7, 411);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.Size = new System.Drawing.Size(168, 41);
            this.materialButton4.TabIndex = 20;
            this.materialButton4.Text = "DELETE ROW";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // SQL_bd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 461);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.materialProgressBar2);
            this.Controls.Add(this.materialProgressBar1);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SQL_bd";
            this.Text = "Database parser";
            this.Load += new System.EventHandler(this.SQL_bd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource table1BindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource itpDataSetBindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.BindingSource itpDataSetBindingSource1;
        private itpDataSet1 itpDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource2;
        private itpDataSet1TableAdapters.tableTableAdapter tableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTROWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECONDROWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHIRDROWDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar2;
        private System.Windows.Forms.TextBox textBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private MaterialSkin.Controls.MaterialButton materialButton4;
    }
}