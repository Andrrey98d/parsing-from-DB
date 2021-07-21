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
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using System.Data.SqlClient;

namespace SQL_TO_ZIP_v2__WF_
{
    public partial class SQL_bd : MaterialForm
    {
        public const string CON = @"Data Source = D:\usersdata.db;Version=3;";
        public SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-9MRV6E2;Initial Catalog=itp;Integrated Security=True"); //на случай если наша бд под паролем, и есть имя юзера
        public const string QUERY = "SELECT * FROM Users";
        public const string serverQuery = "SELECT * FROM dbo.table";
        public SqlCommand delete_row_cmd = new SqlCommand("Delete Users where ID = ");
        public static int Index_ { get; set; }

        public SQL_bd()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void SQL_bd_Load(object sender, EventArgs e)
        {
            this.tableTableAdapter1.Fill(this.itpDataSet1.table);

        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumnCollection col = dataGridView1.Columns;
            int index_ = dataGridView1.CurrentCell.ColumnIndex;
            string file_path_ = @"D:\\" + col[index_].HeaderText + ".txt";
            StreamWriter sw_ = new StreamWriter(file_path_, false, Encoding.Default);
            var column_ind_ = dataGridView1.CurrentCell.ColumnIndex; //!!!
            var col_values = dataGridView1.Columns[column_ind_]; // !!!
            var row = this.dataGridView1.CurrentRow;
            var row_index = dataGridView1.CurrentCell.RowIndex;
            sw_.Write($"Current row (index: {row_index}): \n");
            row.Cells.Cast<DataGridViewCell>().ToList().ForEach(cell =>
                {
                    textBox2.Text += (String.Join("", (string.Format("{0}", cell.Value)))) + "\n";
                    sw_.Write(String.Join("", (string.Format("{0}", cell.Value))));
                });
            string res = null;
            int rowIndex_ = e.RowIndex; // edited 08.07, added e_rowindex 
            int columnIndex_ = e.ColumnIndex;
            _ = 0;
            List<string> row_values_ = new List<string>();
            res += String.Join(" ", row_values_) + "\n";
            DataGridViewRow selectedRow = dataGridView1.Rows[row_index];

            textBox3.Text = "";
            var header_ = col[index_].HeaderText;
            textBox3.Text += header_;
            string path = @"D:\\" + header_ + "\\";
            DirectoryInfo dirI = Directory.CreateDirectory(path);
            DirectoryInfo dirInf = new DirectoryInfo(path);
            if (dirInf.Exists)
            {
                MessageBox.Show("Current directory already exists!");
            }
            else if (!dirInf.Exists)
            {
                Directory.CreateDirectory(path);
                MessageBox.Show($"Directory {header_} created");
            }
            var id = selectedRow.Cells[0].Value;
            var cur_ = dataGridView1.CurrentCell.Value;
            textBox1.Text = cur_.ToString();
            string archive_path = path  + "GUID" + "[" + row.Index + "]" + ".zip";
            using (var zip_ = new ZipFile(archive_path))
            {
                using (sw_)
                {
                    sw_.WriteLine("\n");
                    sw_.WriteLine($"Current column: \n{col[index_].HeaderText}");
                    sw_.WriteLine($"\nCurrent column values:");
                    Index_ = dataGridView1.CurrentCell.ColumnIndex;
                    List<string> column_rows = new List<string>();
                    for (int arg_ = 0; arg_ < dataGridView1.Rows.Count; arg_++)
                    {
                        column_rows.Add((string)dataGridView1[Index_, dataGridView1.Rows[arg_].Index].Value);
                    }
                    foreach (var func_ in column_rows)
                    {
                        textBox4.Text += (string)func_;
                        sw_.Write(String.Join("", (string.Format("{0}", func_))) + "\n");
                    }
                    sw_.WriteLine($"Current dataGridView value: \n{cur_}");
                    zip_.Comment = res;
                    if (zip_.ContainsEntry(file_path_))
                    {
                        zip_.UpdateFile(file_path_);
                        MessageBox.Show("File already exists. Updated!");
                    }
                    else if (!zip_.Name.Contains(file_path_))
                    {
                        zip_.AddFile(file_path_);
                        MessageBox.Show("File added");
                    }
                    for (int i = 0; i < dataGridView1.RowCount; i++) {
                        var loop_row = dataGridView1.Rows[i];
                        loop_row.Cells.Cast<DataGridViewCell>().ToList().ForEach(lr_cell => 
                        {
                        zip_.Comment += (String.Join("  ", (string.Format("{0}", lr_cell.Value))));
                        });
                    }
                    zip_.Save();
                    sw_.Close();
                    MessageBox.Show("Done!");
                }
            }

            _ = @"D:\\" + col[index_].HeaderText + ".zip";
            _ = @"D:\\" + row.Index + ".zip"; // archive path

            DataGridViewColumn newColumn = dataGridView1.Columns.GetColumnCount
            (DataGridViewElementStates.Selected) == 1 ? dataGridView1.SelectedColumns[columnIndex_] : null;//.SelectAll()  // dataGridView1.SelectedColumns
                                                                                                           //zip.Comment += res_;
                                                                                                           //string[] comment_sections = zip.Comment.Split('\n');
                                                                                                           //if (comment_sections.Length > dataGridView1.Columns.Count) // сделать чтобы если количество коментов (1 комент = 1 строка с таблицы) выше этих строк (rows)                                           // то ничего не добавлять, т.е не дублировать результаты
                                                                                                           //{
                                                                                                           //    zip.Comment = "";
                                                                                                           //}
        }
        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //не нужно, но пусть пока повисит
        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            materialProgressBar2.Maximum = 10;
            materialProgressBar2.Step = 1;
            for (int x = 0; x < 10; x++)
            {
                materialProgressBar2.PerformStep();
            }
            this.Validate();
            this.tableBindingSource2.EndEdit();
            this.tableTableAdapter1.Update(this.itpDataSet1.table); //!!! добавить апдейтер по делеткомманд
            SqlDataAdapter sqa = new SqlDataAdapter();
            sqa.Update(this.itpDataSet1);
            MessageBox.Show("Updated");
            materialProgressBar2.Value = 0;
        }
        private void MaterialButton3_Click(object sender, EventArgs e)
        {
            DataGridViewColumnCollection col = dataGridView1.Columns;
            string info_path = @"D:\"; //drInf.GetFiles().ToList()
            string[] dirFiles_ = Directory.GetFiles(info_path);
            int counted_ = dirFiles_.Count();//получили пронумерованый лист, под кастом, теперь нужно пошагово пройтись сверкой по всем значениям, со значениями с столбцов таблицы
            int count = 0;

            for (int z = 0; z < counted_; z++)
            {
                for (int i = 0; i < col.Count; i++)
                {
                    if ((dirFiles_[z].ToString().Substring(3, (col[i].HeaderText.Length - 5)) == (col[i].HeaderText)))
                    {
                        count++;
                        materialProgressBar1.PerformStep();
                        File.Delete(dirFiles_[z]);
                        MessageBox.Show($"Найдено совпадений: {count}. Удалено файлов: {count}. Последний удаленный файл: {col[i].HeaderText}");
                    }
                }
            }
            materialProgressBar2.Value = 0;
            //информация о выбранной ячейке  //string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            /*Using the bove code you will get value of the cell you clicked.If you want to get value of paricular column in the clicked row, just replace
            se.ColumnIndex with the column index you want*/ //for(int z = 0; z< dirFiles_.Count; i++){if(dirFiles_[z] == }
        }

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }
        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (e.KeyCode == Keys.Shift && dataGridView1.CurrentRow.Selected)
            {
                dataGridView1.Rows[index].Selected = true;
            }
        }
        private void MaterialButton4_Click(object sender, DataGridViewCellEventArgs e)
        {
            int index_ = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[$"{index_}"].FormattedValue.ToString());
            connectionString.Open();
            SqlCommand row_del = new SqlCommand($"Delete Users where {index_} = '" + id + "'", connectionString);
            row_del.ExecuteNonQuery();
            MessageBox.Show("Success");
            connectionString.Close();
            //dataGridView1.Rows[index_].Selected = true;
            //int rowIndex = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows.RemoveAt(rowIndex);
        }
        private void materialButton5_Click(object sender, EventArgs e)
        {
            textBox4.Text = null;
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
        }
    }
}