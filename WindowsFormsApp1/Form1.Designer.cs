namespace WindowsFormsApp1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.outputA = new System.Windows.Forms.TextBox();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.lableInputA = new System.Windows.Forms.Label();
            this.lableInputB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(106, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "a+b";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.add);
            // 
            // btnDec
            // 
            this.btnDec.AutoEllipsis = true;
            this.btnDec.Location = new System.Drawing.Point(55, 96);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(45, 44);
            this.btnDec.TabIndex = 1;
            this.btnDec.Text = "a-b";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.decrease);
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(55, 37);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(329, 26);
            this.inputA.TabIndex = 2;
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(55, 66);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(329, 26);
            this.inputB.TabIndex = 3;
            this.inputB.TextChanged += new System.EventHandler(this.inputB_TextChanged);
            // 
            // outputA
            // 
            this.outputA.Location = new System.Drawing.Point(55, 160);
            this.outputA.Name = "outputA";
            this.outputA.Size = new System.Drawing.Size(329, 26);
            this.outputA.TabIndex = 4;
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(161, 98);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(49, 42);
            this.btnMul.TabIndex = 5;
            this.btnMul.Text = "a*b";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.multyply);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(216, 100);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(49, 42);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "a/b";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.divide);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(326, 100);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(49, 42);
            this.btnPow.TabIndex = 8;
            this.btnPow.Text = "a^b";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.power);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(271, 100);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(49, 42);
            this.btnSqrt.TabIndex = 9;
            this.btnSqrt.Text = " √a";
            this.btnSqrt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.sqrt);
            // 
            // lableInputA
            // 
            this.lableInputA.AutoSize = true;
            this.lableInputA.Location = new System.Drawing.Point(17, 40);
            this.lableInputA.Name = "lableInputA";
            this.lableInputA.Size = new System.Drawing.Size(22, 20);
            this.lableInputA.TabIndex = 10;
            this.lableInputA.Text = "a:";
            // 
            // lableInputB
            // 
            this.lableInputB.AutoSize = true;
            this.lableInputB.Location = new System.Drawing.Point(17, 72);
            this.lableInputB.Name = "lableInputB";
            this.lableInputB.Size = new System.Drawing.Size(22, 20);
            this.lableInputB.TabIndex = 11;
            this.lableInputB.Text = "b:";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.lableInputB);
            this.Controls.Add(this.lableInputA);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.outputA);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnAdd);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.TextBox outputA;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Label lableInputA;
        private System.Windows.Forms.Label lableInputB;
    }
}

