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
            if (this.x.Solve() < 0)     // lix, ini throw yang Math Error , Imaginary something itu ya
            {
                throw new System.ArgumentException();
            }
            return Math.Pow(this.x.Solve(), 0.5);
        }
    }
}
