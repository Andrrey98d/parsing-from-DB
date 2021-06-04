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
using System.Data.SQLite;


namespace SQL_TO_ZIP_v2__WF_
{
    public partial class SQL_bd : Form
    {
        public const string CON = @"Data Source = D:\usersdata.db;Version=3;";
        public const string connectionString = @"Data Source=DESKTOP-9MRV6E2;Initial Catalog=itp;Integrated Security=True";
        //на случай если
        //наша бд под паролем, и есть имя юзера
        public const string QUERY = "SELECT * FROM Users";
        public const string serverQuery = "SELECT * FROM dbo.table";
        public SQL_bd()
        {
            InitializeComponent();   
        }

        private void SQL_bd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "itpDataSet.table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.itpDataSet.table);

        }

        private void show_ds_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> column_values = new List<string>();
            List<string> selected_values = new List<string>();
            //string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            _ = e.RowIndex;
            var row_index = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[row_index];
            for (int z = 0; z < selectedRow.Cells.Count; z++)
            {
                selected_values.Add(selectedRow.Cells[z].Value.ToString());
            }
            foreach (var val in selected_values)
            {
                textBox1.Text += val + " ";
            }
            int index = e.ColumnIndex;
            int index_ = dataGridView1.CurrentCell.ColumnIndex;
            var cell_index = dataGridView1.CurrentCell.OwningColumn.Index;
            DataGridViewColumn col = dataGridView1.Columns[index];
            textBox3.Text += col;
            string path = "D:\\";
            string filename = "=>ID_guid foreach";
            OpenFileDialog ofd = new OpenFileDialog();
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.Cancel) 
                return;
            sfd.InitialDirectory = path;

            //DataGridViewCellCollection cells = DataRow[row_index].Cells;
            /*    string[] values = cells;  */
            //сюда прикручиваем архивацию по 7зип, добавляем содержимое текста в archivecomments. так же, можно сплитом повыдергивать значения, для занесения инфы в path
            // !!!-!!! ДОБАВИТЬ ЧТОБЫ ПРИ ВЫБОРЕ ЯЧЕЙКИ ОНО АВТОМАТОМ ПОДГОНЯЛО ВСЮ СТРОКУ И ХЕАДЕР
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.ColumnIndex;
            _ = dataGridView1.CurrentCell.ColumnIndex;
            DataGridViewColumn col = dataGridView1.Columns[index];
            textBox2.Text += col.HeaderText;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            table1BindingSource.EndEdit();
            tableTableAdapter.Update(itpDataSet);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //информация о выбранной ячейке  //string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
        //MessageBox.Show(value);
    }
}
    //      string value =
    //datagridviewID.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString(); 

    /*Using the bove code you will get value of the cell you clicked.If you want to get value of paricular column in the clicked row, just replace
     e.ColumnIndex with the column index you want*/