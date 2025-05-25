namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private Dictionary<Control, Rectangle> originalControlBounds = new();
        private Size originalFormSize;
        private int elapsedSeconds = 0;

        // ��ȷ�𰸰��в��
        // ����ԭʼ�ṹ������Ԫ�أ�ÿ��һ�� List<string>��
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
            txtQuestion.Text = "�뽫 C ���� twoSum ��������ƴ����Ҫ��ṹ��ȷ��˳��׼ȷ��������ʵ������֮�͡�";

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            InitializePuzzleArea();
            AddCodeBlocks(); // ����ƴͼ��
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            lblTimer.Text = $"��ʱ��{elapsedSeconds} ��";
        }

        // ��ʼ��ƴͼ��ռλ�ṹ��12�У�
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

        // ���ƴͼ�鵽��Ӧ����
        private void AddCodeBlocks()
        {
            // ʾ������ɰ�����ȡ�ؼ��֡��������������������
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

            // ��¡һ���µ�ƴͼ��
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

            // ��ѡ���������¿鷵�ط�����
            newBlock.Click += DeleteFromPuzzle;

            // ����ƴͼ���ĵ�һ��ռλ
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

            MessageBox.Show("����ռλ�������޷���ӣ�");
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
                MessageBox.Show("��ϲ�㣬ƴͼ��ȫ��ȷ��");
            }
            else
            {
                MessageBox.Show("���ڴ����ȱʧ���������ɫ��飡");
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

            // �ҳ���� block ������
            foreach (TableLayoutPanel rowPanel in tblPuzzleArea.Controls.OfType<TableLayoutPanel>())
            {
                if (rowPanel.Controls.Contains(block))
                {
                    int index = rowPanel.Controls.GetChildIndex(block);
                    rowPanel.Controls.Remove(block);

                    // �ָ�ռλ��
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
    

