﻿using System;
using System.Windows.Forms;

namespace Calc_Kubis
{
    public partial class Calculator : Form
    {

        string expr;

        public Calculator()
        {
            InitializeComponent();
            // Initialize Number Button
            Btn0 = new NumBtn(0);
            Btn1 = new NumBtn(1);
            Btn2 = new NumBtn(2);
            Btn3 = new NumBtn(3);
            Btn4 = new NumBtn(4);
            Btn5 = new NumBtn(5);
            Btn6 = new NumBtn(6);
            Btn7 = new NumBtn(7);
            Btn8 = new NumBtn(8);
            Btn9 = new NumBtn(9);

            // Initialize Operator Button
            PlusBtn = new OperatorBtn("+");
            MinusBtn = new OperatorBtn("-");
            RootBtn = new OperatorBtn("√");
            DivisorBtn = new OperatorBtn("÷");
            MultBtn = new OperatorBtn("x");
            PowerBtn = new OperatorBtn("^");
            DecBtn = new OperatorBtn(".");
            LeftParenthesesBtn = new OperatorBtn("(");
            RightParenthesesBtn = new OperatorBtn(")");

            // Initialize Evaluator Button
            EvalBtn = new EvaluatorBtn();
        }

        private void CalcKubisForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ChangeText()
        {
            ResultBox.Text = expr.Replace(" ","");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            expr += Btn7.GetNumber();
            ChangeText();
        }

        private void numBtn12_Click(object sender, EventArgs e)
        {
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            expr += Btn8.GetNumber();
            ChangeText();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            expr += Btn4.GetNumber();
            ChangeText();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mrBtn_Click(object sender, EventArgs e)
        {

        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            expr += " " + PlusBtn.GetOperator() + " ";
            ChangeText();
        }

        private void operatorBtn1_Click(object sender, EventArgs e)
        {
            expr += " " + MinusBtn.GetOperator() + " ";
            ChangeText();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            expr += Btn0.GetNumber();
            ChangeText();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            expr += Btn1.GetNumber();
            ChangeText();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            expr += Btn2.GetNumber();
            ChangeText();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            expr += Btn3.GetNumber();
            ChangeText();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            expr += Btn5.GetNumber();
            ChangeText();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            expr += Btn6.GetNumber();
            ChangeText();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            expr += Btn9.GetNumber();
            ChangeText();
        }

        private void RootBtn_Click(object sender, EventArgs e)
        {
            expr += RootBtn.GetOperator() + " ";
            ChangeText();
        }

        private void PowerBtn_Click(object sender, EventArgs e)
        {
            expr += " " + PowerBtn.GetOperator() + " ";
            ChangeText();
        }

        private void DivisorBtn_Click(object sender, EventArgs e)
        {
            expr += " " + DivisorBtn.GetOperator() + " ";
            ChangeText();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            expr += " " + MultBtn.GetOperator() + " ";
            ChangeText();
        }

        private void DecBtn_Click(object sender, EventArgs e)
        {
            expr += DecBtn.GetOperator();
            ChangeText();
        }

        private void EvalBtn_Click(object sender, EventArgs e)
        {
            if (expr.Equals(""))
            {
                MessageBox.Show("Expression Empty");
            }
            else
            {
                expr = EvalBtn.GetResultEvaluation(this.expr).ToString();
                ChangeText();
            }
        }

        private void LeftParenthesesBtn_Click(object sender, EventArgs e)
        {
            expr +=  LeftParenthesesBtn.GetOperator() +  " " ;
            ChangeText();
        }

        private void RightParenthesesBtn_Click(object sender, EventArgs e)
        {
            expr +=  " " + RightParenthesesBtn.GetOperator();
            ChangeText();
        }

        private void ansBtn_Click(object sender, EventArgs e)
        {
            expr += "";
            ChangeText();
        }
    }
}