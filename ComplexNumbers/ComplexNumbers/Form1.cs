using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            try
            {
                var x = new Complex(
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text)
                );

                var y = new Complex(
                   Convert.ToInt32(textBox3.Text),
                   Convert.ToInt32(textBox4.Text)
                );
            
                var sum = new Complex();
                var zero = new Complex();
                sum = x + y;

                label1.Text += "x este: " + x.ToString() + "\n";
                label1.Text += "y este: " + y.ToString() + "\n";
                label1.Text += "\n";
                label1.Text += "suma este: " + (x+y).ToString() + "\n";
                label1.Text += "diferenta este: " + (x - y).ToString() + "\n";
                label1.Text += "|x| este: " + x.Modulus().ToString() + "\n";
                label1.Text += "|y| este: " + y.Modulus().ToString() + "\n";

            }
            catch
            {
                MessageBox.Show("There was an error converting the numbers to int.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
