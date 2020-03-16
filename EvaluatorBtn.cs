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
    public partial class EvaluatorBtn : Button
    {
        public EvaluatorBtn()
        {
            InitializeComponent();
            Text = "=";
        }

        public double GetResultEvaluation(string expr)
        {
            Evaluator eval = new Evaluator(expr);
            Expression result = eval.Evaluate();
            return result.Solve();
        }

        public EvaluatorBtn(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
