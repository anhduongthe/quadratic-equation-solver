using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, c, delta;

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập lại kiểu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            delta = (b * b) - (4 * a * c); 
            if (delta < 0)
            {
                richTextBox1.Text = "Phương Trình vô nghiệm";
            }
            else if (delta == 0)
            {
                richTextBox1.Text = "Phương trình bậc 2 có nghiệm \tX1 = X2 =" + Math.Round(-b /2/ a, 2);
            }
            else
            {
                double X1 = Math.Round((-b - Math.Sqrt(delta)) / 2 / a, 2);
                double X2 = Math.Round((-b + Math.Sqrt(delta)) / 2 / a, 2);
                this.richTextBox1.Text = "Phương trình có 2 nghiệm phân biệt \nX1 =" + X1 + "\t\tX2 = " + X2;
            } 
         
        }
    }
}
