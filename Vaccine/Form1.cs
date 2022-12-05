namespace Vaccine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Username";
            label2.Text = "Password";
            button1.Text = "OK";
            textBox1.Text = "aaaaa";
            textBox2.Text = "?aaa";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[^0-9][6-9,a-z]{4,7}$"))
            {
                //abcde
                panel1.BackColor = Color.Green;
            }
            else
            {
                panel1.BackColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^[?][0-9,a-z,A-Z]{3,3}$"))
            {
                //?adc
                panel2.BackColor = Color.Green;
            }
            else
            {
              
                panel2.BackColor = Color.Red;
            }

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel1.BackColor == Color.Green && panel2.BackColor == Color.Green)
            {
                string message = "Access granted";
                MessageBox.Show(message);
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                string message = "Illegal credentials";
                MessageBox.Show(message);
            }
        }
    }
}