// Justin Pfeifler
// GUI Homework 5 - Quiz

namespace Quiz
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        double Answer;
        int FormTime;
        QuizData Data = new QuizData() { CurrentQuestion = 0, Questions = new List<Question>(), Results = new List<QuestionResults>() };
        QuizSettings Settings = new QuizSettings() { NumQuestions = 10, MaxNum = 12, MinNum = 2, Time = 15, Operands = new List<char>() { '+' }};

        public MainForm()
        {
            InitializeComponent();

            this.MenuStart.Click += StartButton_Click;
            this.MenuStop.Click += StopButton_Click;
            this.MenuResults.Click += ResultsButton_Click;
            this.MenuSettings.Click += SettingsButton_Click;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GenerateQuestions();
            DisplayNextQuestion();
            this.ScoreLabel.Text = this.Data.NumCorrect + " / " + this.Settings.NumQuestions;
            this.FormTime = this.Settings.Time;
            this.TimeLabel.Text = this.Settings.Time.ToString();
            this.timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.FormTime > 0)
            {
                this.FormTime--;
                this.TimeLabel.Text = FormTime.ToString();
            }
            else
            {
                // Time ran out, check answer and display next question
                if(CheckAnswer())
                {
                    this.Data.NumCorrect++;
                }
                this.Data.Results.Add(new QuestionResults(GetCurrentQuestion(), this.Answer, CheckAnswer()));
                this.Data.Score = Math.Round(Convert.ToDouble(this.Data.NumCorrect) / Convert.ToDouble(this.Settings.NumQuestions));
                this.ScoreLabel.Text = this.Data.NumCorrect + " / " + this.Settings.NumQuestions;
                if (this.Data.CurrentQuestion < this.Settings.NumQuestions - 1)
                {
                    this.Data.CurrentQuestion++;
                    this.DisplayNextQuestion();
                    this.FormTime = this.Settings.Time;
                }
                else
                {
                    this.Data.DisplayResults();
                    timer1.Stop();
                    this.TimeLabel.Text = "";
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.TimeLabel.Text = "";
            this.NumOneLabel.Text = "";
            this.OperandLabel.Text = "";
            this.NumTwoLabel.Text = "";
            this.ScoreLabel.Text = "";
            this.AnswerTextBox.Text = "";
            this.Data = new QuizData();
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.SetResults = Results;
            resultsForm.ShowDialog();
        }

        public string Results
        {
            get
            {
                var Builder = new StringBuilder();
                for (int i = 0; i < this.Data.ResultsStrings.Count; i++)
                {
                    Builder.Append($"{this.Data.ResultsStrings[i]}{Environment.NewLine}");
                }
                return Builder.ToString();
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settingForm = new SettingForm();
            var result = settingForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Settings = settingForm.Settings;
            }
        }

        private void GenerateQuestions()
        {
            for (int i = 0; i < this.Settings.NumQuestions; i++)
            {
                Random rnd = new Random();
                int Num1 = rnd.Next(this.Settings.MinNum, this.Settings.MaxNum + 1);
                int Num2 = rnd.Next(this.Settings.MinNum, this.Settings.MaxNum + 1);
                int OpNum = 0;
                if (this.Settings.Operands.Count > 1)
                {
                    OpNum = rnd.Next(0, this.Settings.Operands.Count);
                }
                this.Data.Questions.Add(new Question(Num1, this.Settings.Operands[OpNum], Num2));
            }
        }

        private Question GetCurrentQuestion()
        {
            int.TryParse(this.NumOneLabel.Text, out int Num1);
            char.TryParse(this.OperandLabel.Text, out char Operand);
            int.TryParse(this.NumTwoLabel.Text, out int Num2);

            return new Question(Num1, Operand, Num2);
        }

        private void DisplayNextQuestion()
        {
            this.NumOneLabel.Text = this.Data.Questions[this.Data.CurrentQuestion].Num1.ToString();
            this.OperandLabel.Text = this.Data.Questions[this.Data.CurrentQuestion].Operand.ToString();
            this.NumTwoLabel.Text = this.Data.Questions[this.Data.CurrentQuestion].Num2.ToString();
        }

        private bool CheckAnswer()
        {
            double.TryParse(this.AnswerTextBox.Text, out this.Answer);
            int.TryParse(this.NumOneLabel.Text, out int Num1);
            char.TryParse(this.OperandLabel.Text, out char Operand);
            int.TryParse(this.NumTwoLabel.Text, out int Num2);

            switch (Operand)
            {
                case '+':
                    return Num1 + Num2 == Answer;
                case '-':
                    return Num1 - Num2 == Answer;
                case '*':
                    return Num1 * Num2 == Answer;
                case '/':
                    return Math.Round(Convert.ToDouble(Num1) / Convert.ToDouble(Num2)) == Answer;
                default:
                    return false;
            }
        }
    }
}
