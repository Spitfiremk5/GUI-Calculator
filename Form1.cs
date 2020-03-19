using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string num1;
        string num2;
        float num11;
        float num22;
        float wynik;
        string wynikW;
        bool Visibility = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = Visibility;
            label2.Text = "+";
            label2.Visible = true;
            wynik = num11 + num22;
            wynikW = wynik.ToString();
            label1.Text =  wynikW;
         
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = textBox1.Text;
            float.TryParse(num1, out num11);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = textBox2.Text;
            float.TryParse(num2, out num22);
        }





        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = Visibility;
            label2.Text = "-";
            label2.Visible = true;
            wynik = num11 - num22;
            wynikW = wynik.ToString();
            label1.Text = wynikW;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = Visibility;
            label2.Text = "X";
            label2.Visible = true;
            wynik = num11 * num22;
            wynikW = wynik.ToString();
            label1.Text = wynikW;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = Visibility;
            label2.Text = ":";
            label2.Visible = true;
            wynik = num11 / num22;
            wynikW = wynik.ToString();
            label1.Text = wynikW;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float bufor = num11;
            for ( int i = 1; i < num22; i++)
            {
               
                num11 = num11 * bufor; 
            }
            wynik = num11;
            wynikW = wynik.ToString();
            label1.Text = wynikW;
            label1.Visible = Visibility;
            label2.Text = "^";
            label2.Visible = true;
            num11 = bufor;
        }

       
    }
}
