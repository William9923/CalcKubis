using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class TerminalExpression : Expression
    {
        protected double x;

        public TerminalExpression(int x)
        {
            this.x = Convert.ToDouble(x);
        }

        public TerminalExpression(double x)
        {
            this.x = x;
        }

        public override double Solve()
        {
            return x;
        }
    }
}
