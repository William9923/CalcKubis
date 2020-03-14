using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    using System;
    using System.Collections.Generic;
    class Evaluator
    {
        protected Parser parser;

        public Evaluator(string expr)
        {
            this.parser = new Parser(expr);
            Console.WriteLine(this.parser.GetParsedExpr());
        }

        // encapsulate
        public Expression Evaluate()
        {
            Queue<Expression> numQueue = InitNumQueue();
            Queue<Opr> oprQueue = InitOprQueue();
            Stack<Expression> numStack = new Stack<Expression>();
            Stack<Opr> oprStack = new Stack<Opr>();
            Expression exprHolder = numQueue.Dequeue();
            Opr oprHolder = new AddOpr();
            bool change = true;
            bool leftOut = false;

            numStack.Push(exprHolder);
            while (oprQueue.Count != 0 || leftOut)
            {
                // PrintNumQueue(numQueue);
                // PrintOprQueue(oprQueue);
                if (change)
                {
                    oprHolder = oprQueue.Dequeue();
                    exprHolder = numQueue.Dequeue();
                    leftOut = true;
                    // PrintEvaluatorState(oprHolder, exprHolder, "Dequeue");
                }

                if (oprStack.Count != 0 && oprHolder.GetOprPred() < oprStack.Peek().GetOprPred())
                {
                    change = false;
                    Opr operate = oprStack.Pop();
                    Expression e2 = numStack.Pop(); Expression e1 = numStack.Pop();
                    // PrintEvaluationState(operate, e1, e2);
                    switch (operate.Show())
                    {
                        case "x": numStack.Push(new MultExpression(e1, e2)); break;
                        case "+": numStack.Push(new AddExpression(e1, e2)); break;
                        case "^": numStack.Push(new PowerExpression(e1, e2)); break;
                        case "÷": numStack.Push(new DivExpression(e1, e2)); break;
                    }
                }
                else
                {
                    // PrintEvaluatorState(oprHolder, exprHolder, "Pushing");
                    change = true; leftOut = false;
                    oprStack.Push(oprHolder);
                    numStack.Push(exprHolder);
                }
            }

            while (oprStack.Count != 0)
            {
                oprHolder = oprStack.Pop();
                Expression e2 = numStack.Pop(); Expression e1 = numStack.Pop();
                // PrintEvaluationState(oprHolder, e1, e2);
                switch (oprHolder.Show())
                {
                    case "x": numStack.Push(new MultExpression(e1, e2)); break;
                    case "+": numStack.Push(new AddExpression(e1, e2)); break;
                    case "^": numStack.Push(new PowerExpression(e1, e2)); break;
                    case "÷": numStack.Push(new DivExpression(e1, e2)); break;
                }
            }
            return numStack.Pop();
        }

        // Initialize Function
        private Queue<Expression> InitNumQueue()
        {
            List<Expression> numList = new List<Expression>();
            List<Opr> oprList = new List<Opr>();
            parser.Parse(ref numList, ref oprList);
            return new Queue<Expression>(numList);
        }

        private Queue<Opr> InitOprQueue()
        {
            List<Opr> oprList = new List<Opr>();
            List<Expression> numList = new List<Expression>();
            parser.Parse(ref numList, ref oprList);
            return new Queue<Opr>(oprList);
        }

        // debugging function
        private static void PrintNumQueue(Queue<Expression> q)
        {
            Console.Write("Numeric : [");
            List<Expression> list = new List<Expression>(q);
            foreach (Expression e in list)
            {
                Console.Write(e.solve());
                Console.Write(",");
            }
            Console.WriteLine("]");
        }

        // debugging function
        private static void PrintOprQueue(Queue<Opr> q)
        {
            Console.Write("Operator : [");
            List<Opr> list = new List<Opr>(q);
            foreach (Opr e in list)
            {
                Console.Write(e.Show());
                Console.Write(",");
            }
            Console.WriteLine("]");
        }

        // debugging function
        private static void PrintEvaluatorState(Opr opr, Expression expr, string state)
        {
            Console.WriteLine(state + ":");
            Console.WriteLine("Operator:" + opr.Show());
            Console.WriteLine("Number:" + expr.solve());
        }

        // debugging function
        private static void PrintEvaluationState(Opr opr, Expression expr1, Expression expr2)
        {
            Console.WriteLine("Operation:");
            Console.WriteLine(expr1.solve() + opr.Show() + expr2.solve());
        }
    }
}
