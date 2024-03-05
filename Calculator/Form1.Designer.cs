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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            textBox1 = new TextBox();
            buttonC = new Button();
            buttonCE = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonEqual = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 51);
            button1.Name = "button1";
            button1.Size = new Size(65, 60);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(83, 51);
            button2.Name = "button2";
            button2.Size = new Size(65, 60);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(154, 51);
            button3.Name = "button3";
            button3.Size = new Size(65, 60);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(225, 51);
            button4.Name = "button4";
            button4.Size = new Size(65, 60);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 117);
            button5.Name = "button5";
            button5.Size = new Size(65, 60);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(83, 117);
            button6.Name = "button6";
            button6.Size = new Size(65, 60);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(154, 117);
            button7.Name = "button7";
            button7.Size = new Size(65, 60);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(225, 117);
            button8.Name = "button8";
            button8.Size = new Size(65, 60);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(12, 183);
            button9.Name = "button9";
            button9.Size = new Size(65, 60);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(83, 183);
            button0.Name = "button0";
            button0.Size = new Size(65, 60);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(460, 33);
            textBox1.TabIndex = 10;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(154, 183);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(65, 60);
            buttonC.TabIndex = 11;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += clear;
            // 
            // buttonCE
            // 
            buttonCE.Location = new Point(225, 183);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(65, 60);
            buttonCE.TabIndex = 12;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += clearEntry;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 249);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(65, 60);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += add;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(83, 249);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(65, 60);
            buttonSubtract.TabIndex = 14;
            buttonSubtract.Text = "−";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += subtract;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(154, 249);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(65, 60);
            buttonMultiply.TabIndex = 15;
            buttonMultiply.Text = "×";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += multiply;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(225, 249);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(65, 60);
            buttonDivide.TabIndex = 16;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += divide;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(296, 51);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(176, 258);
            buttonEqual.TabIndex = 17;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += equals;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 323);
            Controls.Add(buttonEqual);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(buttonCE);
            Controls.Add(buttonC);
            Controls.Add(textBox1);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private TextBox textBox1;
        private Button buttonC;
        private Button buttonCE;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonEqual;
    }
}
