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
            Form_Setting settingsForm = new Form_Setting();
            settingsForm.ShowDialog();
            this.Close();
        }

        private void Form_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
