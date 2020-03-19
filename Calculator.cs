using System;
using System.Windows.Forms;

namespace Calc_Kubis
{
    public partial class Calculator : Form
    {
        DataCollector data;
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

            // Initialize Memory Button
            msBtn = new MemorySaveBtn();
            mrBtn = new MemoryRmBtn();
        }

        private void CalcKubisForm_Load(object sender, EventArgs e)
        {
            // Initialize Data Collector
            data = new DataCollector();
            ChangeText();
        }

        private void ChangeText()
        {
            
            exprLabel.Text = data.GetExpr();
            if (data.GetStateAnswer())
            {
                ansLabel.Text = data.GetAnswer().ToString();
            } else
            {
                ansLabel.Text = "0";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(Btn7.GetNumber().ToString());
            ChangeText();
        }

        private void numBtn12_Click(object sender, EventArgs e)
        {
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(Btn8.GetNumber().ToString());
            ChangeText();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(Btn4.GetNumber().ToString());
            ChangeText();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mrBtn_Click(object sender, EventArgs e)
        {
            if (data.SavedValue.Count > 0)
            {
                data.AddStringExpression(mrBtn.DelMemory(ref data.SavedValue).ToString());
            }
            ChangeText();
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(PlusBtn.GetOperator());
            ChangeText();
        }

        private void operatorBtn1_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(MinusBtn.GetOperator());
            ChangeText();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(Btn0.GetNumber().ToString());
            ChangeText();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(Btn1.GetNumber().ToString());
            ChangeText();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(Btn2.GetNumber().ToString());
            ChangeText();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(Btn3.GetNumber().ToString());
            ChangeText();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(Btn5.GetNumber().ToString());
            ChangeText();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(Btn6.GetNumber().ToString());
            ChangeText();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(Btn9.GetNumber().ToString());
            ChangeText();
        }

        private void RootBtn_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(RootBtn.GetOperator());
            ChangeText();
        }

        private void PowerBtn_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(PowerBtn.GetOperator());
            ChangeText();
        }

        private void DivisorBtn_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(DivisorBtn.GetOperator());
            ChangeText();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(MultBtn.GetOperator());
            ChangeText();
        }

        private void DecBtn_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(DecBtn.GetOperator());
            ChangeText();
        }

        private void EvalBtn_Click(object sender, EventArgs e)
        {
            if (data.GetExpr().Equals(""))
            {
                MessageBox.Show("Expression Empty");
            }
            else
            {
                try
                {
                    if (data.GetStateAnswer())
                    {
                        data.SetExpr(Parser.ChangeVariable("ans", data.GetAnswer(), data.GetExpr()));
                    }
                    double holder = EvalBtn.GetResultEvaluation(data.GetExpr());
                    data.ChangeAnswer(holder);
                    ChangeText();
                    data.SetExpr(holder.ToString());
                    
                }
                catch (MathErrorException error)       // lix, ini nanti catch jadi 1 ato 2 sabeb
                            // kalo catch 2, nanti catch antara syntax error dengan math error, terus kasi title message box nya yang beda aja
                            // kalo mao bikin 1 juga gapapa, tapi nanti message box nya yang jelas ya ... ps: Format message boxnya kek yang dibawah (cari inet aja kalo ga paham :))
                {
                    data.SetExpr("0");
                    data.ChangeAnswer(0);
                    data.ChangeState();

                    MessageBox.Show(error.errorMessage(), "Arithmetic Error"); // first argument : the error message, the second argument : the error header message
                    ChangeText();
                }
                catch (SyntaxErrorException error)
                {
                    data.SetExpr("0");
                    data.ChangeAnswer(0);
                    data.ChangeState();

                    MessageBox.Show(error.errorMessage(), "Syntax Error"); // first argument : the error message, the second argument : the error header message
                    ChangeText();
                }
            }
        }

        private void LeftParenthesesBtn_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(LeftParenthesesBtn.GetOperator());
            ChangeText();
        }

        private void RightParenthesesBtn_Click(object sender, EventArgs e)
        {
            data.AddStringExpression(RightParenthesesBtn.GetOperator());
            ChangeText();
        }

        private void AnsBtn_Click(object sender, EventArgs e)
        {
            if (data.GetStateAnswer())
            {
                data.AddStringExpression("ans");
            }
            ChangeText();
        }

        private void ansBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            data = new DataCollector();
            ChangeText();
        }

        private void BackSpaceBtn_Click(object sender, EventArgs e)
        {
            data.BackSpaceExpression();
            ChangeText();
        }

        private void msBtn_Click(object sender, EventArgs e)
        {
            if (data.GetStateAnswer())
            {
                msBtn.AddItem(ref data.SavedValue, data.GetAnswer());
            }
        }
    }
}
