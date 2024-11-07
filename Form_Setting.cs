using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signatyrka
{
    public partial class Form_Setting : Form
    {
        public Form_Setting()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {

        }

        private void b_povernena_Click(object sender, EventArgs e)
        {
            Form_menu form_menu = new Form_menu();
            form_menu.ShowDialog();
            this.Close();
        }

        private void b_SaveSetting_Click(object sender, EventArgs e)
        {
            Form_Gra GraForm = new Form_Gra();
            GraForm.ShowDialog();
            this.Close();
        }
    }
}
