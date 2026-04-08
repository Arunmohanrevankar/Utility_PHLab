namespace Utility_PHLab
{
    public partial class Form1 : Form
    {
        public int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            textBox1.Text = now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            textBox2.Text ="Total Mouse Click's is  ----------->"   + count.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
