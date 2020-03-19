using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class MathErrorException : BaseException
    {

        public MathErrorException() { }

        public override string errorMessage()
        {
            return ("Math Error\n");
        }
    }
}
