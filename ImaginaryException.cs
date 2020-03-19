using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class ImaginaryException : MathErrorException
    {
        public ImaginaryException() { }
        public override string errorMessage()
        {
            return ("Imaginary Expression\n");
        }
    }

}
