using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Kubis
{
    public partial class NumBtn : System.Windows.Forms.Button
    {
        // instance variable
        private int number;
        // constructor
        public NumBtn()
        {
            InitializeComponent();
        }

        public NumBtn(int number)
        {
            InitializeComponent();
            this.number = number;
        }

        public NumBtn(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void InitializeDesign()
        {
            this.Text = number.ToString();
        }

        // getter
        public int GetNumber()
        {
            return this.number;
        }
        // setter
        public void SetNumber(int num)
        {
            this.number = num;
        }
    }
}
