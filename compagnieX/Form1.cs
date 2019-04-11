using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compagnieX
{
    public partial class Form1 : Form
    {
        public static string affirm1;
        public static string affirm2;
        public static string affirm3;
        public static string affirm4;
        public static string affirm5;
        public static string affirm6;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox13.Text = Form2.em1;
            textBox14.Text = Form2.em2;
            textBox15.Text = Form2.em3;
            textBox16.Text = Form2.em4;
            textBox17.Text = Form2.em5;
            textBox18.Text = Form2.em6;
            affirm1 = textBox13.Text;
            affirm2 = textBox14.Text;
            affirm3 = textBox15.Text;
            affirm4 = textBox16.Text;
            affirm5 = textBox17.Text;
            affirm6 = textBox18.Text;
            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalvalue = 0;
            int affirm = 0;
            string heure = "h";
            
            affirm = totalvalue;
            if (affirm == totalvalue)
            {
                totalvalue = (int.Parse(textBox6.Text) + int.Parse(textBox5.Text) + int.Parse(textBox4.Text) + int.Parse(textBox7.Text) + int.Parse(textBox8.Text) + int.Parse(textBox9.Text));
                nbheur.Text = totalvalue.ToString();
                nbheur.Text = nbheur.Text + heure;
            }
            else if (textBox6.Text == ""|| textBox5.Text == "" || textBox4.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("ERROR, ALL TEXTBOX HAS TO BE FIELD");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int totalpayé = 0;
            int affirmm = 0;

            affirmm = totalpayé;
            if (affirmm  == totalpayé)
            {
                totalpayé = (int.Parse(textBox1.Text) + int.Parse(textBox3.Text) + int.Parse(textBox2.Text) + int.Parse(textBox12.Text) + int.Parse(textBox10.Text) + int.Parse(textBox11.Text));
                nbmoney.Text = totalpayé.ToString();
                nbmoney.Text = nbmoney.Text + "$";
            }
            else if (textBox6.Text == "" || textBox5.Text == "" || textBox4.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("ERROR, ALL TEXTBOX HAS TO BE FIELD");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int aff = 0;
            int zff = 0;
            int ttm = 0;
            int ttm1 = 0;
            int ttm2 = 0;
            int ttm3 = 0;
            int ttm4 = 0;
            int ttm5 = 0;
            aff = zff;
            if (aff == zff)
            {
                ttm = (int.Parse(textBox6.Text) * int.Parse(Form2.salar1));
                ttm1 = (int.Parse(textBox5.Text) * int.Parse(Form2.salar2));
                ttm2 = (int.Parse(textBox4.Text) * int.Parse(Form2.salar3));
                ttm3 = (int.Parse(textBox7.Text) * int.Parse(Form2.salar4));
                ttm4 = (int.Parse(textBox8.Text) * int.Parse(Form2.salar5));
                ttm5 = (int.Parse(textBox9.Text) * int.Parse(Form2.salar6));
                
                textBox3.Text = ttm1.ToString();
                textBox2.Text = ttm2.ToString();
                textBox1.Text = ttm.ToString();

                textBox12.Text = ttm3.ToString();
                textBox10.Text = ttm4.ToString();
                textBox11.Text = ttm5.ToString();

            }
        }
    }
}
