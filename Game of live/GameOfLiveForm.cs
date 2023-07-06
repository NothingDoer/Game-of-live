namespace Game_of_live
{
    public partial class GameOfLiveForm : Form
    {
        private SolidBrush fillBrush = new SolidBrush(Color.Black);
        private SolidBrush unfillBrush = new SolidBrush(Color.White);
        private Pen pen = new Pen(Color.Black);
        private GameLogic game = new GameLogic();

        public GameOfLiveForm()
        {
            InitializeComponent();
            SetCorrectFormSize();
            setChangeTime();
        }

        private void DrawGrid(Graphics graphics)
        {
            for (int y = 0; y < GlobalConfig.YSize; y++)
            {
                for (int x = 0; x < GlobalConfig.XSize; x++)
                {
                    DrawCell(graphics, x, y);
                }
            }

            generationValueLabel.Text = game.Generation.ToString();
        }

        private void DrawCell(Graphics graphics, int x, int y)
        {
            Rectangle rectangle = new Rectangle(x * GlobalConfig.Resolution, y * GlobalConfig.Resolution, GlobalConfig.Resolution, GlobalConfig.Resolution);

            if (game.CurrentCells[x, y])
            {
                graphics.FillRectangle(fillBrush, rectangle);
            }
            else
            {
                graphics.FillRectangle(unfillBrush, rectangle);
            }

            graphics.DrawRectangle(pen, rectangle);
        }

        private void SetCorrectFormSize()
        {
            Size = new Size(GlobalConfig.XSize * GlobalConfig.Resolution + 17, GlobalConfig.YSize * GlobalConfig.Resolution + 87);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            startButton.Text = "Start";
            timer1.Enabled = false;
            game = new GameLogic();
            gameDisplayPictureBox.Refresh();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            startButton.Text = "Start";
            timer1.Enabled = false;
            game.RestartGame();
            gameDisplayPictureBox.Refresh();
        }

        private void startOrPauseButton_Click(object sender, EventArgs e)
        {
            if (game.IsPaused)
            {
                game.StartGame();
                startButton.Text = "Pause";
                timer1.Enabled = true;
            }
            else
            {
                game.PauseGame();
                startButton.Text = "Start";
                timer1.Enabled = false;
            }
        }

        private void oneStepButton_Click(object sender, EventArgs e)
        {
            game.OneStep();
            gameDisplayPictureBox.Refresh();
        }

        private void gameDisplayPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X / GlobalConfig.Resolution;
            int y = e.Y / GlobalConfig.Resolution;
            game.ChangeCellValue(x, y);
            gameDisplayPictureBox.Refresh();
        }

        private void gameDisplayPictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.OneStep();
            gameDisplayPictureBox.Refresh();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            setChangeTime();
        }

        private void setChangeTime()
        {
            timer1.Interval = (int)(((numericUpDown1.Maximum + 1) - numericUpDown1.Value) * GlobalConfig.WaitTime);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            startButton.Text = "Start";
            timer1.Enabled = false;
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                game.LoadGame(openFileDialog1.FileName);
            }
            gameDisplayPictureBox.Refresh();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                game.SaveGame(saveFileDialog1.FileName);
            }
        }
    }
}