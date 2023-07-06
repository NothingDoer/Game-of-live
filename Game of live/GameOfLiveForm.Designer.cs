namespace Game_of_live
{
    partial class GameOfLiveForm
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
            resetButton = new Button();
            startButton = new Button();
            speedLabel = new Label();
            saveButton = new Button();
            loadButton = new Button();
            newButton = new Button();
            gameDisplayPictureBox = new PictureBox();
            oneStepButton = new Button();
            numericUpDown1 = new NumericUpDown();
            generationLabel = new Label();
            generationValueLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)gameDisplayPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // resetButton
            // 
            resetButton.Location = new Point(118, 12);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(100, 29);
            resetButton.TabIndex = 0;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(224, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(100, 29);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startOrPauseButton_Click;
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new Point(436, 19);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(42, 15);
            speedLabel.TabIndex = 2;
            speedLabel.Text = "Speed:";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveButton.Location = new Point(1121, 12);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 29);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loadButton.Location = new Point(1015, 12);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(100, 29);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // newButton
            // 
            newButton.Location = new Point(12, 12);
            newButton.Name = "newButton";
            newButton.Size = new Size(100, 29);
            newButton.TabIndex = 6;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // gameDisplayPictureBox
            // 
            gameDisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameDisplayPictureBox.BackColor = Color.White;
            gameDisplayPictureBox.Location = new Point(0, 47);
            gameDisplayPictureBox.Name = "gameDisplayPictureBox";
            gameDisplayPictureBox.Size = new Size(1234, 614);
            gameDisplayPictureBox.TabIndex = 7;
            gameDisplayPictureBox.TabStop = false;
            gameDisplayPictureBox.Paint += gameDisplayPictureBox_Paint;
            gameDisplayPictureBox.MouseDown += gameDisplayPictureBox_MouseDown;
            // 
            // oneStepButton
            // 
            oneStepButton.Location = new Point(330, 12);
            oneStepButton.Name = "oneStepButton";
            oneStepButton.Size = new Size(100, 29);
            oneStepButton.TabIndex = 8;
            oneStepButton.Text = "One Step";
            oneStepButton.UseVisualStyleBackColor = true;
            oneStepButton.Click += oneStepButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(484, 17);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // generationLabel
            // 
            generationLabel.AutoSize = true;
            generationLabel.Location = new Point(610, 19);
            generationLabel.Name = "generationLabel";
            generationLabel.Size = new Size(68, 15);
            generationLabel.TabIndex = 10;
            generationLabel.Text = "Generation:";
            // 
            // generationValueLabel
            // 
            generationValueLabel.AutoSize = true;
            generationValueLabel.Location = new Point(684, 19);
            generationValueLabel.Name = "generationValueLabel";
            generationValueLabel.Size = new Size(13, 15);
            generationValueLabel.TabIndex = 11;
            generationValueLabel.Text = "0";
            // 
            // timer1
            // 
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "json";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = ".json|*.json|All Files|*.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "json";
            saveFileDialog1.Filter = ".json|*.json|All Files|*.*";
            // 
            // GameOfLiveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1234, 661);
            Controls.Add(generationValueLabel);
            Controls.Add(generationLabel);
            Controls.Add(numericUpDown1);
            Controls.Add(oneStepButton);
            Controls.Add(gameDisplayPictureBox);
            Controls.Add(newButton);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(speedLabel);
            Controls.Add(startButton);
            Controls.Add(resetButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1000, 600);
            Name = "GameOfLiveForm";
            Text = "Game Of Live";
            ((System.ComponentModel.ISupportInitialize)gameDisplayPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetButton;
        private Button startButton;
        private Label speedLabel;
        private Button saveButton;
        private Button loadButton;
        private Button newButton;
        private PictureBox gameDisplayPictureBox;
        private Button oneStepButton;
        private NumericUpDown numericUpDown1;
        private Label generationLabel;
        private Label generationValueLabel;
        private System.Windows.Forms.Timer timer1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}