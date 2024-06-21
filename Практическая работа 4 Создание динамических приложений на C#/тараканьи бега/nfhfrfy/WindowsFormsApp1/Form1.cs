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
        int flag1;
        int x1, x2;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Cnfhn_Click(object sender, EventArgs e)
        {
            flag1 = 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            x1 = 1; x2 = 1;
            tarakan1.Left = x1;
            tarakan2.Left = x2;
            flag1 = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Георгий";
            textBox2.Text = "Геннадий";
            label1.Text = "0";
            label2.Text = "0";
            tarakan1.Left = 1;
            tarakan2.Left = 1;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (flag1 != 0)
            {
                Random a = new Random(); 
                int count = a.Next(8);
                x1 += count;
                label1.Text = Convert.ToString(x1);
                tarakan1.Left = x1;
                count = a.Next(8);
                x2 += count;
                label2.Text = Convert.ToString(x2);
                tarakan2.Left = x2;
            }
            if ((x1 >= 680) || (x2 >= 680))
            {
                flag1 = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
