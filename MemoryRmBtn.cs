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
    public partial class MemoryRmBtn : Button
    {
        private const string NAME = "MR";

        public MemoryRmBtn()
        {
            InitializeComponent();
            Text = NAME;
        }

        public MemoryRmBtn(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public double DelMemory(ref Queue<double> queue)
        {
            if (queue.Count() == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return queue.Dequeue();
        }

    }
}
