using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class DivExpression : BinaryExpression
    {
        public DivExpression(Expression x, Expression y) : base(x, y) { }

        public override double solve()
        {
            return this.x.solve() / this.y.solve();
        }
    }
}
