
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);        
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);     
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.itpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itpDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itpDataSet1 = new SQL_TO_ZIP_v2__WF_.itpDataSet1();
            this.tableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter1 = new SQL_TO_ZIP_v2__WF_.itpDataSet1TableAdapters.tableTableAdapter();
            this.fIRSTROWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECONDROWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHIRDROWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(46, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(816, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 160);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1071, 29);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 160);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "SAVE CHANGES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1068, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Header";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1071, 234);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 135);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1068, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Current cell column header";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(853, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
          
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "table";
            this.tableBindingSource1.DataSource = this.itpDataSetBindingSource;
            // 
           
            // 
            // itpDataSet1
            // 
            this.itpDataSet1.DataSetName = "itpDataSet1";
            this.itpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource2
            // 
            this.tableBindingSource2.DataMember = "table";
            this.tableBindingSource2.DataSource = this.itpDataSet1;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
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
            // SQL_bd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 604);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SQL_bd";
            this.Text = "SQL_bd";
            this.Load += new System.EventHandler(this.SQL_bd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource table1BindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource itpDataSetBindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.BindingSource itpDataSetBindingSource1;
        private itpDataSet1 itpDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource2;
        private itpDataSet1TableAdapters.tableTableAdapter tableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTROWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECONDROWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHIRDROWDataGridViewTextBoxColumn;
    }
}