using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            textBox3.Visible = false;
            button5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text);
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string password;
            password = textBox2.Text;
            if (password == "arches")
            {
                groupBox2.Visible = true;
            }
            else
            {
                MessageBox.Show("yanlış şifre girdiniz.");
                textBox2.Text = "";
            
            
            
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            button5.Visible = true;
        }
    }
}
