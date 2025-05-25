namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private Dictionary<Control, Rectangle> originalControlBounds = new();
        private Size originalFormSize;
        private int elapsedSeconds = 0;

        // 正确答案按行拆分
        // 用于原始结构化代码元素（每行一个 List<string>）
        private List<List<string>> tokenLines = new List<List<string>>
        {
    new List<string> { "int", "*", "twoSum", "(", "int", "*", "nums", ",", "int", "numsSize", ",", "int", "target", ",", "int", "*", "returnSize", ")", "{" },
    new List<string> { "for", "(", "int", "i", "=", "0", ";", "i", "<", "numsSize", ";", "++", "i", ")", "{" },
    new List<string> { "for", "(", "int", "j", "=", "i", "+", "1", ";", "j", "<", "numsSize", ";", "++", "j", ")", "{" },
    new List<string> { "if", "(", "nums", "[", "i", "]", "+", "nums", "[", "j", "]", "==", "target", ")", "{" },
    new List<string> { "int", "*", "ret", "=", "malloc", "(", "sizeof", "(", "int", ")", "*", "2", ")", ";" },
    new List<string> { "ret", "[", "0", "]", "=", "i", ",", "ret", "[", "1", "]", "=", "j", ";" },
    new List<string> { "*", "returnSize", "=", "2", ";" },
    new List<string> { "return", "ret", ";" },
    new List<string> { "}", },
    new List<string> { "*", "returnSize", "=", "0", ";" },
    new List<string> { "return", "NULL", ";" },
    new List<string> { "}", },
        };
        private readonly List<int> columnsPerLine = new List<int>
        {
            5,6,6,5,7,7,7,7,7,7,7,1

        };

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.Resize += Form1_Resize;

        }

        private void Form1_Load1(object? sender, EventArgs e)
        {
            originalFormSize = this.Size;
            SaveOriginalLayout(this);
            throw new NotImplementedException();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtQuestion.Text = "请将 C 语言 twoSum 函数完整拼出，要求结构正确，顺序准确，函数可实现两数之和。";

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            InitializePuzzleArea();
            AddCodeBlocks(); // 加载拼图块
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            lblTimer.Text = $"用时：{elapsedSeconds} 秒";
        }

        // 初始化拼图区占位结构（12行）
        private void InitializePuzzleArea()
        {
            tblPuzzleArea.Controls.Clear();
            tblPuzzleArea.RowCount = columnsPerLine.Count;
            tblPuzzleArea.ColumnCount = 1;
            tblPuzzleArea.RowStyles.Clear();

            for (int row = 0; row < columnsPerLine.Count; row++)
            {
                int columnCount = columnsPerLine[row];

                TableLayoutPanel rowPanel = new TableLayoutPanel
                {
                    ColumnCount = columnCount,
                    RowCount = 1,
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    Margin = new Padding(2),
                    Tag = $"Row{row + 1}"
                };

                for (int col = 0; col < columnCount; col++)
                {
                    Label placeholder = new Label
                    {
                        Width = 90,
                        Height = 50,
                        Margin = new Padding(3),
                        Text = "",
                        Tag = "placeholder",
                        BackColor = Color.LightGray,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    rowPanel.Controls.Add(placeholder);
                }

                tblPuzzleArea.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tblPuzzleArea.Controls.Add(rowPanel);
            }
        }

        // 添加拼图块到对应分类
        private void AddCodeBlocks()
        {
            // 示例：你可按行提取关键字、变量、符号来分类添加
            string[] keywords = { "int", "return", "for", "if", "sizeof", "malloc" };

            string[] variables = { "nums", "i", "j", "target", "numsSize", "ret", "returnSize", "NULL" };
            string[] symbols = { "*", "=", "(", ")", "{", "}", "[", "]", ";", ",", "+", "++", "<", "==" };

            foreach (var item in keywords)
                pnlKeyword.Controls.Add(CreateCodeBlock(item, "keyword"));

            foreach (var item in variables)
                pnlVariable.Controls.Add(CreateCodeBlock(item, "variable"));

            foreach (var item in symbols)
                pnlSymbol.Controls.Add(CreateCodeBlock(item, "symbol"));
        }

        private Label CreateCodeBlock(string text, string type)
        {
            Label block = new Label
            {
                Text = text,
                Tag = type,
                AutoSize = false,
                Width = 120,
                Height = 50,
                Margin = new Padding(4),
                Padding = new Padding(5),
                BackColor = Color.LightBlue,
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter
            };

            block.Click += CodeBlock_Click;

            return block;
        }

        private void CodeBlock_Click(object sender, EventArgs e)
        {
            if (sender is not Label sourceBlock) return;

            // 克隆一个新的拼图块
            Label newBlock = new Label
            {
                Text = sourceBlock.Text,
                Tag = sourceBlock.Tag,
                Width = sourceBlock.Width,
                Height = sourceBlock.Height,
                Margin = sourceBlock.Margin,
                BackColor = sourceBlock.BackColor,
                BorderStyle = sourceBlock.BorderStyle,
                TextAlign = sourceBlock.TextAlign,
                Cursor = Cursors.Hand
            };

            // 可选：允许点击新块返回分类区
            newBlock.Click += DeleteFromPuzzle;

            // 插入拼图区的第一个占位
            foreach (TableLayoutPanel rowPanel in tblPuzzleArea.Controls.OfType<TableLayoutPanel>())
            {
                for (int i = 0; i < rowPanel.Controls.Count; i++)
                {
                    var cell = rowPanel.Controls[i] as Label;
                    if (cell?.Tag?.ToString() == "placeholder")
                    {
                        rowPanel.Controls.RemoveAt(i);
                        rowPanel.Controls.Add(newBlock);
                        rowPanel.Controls.SetChildIndex(newBlock, i);
                        return;
                    }
                }
            }

            MessageBox.Show("所有占位已满，无法添加！");
        }
        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            bool isCorrect = true;

            for (int i = 0; i < tokenLines.Count; i++)
            {
                if (i >= tblPuzzleArea.Controls.Count) continue;

                var rowPanel = tblPuzzleArea.Controls[i] as TableLayoutPanel;
                var userTokens = rowPanel.Controls
                    .OfType<Label>()
                    .Where(lbl => lbl.Tag?.ToString() != "placeholder")
                    .Select(lbl => lbl.Text.Trim())
                    .ToList();

                var expectedTokens = tokenLines[i];

                if (userTokens.Count < expectedTokens.Count)
                {
                    HighlightRow(rowPanel, Color.LightYellow);
                    isCorrect = false;
                }
                else if (!userTokens.SequenceEqual(expectedTokens))
                {
                    HighlightRow(rowPanel, Color.LightCoral);
                    isCorrect = false;
                }
                else
                {
                    HighlightRow(rowPanel, Color.LightGreen);
                }
            }

            if (isCorrect)
            {
                timer1.Stop();
                MessageBox.Show("恭喜你，拼图完全正确！");
            }
            else
            {
                MessageBox.Show("存在错误或缺失，请根据颜色检查！");
            }
        }

        private void HighlightRow(TableLayoutPanel rowPanel, Color color)
        {
            foreach (Label lbl in rowPanel.Controls.OfType<Label>())
            {
                if (lbl.Tag?.ToString() != "placeholder")
                {
                    lbl.BackColor = color;
                }
            }
        }
        private void DeleteFromPuzzle(object sender, EventArgs e)
        {
            if (sender is not Label block) return;

            // 找出这个 block 所在行
            foreach (TableLayoutPanel rowPanel in tblPuzzleArea.Controls.OfType<TableLayoutPanel>())
            {
                if (rowPanel.Controls.Contains(block))
                {
                    int index = rowPanel.Controls.GetChildIndex(block);
                    rowPanel.Controls.Remove(block);

                    // 恢复占位符
                    Label placeholder = new Label
                    {
                        Width = 90,
                        Height = 40,
                        BackColor = Color.LightGray,
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = "placeholder"
                    };
                    rowPanel.Controls.Add(placeholder);
                    rowPanel.Controls.SetChildIndex(placeholder, index);
                    break;
                }
            }
        }

        private void btnViewAnswer_Click(object sender, EventArgs e)
        {
            AnswerForm answerForm = new AnswerForm();
            answerForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void SaveOriginalLayout(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                originalControlBounds[ctrl] = ctrl.Bounds;

                if (ctrl.HasChildren)
                    SaveOriginalLayout(ctrl);
            }
        }
        private void ResizeAllControls(Control container, float scaleX, float scaleY)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (originalControlBounds.TryGetValue(ctrl, out Rectangle original))
                {
                    ctrl.Left = (int)(original.Left * scaleX);
                    ctrl.Top = (int)(original.Top * scaleY);
                    ctrl.Width = (int)(original.Width * scaleX);
                    ctrl.Height = (int)(original.Height * scaleY);
                }

                if (ctrl.HasChildren)
                    ResizeAllControls(ctrl, scaleX, scaleY);
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            float scaleX = (float)this.Width / originalFormSize.Width;
            float scaleY = (float)this.Height / originalFormSize.Height;

            ResizeAllControls(this, scaleX, scaleY);
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }


}
    

