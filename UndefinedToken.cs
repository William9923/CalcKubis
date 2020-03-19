using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    class UndefinedToken : SyntaxErrorException
    {
        protected string token;

        public UndefinedToken(string token)
        {
            this.token = token;
        }

        public override string errorMessage()
        {
            return ($"{this.token} is undefined.");
        }
    }
}
