namespace test56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if(username == "Nsbm" && password == "1234")
            {
                Form3 homepage = new Form3();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect your User name and password!","Login credentials error" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 Signup = new Form2();
            Signup.Show();
            this.Hide();

        }
    }
}
