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

        public override double Solve()
        {

            if (this.y.Solve() == 0.0)          // gantiin exception ini lix
            {
                throw new DivideByZeroException(this.x.Solve());
            }
            return this.x.Solve() / this.y.Solve();
        }
    }
}
