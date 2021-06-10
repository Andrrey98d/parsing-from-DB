using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Zip;
using Aspose.Zip.Saving;
using Aspose.Zip.SevenZip;
using Ionic.Zip;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Server;
using System.IO;
using System.IO.Compression;
using System.Data.SQLite;
using System.Diagnostics;


namespace SQL_TO_ZIP_v2__WF_
{
    public partial class SQL_bd : Form
    {
        public const string CON = @"Data Source = D:\usersdata.db;Version=3;";
        public const string connectionString = @"Data Source=DESKTOP-9MRV6E2;Initial Catalog=itp;Integrated Security=True"; //на случай если наша бд под паролем, и есть имя юзера
        public const string QUERY = "SELECT * FROM Users";
        public const string serverQuery = "SELECT * FROM dbo.table";
        public SQL_bd()
        {
            InitializeComponent();
        }

        private void SQL_bd_Load(object sender, EventArgs e)
        {
            this.tableTableAdapter1.Fill(this.itpDataSet1.table);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> row_values = new List<string>();
            List<string> selected_values = new List<string>();
            string res = null;

            for (int v = 0; v <= dataGridView1.Columns.Count; v++)
            {   
                DataGridViewCellCollection row_ = dataGridView1.Rows[v].Cells; // where row_ is a collection. 1 row = 1 collection
                res += String.Join(" ", row_) + "\n";
            }

            _ = e.RowIndex;
            var row_index = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[row_index];
            int index_ = dataGridView1.CurrentCell.ColumnIndex;
            DataGridViewColumnCollection col = dataGridView1.Columns;
            {
                textBox3.Text = "";
                textBox3.Text += col[index_].HeaderText;
            }
            var id = selectedRow.Cells[0].Value; // add guid/id
            string path_ = @"D:\\" + col[index_].HeaderText + ".txt";
            using (StreamWriter sw_ = new StreamWriter(path_, false, Encoding.Default)) // дозапись
            {
                sw_.WriteLine($"Current column: {col[index_].HeaderText}\n");
                sw_.Close();
            }

            for (int z = 0; z < selectedRow.Cells.Count; z++)
            {
                selected_values.Add(selectedRow.Cells[z].Value.ToString());
            }

            using (StreamWriter sw = new StreamWriter(path_, true, Encoding.Default))
            {
                sw.WriteLine($"Current row (index: {row_index}):  ");
                foreach (var val_ in selected_values)
                {
                    sw.Write(val_ + "");
                }
                sw.WriteLine("\n" + id);
                sw.Close();
            }
           
            _ = @"D:\\" + col[index_].HeaderText + ".zip";
            string archive_path = @"D:\\" + dataGridView1.Name + ".zip";
            _ = String.Join(" ", selected_values.ToArray());
            dataGridView1.SelectAll();
            using (var zip = new ZipFile(archive_path))
            {
                try
                {
                    zip.Comment += res;
                    //zip.Comment += res_;
                    //string[] comment_sections = zip.Comment.Split('\n');
                    //if (comment_sections.Length > dataGridView1.Columns.Count) // сделать чтобы если количество коментов (1 комент = 1 строка с таблицы) выше этих строк (rows)                                           // то ничего не добавлять, т.е не дублировать результаты
                    //{
                    //    zip.Comment = "";
                    //}
                    if (zip.ContainsEntry(path_))
                    {
                        zip.UpdateFile(path_);
                        MessageBox.Show("File updated");
                    }
                    else
                    {
                        zip.AddFile(path_);
                        MessageBox.Show("File added");
                    }
                    zip.Save();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Error occured");
                }
            }
            Process.Start(path_);
            _ = new OpenFileDialog();
            _ = new SaveFileDialog();
           
        }
        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.ColumnIndex;
            _ = dataGridView1.CurrentCell.ColumnIndex;
            DataGridViewColumn col = dataGridView1.Columns[index];
            textBox2.Text = "";
            textBox2.Text += col.HeaderText;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource2.EndEdit();
            this.tableTableAdapter1.Update(this.itpDataSet1.table);
        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void Button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        
        //информация о выбранной ячейке  //string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
        /*Using the bove code you will get value of the cell you clicked.If you want to get value of paricular column in the clicked row, just replace
        se.ColumnIndex with the column index you want*/
    }
}