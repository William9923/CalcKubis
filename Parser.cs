using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class Parser
    {

        string expr;
        string[] splittedExpr;

        public Parser(string expr)
        {
            this.expr = expr;
            this.splittedExpr = Preprocess().Split();
            PrintParseResult();
        }

        public static string ChangeVariable(string var, double digit, string expr)
        {
            return expr.Replace(var, digit.ToString());
        }

        private void CreateUnaryNeg()
        {
            ArrayList al = new ArrayList();
            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '-')
                {
                    al.Add(i);
                }
            }
            foreach (int elem in al)
            {
                if (elem == 0)
                {
                    expr = expr.Remove(elem, 1).Insert(elem, ";");
                }
                else
                {
                    if (elem != expr.Length - 1)
                    {
                        if ((CheckBinaryOperator(expr[elem - 1].ToString()) || expr[elem - 1] == '(') && (expr[elem + 1] == '√' || CheckOperand(expr[elem + 1].ToString())))
                        {
                            expr = expr.Remove(elem, 1).Insert(elem, ";");
                        }
                    }
                }
            }
        }

        private void AddSpacer()
        {
            expr = expr.Replace("x", " x ");
            expr = expr.Replace(";", "; ");
            expr = expr.Replace("-", " - ");
            expr = expr.Replace("+", " + ");
            expr = expr.Replace("÷", " ÷ ");
            expr = expr.Replace("^", " ^ ");
            expr = expr.Replace("√", "√ ");
            expr = expr.Replace(")", " )");
            expr = expr.Replace("(", "( ");
        }

        public string GetExpr()
        {
            return this.expr;
        }

        public string GetParsedExpr()
        {
            return string.Join(" ", splittedExpr);
        }

        public void SetExpr(string newExpr)
        {
            this.expr = newExpr;
        }

        public string[] GetParseResult()
        {
            return this.splittedExpr;
        }

        // Printing Parse Result
        public void PrintParseResult()
        {
            Console.Write("{");
            int count = splittedExpr.Length;
            foreach (string elem in splittedExpr)
            {
                Console.Write(elem);
                if (--count > 0)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("}");
        }

        // Internal Preprocessing Expression Process
        private string Preprocess()
        {
            CreateUnaryNeg();
            AddSpacer();

            string PreprocessedString;
            string[] PreprocessedSplitter;

            PreprocessedString = this.expr.Trim();
            PreprocessedString = PreprocessedString.Replace("-  -", "+");
            PreprocessedSplitter = PreprocessedString.Split(' ');
            PreprocessedString = string.Join(" ", PreprocessedSplitter);
            return PreprocessedString;
        }

        // Static Method for parser
        public static bool CheckOperator(string exe)
        {
            return (exe.Equals("(") || exe.Equals(")") || exe.Equals("x") || exe.Equals("+") || exe.Equals("÷") || exe.Equals("^") || exe.Equals("√") || exe.Equals(";") || exe.Equals("-"));
        }

        public static bool CheckParentheses(string exe)
        {
            return (exe.Equals("(") || exe.Equals(")"));
        }

        public static bool CheckUnaryOperator(string exe)
        {
            return (exe.Equals(";") || exe.Equals("√"));
        }

        public static bool CheckBinaryOperator(string exe)
        {
            return (exe.Equals("+") || exe.Equals("÷") || exe.Equals("^") || exe.Equals("x") || exe.Equals("-"));
        }

        public static bool CheckOperand(string exe)
        {

            return double.TryParse(exe, out _);
        }
    }
}
