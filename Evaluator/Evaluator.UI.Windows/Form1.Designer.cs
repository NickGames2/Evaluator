namespace Evaluator.UI.Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn1 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn4 = new Button();
            btn0 = new Button();
            btnPoint = new Button();
            btnDivision = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnMultiply = new Button();
            btnPotency = new Button();
            btnRest = new Button();
            btnPlus = new Button();
            btnCloseParenthesis = new Button();
            btnOpenParenthesis = new Button();
            btnResult = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.Green;
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(26, 32);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(457, 47);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Location = new Point(24, 107);
            btn7.Name = "btn7";
            btn7.Size = new Size(74, 68);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(184, 107);
            btn9.Name = "btn9";
            btn9.Size = new Size(74, 68);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(104, 107);
            btn8.Name = "btn8";
            btn8.Size = new Size(74, 68);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(104, 255);
            btn2.Name = "btn2";
            btn2.Size = new Size(74, 68);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(184, 255);
            btn3.Name = "btn3";
            btn3.Size = new Size(74, 68);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(24, 255);
            btn1.Name = "btn1";
            btn1.Size = new Size(74, 68);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(104, 181);
            btn5.Name = "btn5";
            btn5.Size = new Size(74, 68);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(184, 181);
            btn6.Name = "btn6";
            btn6.Size = new Size(74, 68);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(26, 181);
            btn4.Name = "btn4";
            btn4.Size = new Size(74, 68);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(104, 329);
            btn0.Name = "btn0";
            btn0.Size = new Size(74, 68);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(184, 329);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(74, 68);
            btnPoint.TabIndex = 11;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(24, 329);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(74, 68);
            btnDivision.TabIndex = 10;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(284, 107);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(74, 68);
            btnClear.TabIndex = 13;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(364, 107);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 68);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "DEL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(364, 181);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(74, 68);
            btnMultiply.TabIndex = 16;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnPotency
            // 
            btnPotency.Location = new Point(284, 181);
            btnPotency.Name = "btnPotency";
            btnPotency.Size = new Size(74, 68);
            btnPotency.TabIndex = 15;
            btnPotency.Text = "^";
            btnPotency.UseVisualStyleBackColor = true;
            btnPotency.Click += btnPotency_Click;
            // 
            // btnRest
            // 
            btnRest.Location = new Point(364, 255);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(74, 68);
            btnRest.TabIndex = 18;
            btnRest.Text = "-";
            btnRest.UseVisualStyleBackColor = true;
            btnRest.Click += btnRest_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(284, 255);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(74, 68);
            btnPlus.TabIndex = 17;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.Location = new Point(364, 329);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(74, 68);
            btnCloseParenthesis.TabIndex = 20;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = true;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.Location = new Point(284, 329);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(74, 68);
            btnOpenParenthesis.TabIndex = 19;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = true;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(26, 415);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(412, 68);
            btnResult.TabIndex = 21;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 495);
            Controls.Add(btnResult);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnRest);
            Controls.Add(btnPlus);
            Controls.Add(btnMultiply);
            Controls.Add(btnPotency);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(btnPoint);
            Controls.Add(btnDivision);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn9;
        private Button btn8;
        private Button btn2;
        private Button btn3;
        private Button btn1;
        private Button btn5;
        private Button btn6;
        private Button btn4;
        private Button btn0;
        private Button btnPoint;
        private Button btnDivision;
        private Button btnClear;
        private Button btnDelete;
        private Button btnMultiply;
        private Button btnPotency;
        private Button btnRest;
        private Button btnPlus;
        private Button btnCloseParenthesis;
        private Button btnOpenParenthesis;
        private Button btnResult;
    }
}
