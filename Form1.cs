using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prevody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CiselneSoustavy ciselneSoustavy = new CiselneSoustavy();

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            //MessageBox.Show(ciselneSoustavy.BinToDec(x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            MessageBox.Show("Převod z dec do bin: "+ciselneSoustavy.DecToBin(x));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            MessageBox.Show("Převod z Hex do dec: " + ciselneSoustavy.HexToDec(x));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            MessageBox.Show("Převod z Hex do Bin: " + ciselneSoustavy.HexToBin(x));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            MessageBox.Show("Převod z Dec do HeX: " + ciselneSoustavy.DecToHex(x));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            MessageBox.Show("Převod z Bin do Hex: " + ciselneSoustavy.BinToHex(x));
        }
    }
}
