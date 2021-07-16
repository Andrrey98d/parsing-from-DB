using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Properties;

namespace SQL_TO_ZIP_v2__WF_
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SQL_bd bd = new SQL_bd();
            bd.Show();
        }
        private void window_onclose(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            SQL_bd bd = new SQL_bd();
            bd.Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
