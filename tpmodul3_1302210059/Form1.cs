namespace tpmodul3_1302210059
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama_praktikan = textBox1.Text;
            label1.Text = "Halo " + nama_praktikan+"!";
        }
    }
}