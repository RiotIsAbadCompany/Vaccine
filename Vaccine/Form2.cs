using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaccine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DateTime b;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "First name";
            label2.Text = "Last name";
            label3.Text = "EGN";
            label4.Text = "Age";
            label5.Text = "Birth date";
            button1.Text = "OK";
            textBox4.Enabled = false;
            groupBox1.Text = "Sex";
            radioButton1.Text = "Male";
            radioButton2.Text = "Female";
            groupBox1.Enabled = false;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // int Age = DateTime.Today. - dateTimePicker1.Value.Year;
            // DateTime birthdate = dateTimePicker1.Value;
            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^[АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ][абвгдеёжзийклмнопрстуфхцчшщъыьэюя]{1,26}$"))
            {
                //abcde
                panel1.BackColor = Color.Green;
            }
            else
            {
                panel1.BackColor = Color.Red;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^[АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ][АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ]{1,26}$"))
            {
                //abcde
                panel2.BackColor = Color.Green;
            }
            else
            {
                panel2.BackColor = Color.Red;
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"^[0-9]{10,10}$"))
            {
                //abcde
                panel3.BackColor = Color.Green;
            }
            else
            {
                panel3.BackColor = Color.Red;
            }
            if(panel3.BackColor == Color.Green)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            if (textBox3.Text.Length == 10)
            {
                int d = int.Parse(textBox3.Text.Substring(8, 1));
                
              if(d%2 == 0)
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
            }
           
            DateTime zeroTime = new DateTime(1, 1, 1);
            if (textBox3.Text.Length == 10)
            {
                int month = int.Parse(textBox3.Text.Substring(2, 2));
                int year = int.Parse(textBox3.Text.Substring(0, 2));
                int day = int.Parse(textBox3.Text.Substring(4, 2));
                if (month > 12)
                {
                    b = new DateTime(2000 + year, month - 40, day);
                }
                else
                {
                    b = new DateTime(1900 + year, month, day);
                }
                TimeSpan span = DateTime.Now - b;
                textBox4.Text = ((zeroTime + span).Year - 1).ToString();
                dateTimePicker1.Value = b;


                //textBox4.Text = birthdate.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel1.BackColor == Color.Green && panel2.BackColor == Color.Green && panel3.BackColor == Color.Green)
            {
                string message = "Successfull operation";
                MessageBox.Show(message);
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            else
            {
                string message = "Wrong input";
                MessageBox.Show(message);
            }

        }
    }
}
