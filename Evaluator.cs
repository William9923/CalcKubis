using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class Evaluator
    {
        protected Parser parser;
        protected bool expectOperand;

        public Evaluator(string expr)
        {
            this.parser = new Parser(expr);
            this.expectOperand = true;
        }

        public Expression Evaluate()
        {
            string[] tokenList = parser.GetParseResult();
            Stack<Expression> exprStack = new Stack<Expression>();
            Stack<Opr> oprStack = new Stack<Opr>();
            double numHolder;
            Opr oprHolder;

            foreach (string token in tokenList)
            {
                if (Parser.CheckOperand(token))
                {
                    CheckStateOperand();
                    numHolder = Double.Parse(token);
                    exprStack.Push(new TerminalExpression(numHolder));
                    ChangeState();

                }
                else if (Parser.CheckUnaryOperator(token))
                {
                    CheckStateOperand();
                    oprStack.Push(CreateOpr(token));
                }
                else if (Parser.CheckBinaryOperator(token))
                {
                    CheckStateOperator();
                    oprHolder = CreateOpr(token);
                    while (oprStack.Count != 0 && oprHolder.GetOprPred() <= oprStack.Peek().GetOprPred())
                    {
                        Opr outOpr = oprStack.Pop();
                        CreateExpr(outOpr, ref exprStack);
                    }
                    oprStack.Push(oprHolder);
                    ChangeState();
                }
                else if (Parser.CheckParentheses(token))
                {
                    switch (token)
                    {
                        case "(":
                            CheckStateOperand();
                            oprStack.Push(CreateOpr(token));
                            break;
                        case ")":
                            CheckStateOperator();
                            while (oprStack.Count != 0 && oprStack.Peek().Show() != "(")
                            {
                                oprHolder = oprStack.Pop();
                                CreateExpr(oprHolder, ref exprStack);
                            }
                            if (oprStack.Count == 0)
                            {
                                throw new ParenthesesErrorException();
                            }
                            if (oprStack.Peek().Show() == "(")
                            {
                                oprStack.Pop();
                            }
                            
                            break;
                    }
                }
                else        //Token tidak terdefinisi
                {
                    Console.WriteLine(token);
                     throw new UndefinedToken(token);
                }
            }
            CheckStateOperator();
            // Finishing Evaluation Process
            while (oprStack.Count != 0 && exprStack.Count != 0)   
            {
                oprHolder = oprStack.Pop();
                CreateExpr(oprHolder, ref exprStack);
            }

            if (oprStack.Count > 0 || exprStack.Count > 1)  // Syntax error
            {
                throw new SyntaxErrorException();
            }
            return exprStack.Pop();
        }

        private static Opr CreateOpr(string exe)
        {
            switch (exe)
            {
                case "+": return new AddOpr(); break;
                case "-": return new NegativeOpr(); break;
                case "x": return new MultOpr(); break;
                case "÷": return new DivOpr(); break;
                case "^": return new PowerOpr(); break;
                case "√": return new RootOpr(); break;
                case "(": return new ParenthesesOpr("("); break;
                case ")": return new ParenthesesOpr(")"); break;
                default: throw new UndefinedToken(exe);          //Undefined Token
            }
        }

        // Middle-ware function
        private static void CreateExpr(Opr operation, ref Stack<Expression> exprStack)
        {
            Expression ex2 = exprStack.Pop();
            Expression ex1;
            switch (operation.Show())
            {
                case "x":
                    ex1 = exprStack.Pop();
                    exprStack.Push(new MultExpression(ex1, ex2)); break;
                case "+":
                    ex1 = exprStack.Pop();
                    exprStack.Push(new AddExpression(ex1, ex2)); break;
                case "^":
                    ex1 = exprStack.Pop();
                    exprStack.Push(new PowerExpression(ex1, ex2)); break;
                case "÷":
                    ex1 = exprStack.Pop();
                    exprStack.Push(new DivExpression(ex1, ex2)); break;
                case "-":
                    exprStack.Push(new NegativeExpression(ex2)); break;
                case "√":
                    exprStack.Push(new RootExpression(ex2)); break;
                default:                            //Syntax error
                    throw new SyntaxErrorException();
            }
        }

        private void CheckStateOperand()
        {
            if (!this.expectOperand)        //Syntax error
            {
                throw new SyntaxErrorException();
            }
        }

        private void CheckStateOperator()
        {
            if (this.expectOperand)         //Expected operand
            {
                throw new OperatorErrorException();
            }
        }

        private void ChangeState()
        {
            this.expectOperand = !expectOperand;
        }

        // Debugging function
        private static void PrintOperatorState(Opr opr, string state)
        {
            Console.WriteLine(state + ":");
            Console.WriteLine("Operator:" + opr.Show());
        }

        private static void PrintExpressionState(Expression expr, string state)
        {
            Console.WriteLine(state + ":");
            Console.WriteLine("Expression:" + expr.Solve());
        }

        private static void PrintEvaluationState(Opr opr, Expression expr1, Expression expr2)
        {
            Console.Write("Operation State: ");
            Console.WriteLine(expr1.Solve() + opr.Show() + expr2.Solve());
        }
    }
}
