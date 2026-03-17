namespace Calculator
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
            btnBS = new Button();
            txtResult = new TextBox();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnPM = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSub = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMult = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEqual = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // btnBS
            // 
            btnBS.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btnBS.Location = new Point(12, 91);
            btnBS.Name = "btnBS";
            btnBS.Size = new Size(75, 67);
            btnBS.TabIndex = 0;
            btnBS.Text = "⌫";
            btnBS.UseVisualStyleBackColor = true;
            btnBS.Click += btnBS_Click;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.ControlLightLight;
            txtResult.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(12, 38);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(359, 47);
            txtResult.TabIndex = 1;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btnClearEntry.Location = new Point(106, 91);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(75, 67);
            btnClearEntry.TabIndex = 2;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btnClear.Location = new Point(201, 91);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 67);
            btnClear.TabIndex = 3;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPM
            // 
            btnPM.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btnPM.Location = new Point(296, 91);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(75, 67);
            btnPM.TabIndex = 4;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += btnPM_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btn7.Location = new Point(12, 164);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 67);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += EnterNumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btn8.Location = new Point(106, 164);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 67);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += EnterNumbers;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btn9.Location = new Point(201, 164);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 67);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += EnterNumbers;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btnAdd.Location = new Point(296, 164);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 67);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += numberOperators;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btn4.Location = new Point(12, 237);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 67);
            btn4.TabIndex = 0;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += EnterNumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btn5.Location = new Point(106, 237);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 67);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += EnterNumbers;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btn6.Location = new Point(201, 237);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 67);
            btn6.TabIndex = 3;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += EnterNumbers;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btnSub.Location = new Point(296, 237);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 67);
            btnSub.TabIndex = 4;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += numberOperators;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btn1.Location = new Point(12, 310);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 67);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += EnterNumbers;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btn2.Location = new Point(106, 310);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 67);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += EnterNumbers;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btn3.Location = new Point(201, 310);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 67);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += EnterNumbers;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btnMult.Location = new Point(296, 310);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(75, 67);
            btnMult.TabIndex = 4;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += numberOperators;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btn0.Location = new Point(12, 383);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 67);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += EnterNumbers;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btnDot.Location = new Point(106, 383);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(75, 67);
            btnDot.TabIndex = 2;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += EnterNumbers;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btnEqual.Location = new Point(201, 383);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(75, 67);
            btnEqual.TabIndex = 3;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            btnDiv.Location = new Point(296, 383);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 67);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += numberOperators;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(380, 467);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(btnPM);
            Controls.Add(btnEqual);
            Controls.Add(btnDot);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btn8);
            Controls.Add(btn1);
            Controls.Add(btnClear);
            Controls.Add(btn4);
            Controls.Add(btnClearEntry);
            Controls.Add(btn7);
            Controls.Add(txtResult);
            Controls.Add(btnBS);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBS;
        private TextBox txtResult;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnPM;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSub;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMult;
        private Button btn0;
        private Button btnDot;
        private Button btnEqual;
        private Button btnDiv;
    }
}
