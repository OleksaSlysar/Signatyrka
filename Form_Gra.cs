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
    public partial class Form_Gra : Form
    {
        public Form_Gra()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Gra_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Setting settingsForm = new Form_Setting();
            settingsForm.ShowDialog();
            this.Close();
        }
    }
}
