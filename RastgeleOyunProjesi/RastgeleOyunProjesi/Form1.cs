using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleOyunProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rast=new Random();
            int s1, s2, s3, s4, s5, s6;
            s1= rast.Next(1,20);
            s2= rast.Next(1,20);
            s3= rast.Next(1,20);
            s4= rast.Next(1,20);
            s5= rast.Next(1,20);
            s6= rast.Next(1,20);
            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();
            label5.Text = s5.ToString();
            label6.Text = s6.ToString();
            //sayi1
            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;

            }
            //sayi2

            if (textBox2.Text == label2.Text)
                {
                    textBox2.BackColor = Color.Green;
                }
                else
                {
                    textBox2.BackColor = Color.Red;
                }

                //sayi3

                if (textBox3.Text == label3.Text)
                {
                    textBox3.BackColor = Color.Green;
                }
                else
                {
                    textBox3.BackColor = Color.Red;
                }

                //sayi4

                if (textBox4.Text == label4.Text)
                {
                    textBox4.BackColor = Color.Green;
                }
                else
                {
                    textBox4.BackColor = Color.Red;
                }

                //sayi5

                if (textBox5.Text == label5.Text)
                {
                    textBox5.BackColor = Color.Green;
                }
                else
                {
                    textBox5.BackColor = Color.Red;
                }
            //sayi6

            if (textBox6.Text == label6.Text)
            {
                textBox6.BackColor = Color.Green;
            }
            else
            {
                textBox6.BackColor = Color.Red;
            }

        }
       
    }
}
