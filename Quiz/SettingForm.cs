
namespace Quiz
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class SettingForm : Form
    {
        public QuizSettings Settings = new QuizSettings() { Operands = new List<char>() };

        public SettingForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Parse text boxes
            int.TryParse(this.NumQuestionsTextBox.Text, out int tempNumQues);
            int.TryParse(this.MaxNumTextBox.Text, out int tempMaxNum);
            int.TryParse(this.MinNumTextBox.Text, out int tempMinNum);
            int.TryParse(this.TimeTextBox.Text, out int tempTime);

            // Validation
            if (tempNumQues > 20 || tempNumQues < 5)
            {
                MessageBox.Show("Number of Questions must be between 5 and 20");
            }
            else
            {
                this.Settings.NumQuestions = tempNumQues;
            }

            if (tempMaxNum > 20 || tempMaxNum <= tempMinNum)
            {
                MessageBox.Show("Maximum number must be 20 or less and must be greater than the Minimum number");
            }
            else
            {
                this.Settings.MaxNum = tempMaxNum;
            }

            if (tempMinNum < 2 || tempMinNum >= tempMaxNum)
            {
                MessageBox.Show("Minimum number must be 2 or more and must be less than the Maximum number");
            }
            else
            {
                this.Settings.MinNum = tempMinNum;
            }

            this.Settings.Time = tempTime;

            // Add operands to list
            if (this.OperationsCheckedListBox.CheckedItems.Count != 0)
            {
                foreach (object itemChecked in this.OperationsCheckedListBox.CheckedItems)
                {
                    this.Settings.Operands.Add(Convert.ToChar(itemChecked));
                }
            }
            else
            {
                MessageBox.Show("Select at least 1 operation");
            }
        }
    }
}
