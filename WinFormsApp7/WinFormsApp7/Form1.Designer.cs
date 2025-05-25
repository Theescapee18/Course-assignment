namespace WinFormsApp7
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
            components = new System.ComponentModel.Container();
            tblPuzzleArea = new TableLayoutPanel();
            pnlKeyword = new FlowLayoutPanel();
            pnlVariable = new FlowLayoutPanel();
            pnlSymbol = new FlowLayoutPanel();
            拼图区 = new Label();
            label2 = new Label();
            lblTimer = new Label();
            txtQuestion = new TextBox();
            label4 = new Label();
            btnCheckCode = new Button();
            button2 = new Button();
            btnViewAnswer = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            SuspendLayout();
            // 
            // tblPuzzleArea
            // 
            tblPuzzleArea.Anchor = AnchorStyles.None;
            tblPuzzleArea.BackColor = Color.FromArgb(255, 224, 192);
            tblPuzzleArea.ColumnCount = 2;
            tblPuzzleArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPuzzleArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPuzzleArea.Font = new Font("Microsoft YaHei UI", 14F);
            tblPuzzleArea.Location = new Point(363, 213);
            tblPuzzleArea.Name = "tblPuzzleArea";
            tblPuzzleArea.RowCount = 2;
            tblPuzzleArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPuzzleArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPuzzleArea.Size = new Size(1087, 335);
            tblPuzzleArea.TabIndex = 0;
            // 
            // pnlKeyword
            // 
            pnlKeyword.Anchor = AnchorStyles.None;
            pnlKeyword.AutoScroll = true;
            pnlKeyword.BackColor = Color.FromArgb(255, 255, 192);
            pnlKeyword.Font = new Font("Microsoft YaHei UI", 10.5F);
            pnlKeyword.Location = new Point(363, 606);
            pnlKeyword.Name = "pnlKeyword";
            pnlKeyword.Size = new Size(304, 335);
            pnlKeyword.TabIndex = 1;
            // 
            // pnlVariable
            // 
            pnlVariable.Anchor = AnchorStyles.None;
            pnlVariable.AutoScroll = true;
            pnlVariable.BackColor = Color.FromArgb(255, 255, 192);
            pnlVariable.Font = new Font("Microsoft YaHei UI", 10.5F);
            pnlVariable.Location = new Point(760, 606);
            pnlVariable.Name = "pnlVariable";
            pnlVariable.Size = new Size(300, 335);
            pnlVariable.TabIndex = 2;
            // 
            // pnlSymbol
            // 
            pnlSymbol.Anchor = AnchorStyles.None;
            pnlSymbol.AutoScroll = true;
            pnlSymbol.BackColor = Color.FromArgb(255, 255, 192);
            pnlSymbol.Font = new Font("Microsoft YaHei UI", 10.5F);
            pnlSymbol.Location = new Point(1156, 606);
            pnlSymbol.Name = "pnlSymbol";
            pnlSymbol.Size = new Size(312, 335);
            pnlSymbol.TabIndex = 2;
            // 
            // 拼图区
            // 
            拼图区.Anchor = AnchorStyles.None;
            拼图区.AutoSize = true;
            拼图区.Font = new Font("Microsoft YaHei UI", 14F);
            拼图区.Location = new Point(99, 382);
            拼图区.Name = "拼图区";
            拼图区.Size = new Size(99, 36);
            拼图区.TabIndex = 3;
            拼图区.Text = "拼图区";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 14F);
            label2.Location = new Point(81, 736);
            label2.Name = "label2";
            label2.Size = new Size(127, 36);
            label2.TabIndex = 4;
            label2.Text = "拼图元素";
            // 
            // lblTimer
            // 
            lblTimer.Anchor = AnchorStyles.None;
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Microsoft YaHei UI", 10.5F);
            lblTimer.Location = new Point(1220, 570);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(73, 28);
            lblTimer.TabIndex = 5;
            lblTimer.Text = "label3";
            lblTimer.Click += lblTimer_Click;
            // 
            // txtQuestion
            // 
            txtQuestion.Anchor = AnchorStyles.None;
            txtQuestion.Font = new Font("Microsoft YaHei UI", 14F);
            txtQuestion.Location = new Point(404, 94);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.ReadOnly = true;
            txtQuestion.Size = new Size(867, 43);
            txtQuestion.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 14F);
            label4.Location = new Point(99, 94);
            label4.Name = "label4";
            label4.Size = new Size(71, 36);
            label4.TabIndex = 7;
            label4.Text = "题目";
            // 
            // btnCheckCode
            // 
            btnCheckCode.Anchor = AnchorStyles.None;
            btnCheckCode.Font = new Font("Microsoft YaHei UI", 14F);
            btnCheckCode.Location = new Point(483, 1067);
            btnCheckCode.Name = "btnCheckCode";
            btnCheckCode.Size = new Size(124, 48);
            btnCheckCode.TabIndex = 8;
            btnCheckCode.Text = "验证";
            btnCheckCode.UseVisualStyleBackColor = true;
            btnCheckCode.Click += btnCheckCode_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Microsoft YaHei UI", 14F);
            button2.Location = new Point(807, 1069);
            button2.Name = "button2";
            button2.Size = new Size(111, 44);
            button2.TabIndex = 9;
            button2.Text = "退出";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnViewAnswer
            // 
            btnViewAnswer.Anchor = AnchorStyles.None;
            btnViewAnswer.BackColor = SystemColors.Control;
            btnViewAnswer.Font = new Font("Microsoft YaHei UI", 14F);
            btnViewAnswer.Location = new Point(1030, 1067);
            btnViewAnswer.Name = "btnViewAnswer";
            btnViewAnswer.Size = new Size(119, 44);
            btnViewAnswer.TabIndex = 10;
            btnViewAnswer.Text = "答案";
            btnViewAnswer.UseVisualStyleBackColor = false;
            btnViewAnswer.Click += btnViewAnswer_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10000;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.Control;
            button1.Enabled = false;
            button1.Font = new Font("Microsoft YaHei UI", 14F);
            button1.Location = new Point(1274, 1067);
            button1.Name = "button1";
            button1.Size = new Size(119, 44);
            button1.TabIndex = 11;
            button1.Text = "下一题";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 1144);
            Controls.Add(button1);
            Controls.Add(btnViewAnswer);
            Controls.Add(button2);
            Controls.Add(btnCheckCode);
            Controls.Add(label4);
            Controls.Add(txtQuestion);
            Controls.Add(lblTimer);
            Controls.Add(label2);
            Controls.Add(拼图区);
            Controls.Add(pnlSymbol);
            Controls.Add(pnlVariable);
            Controls.Add(pnlKeyword);
            Controls.Add(tblPuzzleArea);
            Name = "Form1";
            Text = "练习";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblPuzzleArea;
        private FlowLayoutPanel pnlKeyword;
        private FlowLayoutPanel pnlVariable;
        private FlowLayoutPanel pnlSymbol;
        private Label 拼图区;
        private Label label2;
        private Label lblTimer;
        private TextBox txtQuestion;
        private Label label4;
        private Button btnCheckCode;
        private Button button2;
        private Button btnViewAnswer;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}
