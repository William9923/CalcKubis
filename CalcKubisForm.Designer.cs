namespace Calc_Kubis
{
    partial class CalcKubisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.PowerBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.DivisorBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.MultiplyButton = new Calc_Kubis.OperatorBtn(this.components);
            this.RootBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.PlusBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.MinusBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.msBtn = new Calc_Kubis.MemorySaveBtn(this.components);
            this.mrBtn = new Calc_Kubis.MemoryRmBtn(this.components);
            this.decBtn = new Calc_Kubis.NumBtn(this.components);
            this.Btn0 = new Calc_Kubis.NumBtn(this.components);
            this.ansBtn = new Calc_Kubis.NumBtn(this.components);
            this.Btn3 = new Calc_Kubis.NumBtn(this.components);
            this.Btn5 = new Calc_Kubis.NumBtn(this.components);
            this.Btn6 = new Calc_Kubis.NumBtn(this.components);
            this.Btn1 = new Calc_Kubis.NumBtn(this.components);
            this.Btn2 = new Calc_Kubis.NumBtn(this.components);
            this.Btn9 = new Calc_Kubis.NumBtn(this.components);
            this.Btn4 = new Calc_Kubis.NumBtn(this.components);
            this.Btn8 = new Calc_Kubis.NumBtn(this.components);
            this.Btn7 = new Calc_Kubis.NumBtn(this.components);
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.Location = new System.Drawing.Point(9, 38);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultBox.Size = new System.Drawing.Size(414, 61);
            this.ResultBox.TabIndex = 12;
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ResultBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // PowerBtn
            // 
            this.PowerBtn.Location = new System.Drawing.Point(342, 202);
            this.PowerBtn.Name = "PowerBtn";
            this.PowerBtn.Size = new System.Drawing.Size(81, 88);
            this.PowerBtn.TabIndex = 20;
            this.PowerBtn.Text = "^";
            this.PowerBtn.UseVisualStyleBackColor = true;
            this.PowerBtn.Click += new System.EventHandler(this.PowerBtn_Click);
            // 
            // DivisorBtn
            // 
            this.DivisorBtn.Location = new System.Drawing.Point(341, 296);
            this.DivisorBtn.Name = "DivisorBtn";
            this.DivisorBtn.Size = new System.Drawing.Size(81, 88);
            this.DivisorBtn.TabIndex = 19;
            this.DivisorBtn.Text = "÷";
            this.DivisorBtn.UseVisualStyleBackColor = true;
            this.DivisorBtn.Click += new System.EventHandler(this.DivisorBtn_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(341, 389);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(81, 88);
            this.MultiplyButton.TabIndex = 18;
            this.MultiplyButton.Text = "X";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            // 
            // RootBtn
            // 
            this.RootBtn.Location = new System.Drawing.Point(254, 201);
            this.RootBtn.Name = "RootBtn";
            this.RootBtn.Size = new System.Drawing.Size(81, 88);
            this.RootBtn.TabIndex = 17;
            this.RootBtn.Text = "√";
            this.RootBtn.UseVisualStyleBackColor = true;
            this.RootBtn.Click += new System.EventHandler(this.RootBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Location = new System.Drawing.Point(254, 388);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(81, 181);
            this.PlusBtn.TabIndex = 16;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Location = new System.Drawing.Point(254, 295);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(81, 87);
            this.MinusBtn.TabIndex = 15;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.operatorBtn1_Click);
            // 
            // msBtn
            // 
            this.msBtn.Location = new System.Drawing.Point(90, 108);
            this.msBtn.Name = "msBtn";
            this.msBtn.Size = new System.Drawing.Size(78, 87);
            this.msBtn.TabIndex = 14;
            this.msBtn.Text = "MC";
            this.msBtn.UseVisualStyleBackColor = true;
            // 
            // mrBtn
            // 
            this.mrBtn.Location = new System.Drawing.Point(10, 107);
            this.mrBtn.Name = "mrBtn";
            this.mrBtn.Size = new System.Drawing.Size(78, 88);
            this.mrBtn.TabIndex = 13;
            this.mrBtn.Text = "MR";
            this.mrBtn.UseVisualStyleBackColor = true;
            this.mrBtn.Click += new System.EventHandler(this.mrBtn_Click);
            // 
            // decBtn
            // 
            this.decBtn.Location = new System.Drawing.Point(10, 483);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(80, 88);
            this.decBtn.TabIndex = 11;
            this.decBtn.Text = ".";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.numBtn12_Click);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(91, 483);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(80, 88);
            this.Btn0.TabIndex = 0;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // ansBtn
            // 
            this.ansBtn.Location = new System.Drawing.Point(171, 483);
            this.ansBtn.Name = "ansBtn";
            this.ansBtn.Size = new System.Drawing.Size(80, 88);
            this.ansBtn.TabIndex = 10;
            this.ansBtn.Text = "Ans";
            this.ansBtn.UseVisualStyleBackColor = true;
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(170, 389);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(80, 88);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(91, 295);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(80, 88);
            this.Btn5.TabIndex = 5;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(171, 295);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(80, 88);
            this.Btn6.TabIndex = 6;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(10, 389);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(80, 88);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(91, 389);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(80, 88);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(170, 201);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(80, 88);
            this.Btn9.TabIndex = 9;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(10, 295);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(80, 88);
            this.Btn4.TabIndex = 4;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(90, 201);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(80, 88);
            this.Btn8.TabIndex = 8;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(10, 201);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(80, 88);
            this.Btn7.TabIndex = 7;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // CalcKubisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 577);
            this.Controls.Add(this.PowerBtn);
            this.Controls.Add(this.DivisorBtn);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.RootBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.msBtn);
            this.Controls.Add(this.mrBtn);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.ansBtn);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CalcKubisForm";
            this.Text = " Calculator Kubis";
            this.Load += new System.EventHandler(this.CalcKubisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumBtn Btn7;
        private NumBtn Btn8;
        private NumBtn Btn4;
        private NumBtn Btn9;
        private NumBtn Btn2;
        private NumBtn Btn1;
        private NumBtn Btn6;
        private NumBtn Btn5;
        private NumBtn Btn3;
        private NumBtn ansBtn;
        private NumBtn Btn0;
        private NumBtn decBtn;
        private System.Windows.Forms.TextBox ResultBox;
        private MemoryRmBtn mrBtn;
        private MemorySaveBtn msBtn;
        private OperatorBtn MinusBtn;
        private OperatorBtn PlusBtn;
        private OperatorBtn RootBtn;
        private OperatorBtn MultiplyButton;
        private OperatorBtn DivisorBtn;
        private OperatorBtn PowerBtn;
    }
}

