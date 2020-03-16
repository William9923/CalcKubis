using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class NegativeExpression : UnaryExpression
    {
        public NegativeExpression(Expression x) : base(x) { }

        public override double Solve()
        {
            return this.x.Solve() * -1;
        }
    }
}
