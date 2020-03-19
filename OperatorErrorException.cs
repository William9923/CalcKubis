using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class OperatorErrorException : SyntaxErrorException
    {
        public override string errorMessage()
        {
            return ("Expected operand\n");
        }
    }
}
