using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class ParenthesesErrorException : SyntaxErrorException
    {
        public override string errorMessage()
        {
            return ("Parentheses Error\n");
        }
    }
}
