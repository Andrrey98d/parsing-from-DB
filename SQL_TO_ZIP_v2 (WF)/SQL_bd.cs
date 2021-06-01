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


        }

        private void show_ds_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqcon = new SQLiteConnection(CON);
            sqcon.Open();
            SQLiteCommand Cmd = new SQLiteCommand(QUERY, sqcon); // or sqcon
            DataTable Dt = new DataTable();
            SQLiteDataAdapter sda = new SQLiteDataAdapter(Cmd);
            sda.Fill(Dt);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> column_values = new List<string>();
            List<string> selected_values = new List<string>();
            foreach (DataGridViewRow Datarow in dataGridView1.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null)
                {
                    for (int i = 0; i < Datarow.Cells.Count; i++)
                    {
                        //MessageBox.Show(Datarow.Cells[i].Value.ToString());
                        column_values.Add(Datarow.Cells[i].Value.ToString());
                        int index = e.RowIndex;
                        var row_index = dataGridView1.CurrentCell.RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[row_index];
                        for (int z = 0; z < selectedRow.Cells.Count; z++)
                        {
                            selected_values.Add(selectedRow.Cells[z].Value.ToString());
                        }
                        MessageBox.Show($"Значения с {selectedRow} строки добавлены в список");
                        foreach (var val in selected_values)
                        {
                            textBox1.Text += val + " ";
                        }
                        //DataGridViewCellCollection cells = DataRow[row_index].Cells;
                    /*    string[] values = cells;  */              }
                }

            }

          //информация о выбранной ячейке  //string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            //MessageBox.Show(value);
        }
        //      string value =
        //datagridviewID.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString(); 

        /*Using the bove code you will get value of the cell you cliked.If you want to get value of paricular column in the clicked row, just replace
         e.ColumnIndex with the column index you want*/
    }
    }



//ArrayList sqlGuidList = new ArrayList();
//sqlGuidList.Add(new SqlGuid("3AAAAAAA-BBBB-CCCC-DDDD-2EEEEEEEEEEE"));
//sqlGuidList.Add(new SqlGuid("2AAAAAAA-BBBB-CCCC-DDDD-1EEEEEEEEEEE"));
//sqlGuidList.Add(new SqlGuid("1AAAAAAA-BBBB-CCCC-DDDD-3EEEEEEEEEEE")); 



//var row_values = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
//MessageBox.Show(row_values);