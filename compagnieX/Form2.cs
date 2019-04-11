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
    public partial class Form2 : Form
    {
        public static string em1;
        public static string em2;
        public static string em3;
        public static string em5;
        public static string em4;
        public static string em6;
        public static string salar1;
        public static string salar2;
        public static string salar3;
        public static string salar4;
        public static string salar5;
        public static string salar6;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Form1.affirm1 == "")
            {
                em1 = textBox1.Text;
                salar1 = textBox2.Text;
                Form f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else if (Form1.affirm1 != "")
            {
                if (Form1.affirm2 == "")
                {
                    em2 = textBox1.Text;
                    salar2 = textBox2.Text;
                    Form f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
                else if (Form1.affirm2 != "")
                {
                    if (Form1.affirm3 == "")
                    {
                        em3 = textBox1.Text;
                        salar3 = textBox2.Text;
                        Form f1 = new Form1();
                        f1.Show();
                        this.Hide();
                    }
                    else if (Form1.affirm3 != "")
                    {
                        if (Form1.affirm4 == "")
                        {
                            em4 = textBox1.Text;
                            salar4 = textBox2.Text;
                            Form f1 = new Form1();
                            f1.Show();
                            this.Hide();
                        }
                        else if (Form1.affirm4 != "")
                        {
                            if (Form1.affirm5 == "")
                            {
                                em5 = textBox1.Text;
                                salar5 = textBox2.Text;
                                Form f1 = new Form1();
                                f1.Show();
                                this.Hide();
                            }
                            else if (Form1.affirm5 != "")
                            {
                                if (Form1.affirm6 == "")
                                {
                                    em6 = textBox1.Text;
                                    salar6 = textBox2.Text;
                                    Form f1 = new Form1();
                                    f1.Show();
                                    this.Hide();
                                }
                                else if (Form1.affirm6 != "")
                                {
                                    
                                    Form f1 = new Form1();
                                    f1.Show();
                                    this.Hide();
                                }
                            }

                        }
                    }
                }
            }


           
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
