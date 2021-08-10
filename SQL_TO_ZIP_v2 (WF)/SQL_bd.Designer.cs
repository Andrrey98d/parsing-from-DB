
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
            this.fOURTHROWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIFTHROWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIXTHROWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.itpDataSet = new SQL_TO_ZIP_v2__WF_.itpDataSet();
            this.tableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.itpActualTable = new SQL_TO_ZIP_v2__WF_.itpActualTable();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itpDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.tableTableAdapter = new SQL_TO_ZIP_v2__WF_.itpActualTableTableAdapters.tableTableAdapter();
            this.tableTableAdapter2 = new SQL_TO_ZIP_v2__WF_.itpDataSetTableAdapters.tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpActualTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSetBindingSource)).BeginInit();
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
            this.tHIRDROWDataGridViewTextBoxColumn,
            this.fOURTHROWDataGridViewTextBoxColumn,
            this.fIFTHROWDataGridViewTextBoxColumn,
            this.sIXTHROWDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(4, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
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
            // fOURTHROWDataGridViewTextBoxColumn
            // 
            this.fOURTHROWDataGridViewTextBoxColumn.DataPropertyName = "FOURTH ROW";
            this.fOURTHROWDataGridViewTextBoxColumn.HeaderText = "FOURTH ROW";
            this.fOURTHROWDataGridViewTextBoxColumn.Name = "fOURTHROWDataGridViewTextBoxColumn";
            // 
            // fIFTHROWDataGridViewTextBoxColumn
            // 
            this.fIFTHROWDataGridViewTextBoxColumn.DataPropertyName = "FIFTH ROW";
            this.fIFTHROWDataGridViewTextBoxColumn.HeaderText = "FIFTH ROW";
            this.fIFTHROWDataGridViewTextBoxColumn.Name = "fIFTHROWDataGridViewTextBoxColumn";
            // 
            // sIXTHROWDataGridViewTextBoxColumn
            // 
            this.sIXTHROWDataGridViewTextBoxColumn.DataPropertyName = "SIXTH ROW";
            this.sIXTHROWDataGridViewTextBoxColumn.HeaderText = "SIXTH ROW";
            this.sIXTHROWDataGridViewTextBoxColumn.Name = "sIXTHROWDataGridViewTextBoxColumn";
            // 
            // tableBindingSource4
            // 
            this.tableBindingSource4.DataMember = "table";
            this.tableBindingSource4.DataSource = this.itpDataSet;
            // 
            // itpDataSet
            // 
            this.itpDataSet.DataSetName = "itpDataSet";
            this.itpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource3
            // 
            this.tableBindingSource3.DataMember = "table";
            this.tableBindingSource3.DataSource = this.itpActualTable;
            // 
            // itpActualTable
            // 
            this.itpActualTable.DataSetName = "itpActualTable";
            this.itpActualTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.materialButton2.Location = new System.Drawing.Point(7, 346);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(168, 43);
            this.materialButton2.TabIndex = 11;
            this.materialButton2.Text = "СОХРАНИТЬ В БД";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.MaterialButton2_Click);
            // 
            // materialProgressBar2
            // 
            this.materialProgressBar2.Depth = 0;
            this.materialProgressBar2.Location = new System.Drawing.Point(4, 334);
            this.materialProgressBar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar2.Name = "materialProgressBar2";
            this.materialProgressBar2.Size = new System.Drawing.Size(171, 5);
            this.materialProgressBar2.TabIndex = 17;
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableTableAdapter2
            // 
            this.tableTableAdapter2.ClearBeforeFill = true;
            // 
            // SQL_bd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 425);
            this.Controls.Add(this.materialProgressBar2);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SQL_bd";
            this.Text = "Database parser";
            this.Load += new System.EventHandler(this.SQL_bd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpActualTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.BindingSource table1BindingSource;
 
        private System.Windows.Forms.BindingSource itpDataSetBindingSource;

        private System.Windows.Forms.BindingSource itpDataSetBindingSource1;


 
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar2;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private itpActualTable itpActualTable;
        private System.Windows.Forms.BindingSource tableBindingSource3;
        private itpActualTableTableAdapters.tableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTROWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECONDROWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHIRDROWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fOURTHROWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIFTHROWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIXTHROWDataGridViewTextBoxColumn;
        private itpDataSet itpDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource4;
        private itpDataSetTableAdapters.tableTableAdapter tableTableAdapter2;
    }
}