using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace SQL_TO_ZIP_v2__WF_
{

    public partial class SQL_bd : MaterialForm
    {
        public SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-9MRV6E2;Initial Catalog=itp;Integrated Security=True"); //на случай если наша бд под паролем, и есть имя юзера
        public const string QUERY = "SELECT * FROM Users";
        public const string serverQuery = @"SELECT * FROM [table]";

        public SQL_bd()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.Blue500, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        }
        private void SQL_bd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "itpDataSet.table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter2.Fill(this.itpDataSet.table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "itpActualTable.table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.itpActualTable.table);

        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumnCollection col = dataGridView1.Columns;
            int index_ = dataGridView1.CurrentCell.ColumnIndex;
            var row_index = dataGridView1.CurrentCell.RowIndex;
            var row = this.dataGridView1.CurrentRow;
            var value = dataGridView1[index_, row.Index].Value.ToString().Replace(" ", "");
            //StreamReader sr_ = new StreamReader(file_path_);
            string res = null;
            int rowIndex_ = e.RowIndex;
          
            var header_ = col[index_].HeaderText;
            var cur_ = dataGridView1.CurrentCell.Value;
            string file_path_ = @"D:\\" + col[index_].HeaderText + "(" + value.Substring(0, value.Length) + ")" + ".txt";       
            StreamWriter sw_ = new StreamWriter(file_path_, false, Encoding.Default);
            using (sw_)
            {
                FileInfo flInf = new FileInfo(file_path_);
                sw_.WriteLine($"Current column: \n{col[index_].HeaderText}");

                sw_.Write($"\nCurrent row (index: {row_index}): ");
                sw_.Write("\n");
                row.Cells.Cast<DataGridViewCell>().ToList().ForEach(cell =>
                {
                    sw_.Write(String.Join("", (string.Format("{0}", cell.Value))));
                });

                List<string> column_rows = new List<string>();

                for (int arg_ = 0; arg_ < dataGridView1.Rows.Count; arg_++)
                {           
                        column_rows.Add((string)dataGridView1[index_, dataGridView1.Rows[arg_].Index].Value?.ToString());
                }
              
               
                sw_.WriteLine($"\n\nCurrent column values:");
                foreach (var func_ in column_rows)
                {
                    sw_.Write(String.Join("", (string.Format("{0}", func_))) + "\n");
                }
                sw_.WriteLine($"Current dataGridView value: \n{cur_}"); // при добавке кода в Танину прогу, будет переделена функция записи,                                                     
                sw_.Close();                                           // где вместо дефолтных файлов будут записываться нужные нам файлы.
                /*ищем последний добавленный файл в выбранную директорию, его мы и будем добавлять в архив(-ы).*/


                List<string> row_values_ = new List<string>();
                res += String.Join(" ", row_values_) + "\n"; // zip.comment (+=)

                FolderBrowserDialog fbd = new FolderBrowserDialog();
                string temp_path = "";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    temp_path += fbd.SelectedPath;
                }
                string path = temp_path + header_ + "\\";
                Guid guid = Guid.NewGuid();
                string archive_path = path + "GUID" + "[" + row_index + "]" + guid + ".zip"; // пробный вариант
                string archive_path_2 = path + "";
              
                DirectoryInfo dirInf = new DirectoryInfo(path);

                if (!dirInf.Exists)
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show($"Directory {header_} created");
                }

              
                var directory = new DirectoryInfo("D:\\"); // заменить на temp_path
                var recentFile = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).First();

                string new_path = @"D:\\" + recentFile;
                using (var zip_ = new ZipFile(archive_path))
                {
                    zip_.Comment = null;
                    if (zip_.ContainsEntry(recentFile.ToString()))
                    {
                        zip_.UpdateFile(recentFile.ToString());
                        MessageBox.Show("File already exists. Updated!"); // этот и остальные месседжбоксы подобавлял чисто для себя, потом удалю
                    }
                    else if (!zip_.Name.Contains(recentFile.ToString()))
                    {
                        zip_.AddFile(@"D:\" + recentFile);
                        MessageBox.Show("File added");
                    }
                    var loop_row = dataGridView1.Rows[row_index];
                    loop_row.Cells.Cast<DataGridViewCell>().ToList().ForEach(lr_cell =>
                    {
                        zip_.Comment += (String.Join(" ", (string.Format("{0}", lr_cell.Value))));
                    });
                    try
                    {
                        zip_.Save();
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("FileNotFoundException");
                    }
                }
            }
        }
        private void MaterialButton2_Click(object sender, EventArgs e)
        {
            materialProgressBar2.Maximum = 10;
            materialProgressBar2.Step = 1;
            for (int x = 0; x < 10; x++)
            {
                materialProgressBar2.PerformStep();
            }
            this.Validate();
            this.tableBindingSource4.EndEdit();
            this.tableTableAdapter2.Update(this.itpDataSet.table); //!!! добавить апдейтер по делеткомманд
            SqlDataAdapter sqa = new SqlDataAdapter();  
            sqa.Update(this.itpDataSet);
            MessageBox.Show("Updated");
            materialProgressBar2.Value = 0;
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (e.KeyCode == Keys.Shift && dataGridView1.CurrentRow.Selected)
            {
                dataGridView1.Rows[index].Selected = true;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}