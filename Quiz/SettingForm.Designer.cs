
namespace Quiz
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumQuestionsLabel = new System.Windows.Forms.Label();
            this.MinNumLabel = new System.Windows.Forms.Label();
            this.MaxNumLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.OperationsLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OperationsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.MaxNumTextBox = new System.Windows.Forms.TextBox();
            this.MinNumTextBox = new System.Windows.Forms.TextBox();
            this.NumQuestionsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumQuestionsLabel
            // 
            this.NumQuestionsLabel.AutoSize = true;
            this.NumQuestionsLabel.Location = new System.Drawing.Point(13, 16);
            this.NumQuestionsLabel.Name = "NumQuestionsLabel";
            this.NumQuestionsLabel.Size = new System.Drawing.Size(84, 15);
            this.NumQuestionsLabel.TabIndex = 0;
            this.NumQuestionsLabel.Text = "# of Questions";
            // 
            // MinNumLabel
            // 
            this.MinNumLabel.AutoSize = true;
            this.MinNumLabel.Location = new System.Drawing.Point(13, 45);
            this.MinNumLabel.Name = "MinNumLabel";
            this.MinNumLabel.Size = new System.Drawing.Size(70, 15);
            this.MinNumLabel.TabIndex = 1;
            this.MinNumLabel.Text = "Minimum #";
            // 
            // MaxNumLabel
            // 
            this.MaxNumLabel.AutoSize = true;
            this.MaxNumLabel.Location = new System.Drawing.Point(13, 74);
            this.MaxNumLabel.Name = "MaxNumLabel";
            this.MaxNumLabel.Size = new System.Drawing.Size(72, 15);
            this.MaxNumLabel.TabIndex = 2;
            this.MaxNumLabel.Text = "Maximum #";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(13, 103);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(33, 15);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "Time";
            // 
            // OperationsLabel
            // 
            this.OperationsLabel.AutoSize = true;
            this.OperationsLabel.Location = new System.Drawing.Point(13, 130);
            this.OperationsLabel.Name = "OperationsLabel";
            this.OperationsLabel.Size = new System.Drawing.Size(65, 15);
            this.OperationsLabel.TabIndex = 4;
            this.OperationsLabel.Text = "Operations";
            // 
            // SaveButton
            // 
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(22, 163);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(22, 201);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // OperationsCheckedListBox
            // 
            this.OperationsCheckedListBox.CheckOnClick = true;
            this.OperationsCheckedListBox.FormattingEnabled = true;
            this.OperationsCheckedListBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.OperationsCheckedListBox.Location = new System.Drawing.Point(121, 130);
            this.OperationsCheckedListBox.Name = "OperationsCheckedListBox";
            this.OperationsCheckedListBox.Size = new System.Drawing.Size(121, 94);
            this.OperationsCheckedListBox.TabIndex = 7;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(121, 100);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.PlaceholderText = "15";
            this.TimeTextBox.Size = new System.Drawing.Size(121, 23);
            this.TimeTextBox.TabIndex = 8;
            this.TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaxNumTextBox
            // 
            this.MaxNumTextBox.Location = new System.Drawing.Point(121, 71);
            this.MaxNumTextBox.Name = "MaxNumTextBox";
            this.MaxNumTextBox.PlaceholderText = "12";
            this.MaxNumTextBox.Size = new System.Drawing.Size(121, 23);
            this.MaxNumTextBox.TabIndex = 9;
            this.MaxNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinNumTextBox
            // 
            this.MinNumTextBox.Location = new System.Drawing.Point(121, 42);
            this.MinNumTextBox.Name = "MinNumTextBox";
            this.MinNumTextBox.PlaceholderText = "2";
            this.MinNumTextBox.Size = new System.Drawing.Size(121, 23);
            this.MinNumTextBox.TabIndex = 10;
            this.MinNumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumQuestionsTextBox
            // 
            this.NumQuestionsTextBox.Location = new System.Drawing.Point(121, 13);
            this.NumQuestionsTextBox.Name = "NumQuestionsTextBox";
            this.NumQuestionsTextBox.PlaceholderText = "10";
            this.NumQuestionsTextBox.Size = new System.Drawing.Size(121, 23);
            this.NumQuestionsTextBox.TabIndex = 11;
            this.NumQuestionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 236);
            this.Controls.Add(this.NumQuestionsTextBox);
            this.Controls.Add(this.MinNumTextBox);
            this.Controls.Add(this.MaxNumTextBox);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.OperationsCheckedListBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OperationsLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.MaxNumLabel);
            this.Controls.Add(this.MinNumLabel);
            this.Controls.Add(this.NumQuestionsLabel);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumQuestionsLabel;
        private System.Windows.Forms.Label MinNumLabel;
        private System.Windows.Forms.Label MaxNumLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label OperationsLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.CheckedListBox OperationsCheckedListBox;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.TextBox MaxNumTextBox;
        private System.Windows.Forms.TextBox MinNumTextBox;
        private System.Windows.Forms.TextBox NumQuestionsTextBox;
    }
}