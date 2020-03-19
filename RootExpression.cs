using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class RootExpression : UnaryExpression
    {
        public RootExpression(Expression x) : base(x) { }

        public override double Solve()
        {
            if (this.x.Solve() < 0)     //Imaginary Expression
            {
                throw new ImaginaryException();
            }
            return Math.Pow(this.x.Solve(), 0.5);
        }
    }
}
