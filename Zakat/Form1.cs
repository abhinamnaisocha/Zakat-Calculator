using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zakat
{
    public partial class Form1 : Form
    {

        double gold,goldp,goldprice,silverp,silverprice,silver,p,pp,cash,cashz,total;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Double.TryParse(textBox11.Text, out silverprice) == true)
            {
                silverprice = Convert.ToDouble(textBox11.Text);
            }
            else
            {
                if (textBox11.Text == "")
                {
                    textBox11.Text = "No Input";
                }
                else
                textBox11.Text = "Invalid Input"; 
            }

            if (Double.TryParse(textBox10.Text, out goldprice) == true)
            {
                goldprice = Convert.ToDouble(textBox10.Text);
            }
            else
            {

                if (textBox10.Text == "")
                {
                    textBox10.Text = "No Input";
                }
                else
                {

                    textBox10.Text = "Invalid Input";
                }
            }



            if (Double.TryParse(textBox1.Text, out gold) == true && Double.TryParse(textBox10.Text, out goldprice) == true)
            {
                gold = Double.Parse(textBox1.Text);

                if (gold >= 7.5)
                {
                    gold = gold * goldprice;
                    goldp = gold * 2.5 / 100;
                    textBox4.Text = Convert.ToString(goldp);
                }
                else
                {
                    goldp = 0;
                    textBox4.Text = "No Zakat";
                }

            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox4.Text = "No Input";
                }
                else
                textBox4.Text = "Invalid Input";
            }

            if (Double.TryParse(textBox2.Text, out silver) == true && Double.TryParse(textBox11.Text, out silverprice) == true)
            {
                silver = Convert.ToDouble(textBox2.Text);
                if (silver >= 52.5)
                {
                    silver = silver * silverprice;
                    silverp = silver * 2.5 / 100;
                    textBox5.Text = Convert.ToString(silverp);
                }
                else
                {
                    silverp = 0;
                    textBox5.Text = "No Zakat";
                }
            }
            else
            {
                if (textBox2.Text == "")
                {
                    textBox5.Text = "No Input";
                }
                else
                textBox5.Text = "Invalid Input";
            }


            if (Double.TryParse(textBox8.Text, out cash) == true)
            {
                cash = Double.Parse(textBox8.Text);

                if (cash > 0)
                {
                    cashz = cash * 2.5 / 100;
                    textBox9.Text = Convert.ToString(cashz);
                }
                else
                {
                    cashz = 0;
                    textBox9.Text = "No Zakat";
                }
            }

            else
            {
                if (textBox8.Text == "")
                {
                    textBox9.Text = "No Input";
                }
                else
                {
                    cashz = 0;
                    textBox9.Text = "Invalid Input";
                }
            }

            if (Double.TryParse(textBox6.Text, out p) == true)
            {
                Double.TryParse(textBox6.Text, out p);
                if (p > 0)
                {
                    pp = p * 2.5 / 100;
                    textBox7.Text = Convert.ToString(pp);
                }
                else
                {
                    pp = 0;
                    textBox7.Text = "No Zakat";

                }
            }

            else
            {
                if (textBox6.Text == "")
                {
                    textBox7.Text = "No Input";
                }
                else
                {
                    pp = 0;
                    textBox7.Text = "Invalid Input";
                }
            }

            total = goldp + silverp + pp + cashz;
            textBox3.Text = Convert.ToString(total);

       }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
