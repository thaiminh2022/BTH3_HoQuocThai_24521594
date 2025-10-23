namespace Bai09
{
    partial class FromBai9
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            enrollCoursesBox = new ListBox();
            button3 = new Button();
            button4 = new Button();
            availableCoursesBox = new ListBox();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            maleCheckbox = new CheckBox();
            femaleCheckbox = new CheckBox();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.81556F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.18444F));
            tableLayoutPanel1.Size = new Size(1040, 797);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Location = new Point(64, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(912, 370);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(146, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 135);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(enrollCoursesBox, 2, 0);
            tableLayoutPanel3.Controls.Add(button3, 1, 0);
            tableLayoutPanel3.Controls.Add(button4, 1, 1);
            tableLayoutPanel3.Controls.Add(availableCoursesBox, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 24);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(577, 111);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // enrollCoursesBox
            // 
            enrollCoursesBox.Dock = DockStyle.Fill;
            enrollCoursesBox.FormattingEnabled = true;
            enrollCoursesBox.Location = new Point(341, 3);
            enrollCoursesBox.Name = "enrollCoursesBox";
            tableLayoutPanel3.SetRowSpan(enrollCoursesBox, 2);
            enrollCoursesBox.Size = new Size(233, 105);
            enrollCoursesBox.TabIndex = 3;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(241, 3);
            button3.Name = "button3";
            button3.Size = new Size(94, 49);
            button3.TabIndex = 0;
            button3.Text = ">";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(241, 58);
            button4.Name = "button4";
            button4.Size = new Size(94, 50);
            button4.TabIndex = 1;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            // 
            // availableCoursesBox
            // 
            availableCoursesBox.Dock = DockStyle.Fill;
            availableCoursesBox.FormattingEnabled = true;
            availableCoursesBox.Location = new Point(3, 3);
            availableCoursesBox.Name = "availableCoursesBox";
            tableLayoutPanel3.SetRowSpan(availableCoursesBox, 2);
            availableCoursesBox.Size = new Size(232, 105);
            availableCoursesBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 1);
            label5.Name = "label5";
            label5.Size = new Size(194, 20);
            label5.TabIndex = 0;
            label5.Text = "Chọn các môn học tham gia";
            // 
            // button2
            // 
            button2.Location = new Point(489, 335);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Xóa chọn";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(367, 335);
            button1.Name = "button1";
            button1.Size = new Size(116, 29);
            button1.TabIndex = 2;
            button1.Text = "Lưu thông tin";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.7869415F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.21306F));
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(comboBox1, 1, 2);
            tableLayoutPanel2.Controls.Add(panel2, 1, 3);
            tableLayoutPanel2.Location = new Point(146, 41);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(582, 147);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(188, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(391, 27);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 36);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(179, 36);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 72);
            label3.Name = "label3";
            label3.Size = new Size(179, 36);
            label3.TabIndex = 2;
            label3.Text = "Chuyên Ngành";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 108);
            label4.Name = "label4";
            label4.Size = new Size(179, 39);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 27);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(188, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(391, 28);
            comboBox1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(maleCheckbox);
            panel2.Controls.Add(femaleCheckbox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(188, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 33);
            panel2.TabIndex = 7;
            // 
            // maleCheckbox
            // 
            maleCheckbox.AutoSize = true;
            maleCheckbox.Dock = DockStyle.Left;
            maleCheckbox.Location = new Point(51, 0);
            maleCheckbox.Name = "maleCheckbox";
            maleCheckbox.Size = new Size(63, 33);
            maleCheckbox.TabIndex = 4;
            maleCheckbox.Text = "Nam";
            maleCheckbox.UseVisualStyleBackColor = true;
            // 
            // femaleCheckbox
            // 
            femaleCheckbox.AutoSize = true;
            femaleCheckbox.Dock = DockStyle.Left;
            femaleCheckbox.Location = new Point(0, 0);
            femaleCheckbox.Name = "femaleCheckbox";
            femaleCheckbox.Size = new Size(51, 33);
            femaleCheckbox.TabIndex = 5;
            femaleCheckbox.Text = "Nữ";
            femaleCheckbox.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 408);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(915, 347);
            dataGridView1.TabIndex = 1;
            // 
            // FromBai9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 797);
            Controls.Add(tableLayoutPanel1);
            Name = "FromBai9";
            Text = "wwwww";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button3;
        private Button button4;
        private ListBox enrollCoursesBox;
        private ListBox availableCoursesBox;
        private Panel panel2;
        private CheckBox maleCheckbox;
        private CheckBox femaleCheckbox;
    }
}
