namespace Calc_Kubis
{
    partial class Calculator
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
            this.exprLabel = new System.Windows.Forms.Label();
            this.BackSpaceBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RightParenthesesBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.LeftParenthesesBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.EvalBtn = new Calc_Kubis.EvaluatorBtn(this.components);
            this.DecBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.PowerBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.DivisorBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.MultBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.RootBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.PlusBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.MinusBtn = new Calc_Kubis.OperatorBtn(this.components);
            this.msBtn = new Calc_Kubis.MemorySaveBtn(this.components);
            this.mrBtn = new Calc_Kubis.MemoryRmBtn(this.components);
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
            this.ansLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exprLabel
            // 
            this.exprLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exprLabel.Location = new System.Drawing.Point(9, 9);
            this.exprLabel.Name = "exprLabel";
            this.exprLabel.Size = new System.Drawing.Size(450, 66);
            this.exprLabel.TabIndex = 25;
            this.exprLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BackSpaceBtn
            // 
            this.BackSpaceBtn.BackColor = System.Drawing.Color.Indigo;
            this.BackSpaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackSpaceBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.BackSpaceBtn.Location = new System.Drawing.Point(279, 198);
            this.BackSpaceBtn.Name = "BackSpaceBtn";
            this.BackSpaceBtn.Size = new System.Drawing.Size(90, 90);
            this.BackSpaceBtn.TabIndex = 26;
            this.BackSpaceBtn.Text = "CE";
            this.BackSpaceBtn.UseVisualStyleBackColor = false;
            this.BackSpaceBtn.Click += new System.EventHandler(this.BackSpaceBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearBtn.Location = new System.Drawing.Point(369, 198);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(90, 90);
            this.ClearBtn.TabIndex = 27;
            this.ClearBtn.Text = "C";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // RightParenthesesBtn
            // 
            this.RightParenthesesBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RightParenthesesBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.RightParenthesesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightParenthesesBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RightParenthesesBtn.Location = new System.Drawing.Point(93, 198);
            this.RightParenthesesBtn.Name = "RightParenthesesBtn";
            this.RightParenthesesBtn.Size = new System.Drawing.Size(90, 90);
            this.RightParenthesesBtn.TabIndex = 24;
            this.RightParenthesesBtn.Text = ")";
            this.RightParenthesesBtn.UseVisualStyleBackColor = false;
            this.RightParenthesesBtn.Click += new System.EventHandler(this.RightParenthesesBtn_Click);
            // 
            // LeftParenthesesBtn
            // 
            this.LeftParenthesesBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LeftParenthesesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftParenthesesBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LeftParenthesesBtn.Location = new System.Drawing.Point(3, 198);
            this.LeftParenthesesBtn.Name = "LeftParenthesesBtn";
            this.LeftParenthesesBtn.Size = new System.Drawing.Size(90, 90);
            this.LeftParenthesesBtn.TabIndex = 23;
            this.LeftParenthesesBtn.Text = "(";
            this.LeftParenthesesBtn.UseVisualStyleBackColor = false;
            this.LeftParenthesesBtn.Click += new System.EventHandler(this.LeftParenthesesBtn_Click);
            // 
            // EvalBtn
            // 
            this.EvalBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.EvalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvalBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EvalBtn.Location = new System.Drawing.Point(369, 554);
            this.EvalBtn.Name = "EvalBtn";
            this.EvalBtn.Size = new System.Drawing.Size(90, 90);
            this.EvalBtn.TabIndex = 22;
            this.EvalBtn.Text = "=";
            this.EvalBtn.UseVisualStyleBackColor = false;
            this.EvalBtn.Click += new System.EventHandler(this.EvalBtn_Click);
            // 
            // DecBtn
            // 
            this.DecBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DecBtn.Location = new System.Drawing.Point(3, 554);
            this.DecBtn.Name = "DecBtn";
            this.DecBtn.Size = new System.Drawing.Size(90, 90);
            this.DecBtn.TabIndex = 21;
            this.DecBtn.Text = ",";
            this.DecBtn.UseVisualStyleBackColor = false;
            this.DecBtn.Click += new System.EventHandler(this.DecBtn_Click);
            // 
            // PowerBtn
            // 
            this.PowerBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PowerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PowerBtn.Location = new System.Drawing.Point(279, 465);
            this.PowerBtn.Name = "PowerBtn";
            this.PowerBtn.Size = new System.Drawing.Size(90, 90);
            this.PowerBtn.TabIndex = 20;
            this.PowerBtn.Text = "^";
            this.PowerBtn.UseVisualStyleBackColor = false;
            this.PowerBtn.Click += new System.EventHandler(this.PowerBtn_Click);
            // 
            // DivisorBtn
            // 
            this.DivisorBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DivisorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisorBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DivisorBtn.Location = new System.Drawing.Point(279, 376);
            this.DivisorBtn.Name = "DivisorBtn";
            this.DivisorBtn.Size = new System.Drawing.Size(90, 90);
            this.DivisorBtn.TabIndex = 19;
            this.DivisorBtn.Text = "÷";
            this.DivisorBtn.UseVisualStyleBackColor = false;
            this.DivisorBtn.Click += new System.EventHandler(this.DivisorBtn_Click);
            // 
            // MultBtn
            // 
            this.MultBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MultBtn.Location = new System.Drawing.Point(369, 465);
            this.MultBtn.Name = "MultBtn";
            this.MultBtn.Size = new System.Drawing.Size(90, 90);
            this.MultBtn.TabIndex = 18;
            this.MultBtn.Text = "x";
            this.MultBtn.UseVisualStyleBackColor = false;
            this.MultBtn.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // RootBtn
            // 
            this.RootBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RootBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RootBtn.Location = new System.Drawing.Point(183, 198);
            this.RootBtn.Name = "RootBtn";
            this.RootBtn.Size = new System.Drawing.Size(90, 90);
            this.RootBtn.TabIndex = 17;
            this.RootBtn.Text = "√";
            this.RootBtn.UseVisualStyleBackColor = false;
            this.RootBtn.Click += new System.EventHandler(this.RootBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PlusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlusBtn.Location = new System.Drawing.Point(279, 554);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(90, 90);
            this.PlusBtn.TabIndex = 16;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = false;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusBtn.ForeColor = System.Drawing.Color.Azure;
            this.MinusBtn.Location = new System.Drawing.Point(279, 287);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(90, 90);
            this.MinusBtn.TabIndex = 15;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = false;
            this.MinusBtn.Click += new System.EventHandler(this.operatorBtn1_Click);
            // 
            // msBtn
            // 
            this.msBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.msBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msBtn.Location = new System.Drawing.Point(369, 287);
            this.msBtn.Name = "msBtn";
            this.msBtn.Size = new System.Drawing.Size(90, 90);
            this.msBtn.TabIndex = 14;
            this.msBtn.Text = "MS";
            this.msBtn.UseVisualStyleBackColor = false;
            this.msBtn.Click += new System.EventHandler(this.msBtn_Click);
            // 
            // mrBtn
            // 
            this.mrBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.mrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrBtn.Location = new System.Drawing.Point(369, 376);
            this.mrBtn.Name = "mrBtn";
            this.mrBtn.Size = new System.Drawing.Size(90, 90);
            this.mrBtn.TabIndex = 13;
            this.mrBtn.Text = "MR";
            this.mrBtn.UseVisualStyleBackColor = false;
            this.mrBtn.Click += new System.EventHandler(this.mrBtn_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn0.Location = new System.Drawing.Point(93, 554);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(90, 90);
            this.Btn0.TabIndex = 0;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // ansBtn
            // 
            this.ansBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ansBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansBtn.Location = new System.Drawing.Point(183, 554);
            this.ansBtn.Name = "ansBtn";
            this.ansBtn.Size = new System.Drawing.Size(90, 90);
            this.ansBtn.TabIndex = 10;
            this.ansBtn.Text = "Ans";
            this.ansBtn.UseVisualStyleBackColor = false;
            this.ansBtn.Click += new System.EventHandler(this.AnsBtn_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn3.Location = new System.Drawing.Point(183, 465);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(90, 90);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn5.Location = new System.Drawing.Point(93, 376);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(90, 90);
            this.Btn5.TabIndex = 5;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn6.Location = new System.Drawing.Point(183, 376);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(90, 90);
            this.Btn6.TabIndex = 6;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn1.Location = new System.Drawing.Point(3, 465);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(90, 90);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn2.Location = new System.Drawing.Point(93, 465);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(90, 90);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn9.Location = new System.Drawing.Point(183, 287);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(90, 90);
            this.Btn9.TabIndex = 9;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn4.Location = new System.Drawing.Point(3, 376);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(90, 90);
            this.Btn4.TabIndex = 4;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn8.Location = new System.Drawing.Point(93, 287);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(90, 90);
            this.Btn8.TabIndex = 8;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn7.Location = new System.Drawing.Point(3, 287);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(90, 90);
            this.Btn7.TabIndex = 7;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // ansLabel
            // 
            this.ansLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansLabel.Location = new System.Drawing.Point(13, 92);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(443, 85);
            this.ansLabel.TabIndex = 28;
            this.ansLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(467, 649);
            this.Controls.Add(this.ansLabel);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.BackSpaceBtn);
            this.Controls.Add(this.exprLabel);
            this.Controls.Add(this.RightParenthesesBtn);
            this.Controls.Add(this.LeftParenthesesBtn);
            this.Controls.Add(this.EvalBtn);
            this.Controls.Add(this.DecBtn);
            this.Controls.Add(this.PowerBtn);
            this.Controls.Add(this.DivisorBtn);
            this.Controls.Add(this.MultBtn);
            this.Controls.Add(this.RootBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.msBtn);
            this.Controls.Add(this.mrBtn);
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
            this.Name = "Calculator";
            this.Text = "A Simple Calculator";
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.Load += new System.EventHandler(this.CalcKubisForm_Load);
            this.ResumeLayout(false);

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
        private MemoryRmBtn mrBtn;
        private MemorySaveBtn msBtn;
        private OperatorBtn MinusBtn;
        private OperatorBtn PlusBtn;
        private OperatorBtn RootBtn;
        private OperatorBtn MultBtn;
        private OperatorBtn DivisorBtn;
        private OperatorBtn PowerBtn;
        private OperatorBtn DecBtn;
        private EvaluatorBtn EvalBtn;
        private OperatorBtn LeftParenthesesBtn;
        private OperatorBtn RightParenthesesBtn;
        private System.Windows.Forms.Label exprLabel;
        private System.Windows.Forms.Button BackSpaceBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label ansLabel;
    }
}

