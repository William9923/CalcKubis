using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Kubis
{
    public partial class CalcKubisForm : Form
    {

        string expr;

        public CalcKubisForm()
        {
            InitializeComponent();
        }

        private void CalcKubisForm_Load(object sender, EventArgs e)
        {
            expr = "";

            numBtn1.Text = "1";
            numBtn1.SetNumber(1);

            numBtn2.Text = "2";
            numBtn2.SetNumber(2);

            numBtn3.Text = "3";
            numBtn3.SetNumber(3);

            numBtn4.Text = "4";
            numBtn4.SetNumber(4);

            numBtn5.Text = "5";
            numBtn5.SetNumber(5);

            numBtn6.Text = "6";
            numBtn6.SetNumber(6);

            numBtn7.Text = "7";
            numBtn7.SetNumber(7);

            numBtn8.Text = "8";
            numBtn8.SetNumber(8);

            numBtn9.Text = "9";
            numBtn9.SetNumber(9);

            numBtn0.Text = "0";
            numBtn0.SetNumber(0);

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numBtn9_Click(object sender, EventArgs e)
        {
            expr += numBtn9.GetNumber().ToString();
            textBox1.Text = expr;
        }

        private void numBtn0_Click(object sender, EventArgs e)
        {
            expr += numBtn0.GetNumber().ToString();
            textBox1.Text = expr;
        }

        private void numBtn1_Click(object sender, EventArgs e)
        {
            expr += numBtn1.GetNumber().ToString();
            textBox1.Text = expr;
        }

        private void numBtn2_Click(object sender, EventArgs e)
        {
            expr += numBtn2.GetNumber().ToString();
            textBox1.Text = expr;
        }

        private void numBtn3_Click(object sender, EventArgs e)
        {
            expr += numBtn3.GetNumber().ToString();
            textBox1.Text = expr;
        }

        private void numBtn4_Click(object sender, EventArgs e)
        {
            expr += numBtn4.GetNumber().ToString();
            textBox1.Text = expr;
        }

        private void numBtn5_Click(object sender, EventArgs e)
        {
            expr += numBtn5.GetNumber().ToString();
            textBox1.Text = expr;
        }

        private void numBtn6_Click(object sender, EventArgs e)
        {
            expr += numBtn6.GetNumber().ToString();
            textBox1.Text = expr;
        }

        private void numBtn7_Click(object sender, EventArgs e)
        {
            expr += numBtn7.GetNumber().ToString();
            textBox1.Text = expr;
        }

        private void numBtn8_Click(object sender, EventArgs e)
        {
            expr += numBtn8.GetNumber().ToString();
            textBox1.Text = expr;
        }
    }
}
