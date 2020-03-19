using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class DataCollector
    {
        public Queue<double> SavedValue;
        private double Answer;
        private string Expr;
        private bool StartState;
        private bool HasSavedAnswer;
        private bool expectFirstInput;

        // default value
        public DataCollector()
        {
            SavedValue = new Queue<double>();
            HasSavedAnswer = false;
            StartState = true;
            Answer = 0;
            Expr = "0";
            expectFirstInput = true; 
        }

        // methods
        public void AddStringExpression(string s)
        {
            if (Expr.Length < 19)
            {
                if (StartState)
                {
                    if (Parser.CheckOperand(s) || Parser.CheckUnaryOperator(s))
                    {
                        this.Expr = "";
                    }
                    ChangeState();
                }
                this.Expr += s;
                expectFirstInput = false;
            }
        }

        public bool getExpectation()
        {
            return expectFirstInput;
        }

        public void BackSpaceExpression()
        {
            if (Expr.Length > 0)
            {
                if (Expr[Expr.Length - 1].Equals("s"))
                {
                    Expr = Expr.Substring(0, Expr.Length - 3);
                } 
                else
                {
                    Expr = Expr.Substring(0, Expr.Length - 1);
                }
            }
            // else do nothing
        }

        public string GetExpr()
        {
            return this.Expr;
        }

        public void SetExpr(string expr)
        {
            Expr = expr;
        }

        public bool GetState()
        {
            return StartState;
        }
        public void ChangeState()
        {
            StartState = !StartState;
        }

        public bool CheckStartState()
        {
            return this.StartState;
        }

        public void ChangeAnswer(double ans)
        {
            this.Answer = ans;
            HasSavedAnswer = true;
            expectFirstInput = true;
        }

        public bool GetStateAnswer()
        {
            return HasSavedAnswer;
        }

        public double GetAnswer()
        {
            if (HasSavedAnswer)
            {
                return Answer;
            } else
            {
                throw new System.ArgumentException();
            }
            
        }
    }
}
