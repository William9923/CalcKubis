using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    using System;
    using System.Collections.Generic;

    class Parser
    {
        string expr;
        string[] splittedExpr;
        public Parser(string expr)
        {
            this.expr = expr;
            this.splittedExpr = Preprocess().Split();
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

        public void Parse(ref List<Expression> numExpression, ref List<Opr> oprExpression)
        {
            try
            {
                numExpression = ExprDigitParser();
                oprExpression = ExprOprParser();
            }
            catch
            {
                throw new System.ArgumentException();
            }
        }

        public void ShowNumericParseResult()
        {
            List<Expression> numList = ExprDigitParser();
            Console.WriteLine("Number List:");
            foreach (Expression elem in numList)
            {
                Console.WriteLine(elem.solve());
            }
        }

        public void ShowOperatorParseResult()
        {
            List<Opr> oprList = ExprOprParser();
            Console.WriteLine("Operator List");
            foreach (Opr elem in oprList)
            {
                Console.WriteLine(elem.Show());
            }
        }


        private string Preprocess()
        {
            string PreprocessedString;
            string[] PreprocessedSplitter;

            PreprocessedString = this.expr.Trim();
            // Console.WriteLine("Step 1 :" + PreprocessedString);
            PreprocessedString = PreprocessedString.Replace("-  -", "+");
            // Console.WriteLine("Step 2 :" + PreprocessedString);
            PreprocessedString = PreprocessedString.Replace("-", "+  -");
            // Console.WriteLine("Step 3 :" + PreprocessedString);
            PreprocessedString = PreprocessedString.Replace(" - ", "-");
            // Console.WriteLine("Step 4 :" + PreprocessedString);
            PreprocessedSplitter = PreprocessedString.Split(' ');
            for (int i = 0; i < PreprocessedSplitter.Length; i++)
            {
                if (PreprocessedSplitter[i].StartsWith("√"))
                {
                    PreprocessedSplitter[i] = PreprocessedSplitter[i].Split('√')[1] + " ^ 0.5";
                }
            }
            PreprocessedString = string.Join(" ", PreprocessedSplitter);
            // Console.WriteLine("Step 5 :" + PreprocessedString);
            return PreprocessedString;
        }

        private static bool CheckOperator(string exe)
        {
            return (exe.Equals("x") || exe.Equals("+") || exe.Equals("÷") || exe.Equals("^"));
        }

        private List<Opr> ExprOprParser()
        {
            int count = 0;
            List<Opr> oprList = new List<Opr>();
            foreach (string elem in splittedExpr)
            {
                if (count % 2 == 1)
                {
                    if (CheckOperator(elem))
                    {
                        switch (elem)
                        {
                            case "+":
                                oprList.Add(new AddOpr());
                                break;
                            case "x":
                                oprList.Add(new MultOpr());
                                break;
                            case "÷":
                                oprList.Add(new DivOpr());
                                break;
                            case "^":
                                oprList.Add(new PowerOpr());
                                break;
                        }
                    }
                    else
                    {
                        throw new System.ArgumentException();
                    }
                }
                count++;
            }
            return oprList;
        }
        private List<Expression> ExprDigitParser()
        {
            int count = 0;
            Expression placeholder;
            double extractor;
            List<Expression> numList = new List<Expression>();
            foreach (string elem in splittedExpr)
            {
                if (count % 2 == 0)
                {
                    if (Double.TryParse(elem, out extractor))
                    {
                        placeholder = new TerminalExpression(extractor);
                        numList.Add(placeholder);
                    }
                    else
                    {
                        throw new System.ArgumentException();
                    }
                }
                count++;
            }
            return numList;
        }
    }
}
