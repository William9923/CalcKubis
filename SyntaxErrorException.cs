using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class SyntaxErrorException : BaseException
    {
        public SyntaxErrorException() { }

        public override string errorMessage()
        {
            return ("Syntax Error\n");
        }
    }
}
