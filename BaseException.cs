using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    abstract class BaseException : Exception
    {
        abstract public string errorMessage();
    }
}
