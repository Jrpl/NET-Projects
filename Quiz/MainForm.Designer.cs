
namespace Quiz
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ResultsButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.SLabel = new System.Windows.Forms.Label();
            this.EqualLabel = new System.Windows.Forms.Label();
            this.QLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuResults = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.NumOneLabel = new System.Windows.Forms.Label();
            this.OperandLabel = new System.Windows.Forms.Label();
            this.NumTwoLabel = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(33, 163);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(33, 201);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ResultsButton
            // 
            this.ResultsButton.Location = new System.Drawing.Point(144, 163);
            this.ResultsButton.Name = "ResultsButton";
            this.ResultsButton.Size = new System.Drawing.Size(75, 23);
            this.ResultsButton.TabIndex = 3;
            this.ResultsButton.Text = "Results";
            this.ResultsButton.UseVisualStyleBackColor = true;
            this.ResultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(144, 201);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(144, 99);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(100, 23);
            this.AnswerTextBox.TabIndex = 5;
            // 
            // SLabel
            // 
            this.SLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SLabel.Location = new System.Drawing.Point(60, 132);
            this.SLabel.Name = "SLabel";
            this.SLabel.Size = new System.Drawing.Size(61, 25);
            this.SLabel.TabIndex = 8;
            this.SLabel.Text = "Score:";
            this.SLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EqualLabel
            // 
            this.EqualLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EqualLabel.Location = new System.Drawing.Point(114, 99);
            this.EqualLabel.Name = "EqualLabel";
            this.EqualLabel.Size = new System.Drawing.Size(24, 25);
            this.EqualLabel.TabIndex = 9;
            this.EqualLabel.Text = "=";
            // 
            // QLabel
            // 
            this.QLabel.AutoSize = true;
            this.QLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QLabel.Location = new System.Drawing.Point(24, 77);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(65, 19);
            this.QLabel.TabIndex = 10;
            this.QLabel.Text = "Question";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerLabel.Location = new System.Drawing.Point(165, 77);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(54, 19);
            this.AnswerLabel.TabIndex = 11;
            this.AnswerLabel.Text = "Answer";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.Location = new System.Drawing.Point(99, 24);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(50, 21);
            this.TimerLabel.TabIndex = 12;
            this.TimerLabel.Text = "Timer";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Location = new System.Drawing.Point(127, 134);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(57, 23);
            this.ScoreLabel.TabIndex = 14;
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(99, 45);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(50, 34);
            this.TimeLabel.TabIndex = 15;
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Menu
            // 
            this.Menu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStart,
            this.MenuStop,
            this.MenuResults,
            this.MenuSettings});
            this.Menu.Location = new System.Drawing.Point(24, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(211, 24);
            this.Menu.TabIndex = 16;
            this.Menu.Text = "Menu";
            // 
            // MenuStart
            // 
            this.MenuStart.Name = "MenuStart";
            this.MenuStart.Size = new System.Drawing.Size(43, 20);
            this.MenuStart.Text = "Start";
            // 
            // MenuStop
            // 
            this.MenuStop.Name = "MenuStop";
            this.MenuStop.Size = new System.Drawing.Size(43, 20);
            this.MenuStop.Text = "Stop";
            // 
            // MenuResults
            // 
            this.MenuResults.Name = "MenuResults";
            this.MenuResults.Size = new System.Drawing.Size(56, 20);
            this.MenuResults.Text = "Results";
            // 
            // MenuSettings
            // 
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(61, 20);
            this.MenuSettings.Text = "Settings";
            // 
            // NumOneLabel
            // 
            this.NumOneLabel.Location = new System.Drawing.Point(7, 99);
            this.NumOneLabel.Name = "NumOneLabel";
            this.NumOneLabel.Size = new System.Drawing.Size(33, 23);
            this.NumOneLabel.TabIndex = 17;
            // 
            // OperandLabel
            // 
            this.OperandLabel.Location = new System.Drawing.Point(46, 99);
            this.OperandLabel.Name = "OperandLabel";
            this.OperandLabel.Size = new System.Drawing.Size(25, 23);
            this.OperandLabel.TabIndex = 18;
            // 
            // NumTwoLabel
            // 
            this.NumTwoLabel.Location = new System.Drawing.Point(77, 99);
            this.NumTwoLabel.Name = "NumTwoLabel";
            this.NumTwoLabel.Size = new System.Drawing.Size(31, 23);
            this.NumTwoLabel.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 236);
            this.Controls.Add(this.NumTwoLabel);
            this.Controls.Add(this.OperandLabel);
            this.Controls.Add(this.NumOneLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.EqualLabel);
            this.Controls.Add(this.SLabel);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ResultsButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ResultsButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label SLabel;
        private System.Windows.Forms.Label EqualLabel;
        private System.Windows.Forms.Label QLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuStart;
        private System.Windows.Forms.ToolStripMenuItem MenuStop;
        private System.Windows.Forms.ToolStripMenuItem MenuResults;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings;
        private System.Windows.Forms.Label NumOneLabel;
        private System.Windows.Forms.Label OperandLabel;
        private System.Windows.Forms.Label NumTwoLabel;
    }
}

