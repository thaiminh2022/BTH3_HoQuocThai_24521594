namespace Bai03
{
    partial class FormBai3
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
            changeColorBtn = new Button();
            SuspendLayout();
            // 
            // changeColorBtn
            // 
            changeColorBtn.Anchor = AnchorStyles.None;
            changeColorBtn.Location = new Point(277, 187);
            changeColorBtn.Name = "changeColorBtn";
            changeColorBtn.Size = new Size(214, 56);
            changeColorBtn.TabIndex = 0;
            changeColorBtn.Text = "Change Color";
            changeColorBtn.UseVisualStyleBackColor = true;
            changeColorBtn.Click += changeColorBtn_Click;
            // 
            // FormBai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(changeColorBtn);
            Name = "FormBai3";
            Text = "Form Bai 3";
            ResumeLayout(false);
        }

        #endregion

        private Button changeColorBtn;
    }
}
