using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Kubis
{

    public partial class OperatorBtn : Button
    {

        protected string op;

        public OperatorBtn()
        {
            InitializeComponent();
        }

        public OperatorBtn(string op)
        {
            this.op = op;
        }

        public OperatorBtn(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public string GetOperator()
        {
            return this.op;
        }

        public void SetOperator(string op)
        {
            this.op = op;
        }
    }
}
