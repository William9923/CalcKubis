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
    public partial class MemorySaveBtn : Button
    {
        private const string NAME = "MC";

        public MemorySaveBtn()
        {
            InitializeComponent();
        }

        public MemorySaveBtn(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void AddItem (ref Queue<double> queue, double item)
        {
            queue.Enqueue(item);
        }


    }
}
