using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    abstract class BinaryExpression : Expression
    {
        protected Expression x;
        protected Expression y;

        public BinaryExpression(Expression x, Expression y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
