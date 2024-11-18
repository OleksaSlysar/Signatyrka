namespace Signatyrka
{
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Gra settingsGra1 = new Form_Gra();
            settingsGra1.ShowDialog();
            this.Close();
        }

        private void Form_menu_Load(object sender, EventArgs e)
        {

        }

        private void b_Setting_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
