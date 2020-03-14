using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class Opr
    {
        protected int precedence;
        protected string symbol;

        public Opr(int p, string sym)
        {
            precedence = p;
            symbol = sym;
        }

        public int GetOprPred()
        {
            return precedence;
        }

        public string Show()
        {
            return symbol;
        }
    }
}
