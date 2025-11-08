namespace Bai05
{
    partial class FormBai5
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
            plusBtn = new Button();
            minusBtn = new Button();
            multiplyBtn = new Button();
            divideBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            number1TxtBox = new TextBox();
            number2TxtBox = new TextBox();
            answerTxtBox = new TextBox();
            SuspendLayout();
            // 
            // plusBtn
            // 
            plusBtn.Font = new Font("Segoe UI", 18F);
            plusBtn.Location = new Point(151, 203);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(94, 80);
            plusBtn.TabIndex = 0;
            plusBtn.Text = "+";
            plusBtn.UseVisualStyleBackColor = true;
            // 
            // minusBtn
            // 
            minusBtn.Font = new Font("Segoe UI", 18F);
            minusBtn.Location = new Point(275, 203);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(94, 80);
            minusBtn.TabIndex = 1;
            minusBtn.Text = "-";
            minusBtn.UseVisualStyleBackColor = true;
            // 
            // multiplyBtn
            // 
            multiplyBtn.Font = new Font("Segoe UI", 18F);
            multiplyBtn.Location = new Point(395, 203);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(94, 80);
            multiplyBtn.TabIndex = 2;
            multiplyBtn.Text = "x";
            multiplyBtn.UseVisualStyleBackColor = true;
            // 
            // divideBtn
            // 
            divideBtn.Font = new Font("Segoe UI", 18F);
            divideBtn.Location = new Point(525, 203);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(94, 80);
            divideBtn.TabIndex = 3;
            divideBtn.Text = "/";
            divideBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 99);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 140);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Number 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 319);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "Answer";
            // 
            // number1TxtBox
            // 
            number1TxtBox.Location = new Point(263, 96);
            number1TxtBox.Name = "number1TxtBox";
            number1TxtBox.Size = new Size(381, 27);
            number1TxtBox.TabIndex = 9;
            // 
            // number2TxtBox
            // 
            number2TxtBox.Location = new Point(263, 137);
            number2TxtBox.Name = "number2TxtBox";
            number2TxtBox.Size = new Size(381, 27);
            number2TxtBox.TabIndex = 10;
            // 
            // answerTxtBox
            // 
            answerTxtBox.Location = new Point(263, 312);
            answerTxtBox.Name = "answerTxtBox";
            answerTxtBox.ReadOnly = true;
            answerTxtBox.Size = new Size(381, 27);
            answerTxtBox.TabIndex = 11;
            // 
            // FormBai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(answerTxtBox);
            Controls.Add(number2TxtBox);
            Controls.Add(number1TxtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(divideBtn);
            Controls.Add(multiplyBtn);
            Controls.Add(minusBtn);
            Controls.Add(plusBtn);
            Name = "FormBai5";
            Text = "Form Bai 5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button plusBtn;
        private Button minusBtn;
        private Button multiplyBtn;
        private Button divideBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox number1TxtBox;
        private TextBox number2TxtBox;
        private TextBox answerTxtBox;
    }
}
