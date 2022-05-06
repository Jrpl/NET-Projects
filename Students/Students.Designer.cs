
namespace Students
{
    partial class StudentsForm
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
            this.StudentGroupBox = new System.Windows.Forms.GroupBox();
            this.StudentDobLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.StudentIdLabel = new System.Windows.Forms.Label();
            this.StudentDeleteButton = new System.Windows.Forms.Button();
            this.StudentAddButton = new System.Windows.Forms.Button();
            this.StudentDobTextBox = new System.Windows.Forms.TextBox();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.OperationsGroupBox = new System.Windows.Forms.GroupBox();
            this.TopPercentTextBox = new System.Windows.Forms.TextBox();
            this.TopPercentButton = new System.Windows.Forms.Button();
            this.TopStudentButton = new System.Windows.Forms.Button();
            this.BottomStudentButton = new System.Windows.Forms.Button();
            this.StudentDataGroupBox = new System.Windows.Forms.GroupBox();
            this.GradeTextBox = new System.Windows.Forms.TextBox();
            this.AddGradeButton = new System.Windows.Forms.Button();
            this.StudentDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StudentDropDownLabel = new System.Windows.Forms.Label();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.StudentGroupBox.SuspendLayout();
            this.OperationsGroupBox.SuspendLayout();
            this.StudentDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentGroupBox
            // 
            this.StudentGroupBox.Controls.Add(this.StudentDobLabel);
            this.StudentGroupBox.Controls.Add(this.StudentNameLabel);
            this.StudentGroupBox.Controls.Add(this.StudentIdLabel);
            this.StudentGroupBox.Controls.Add(this.StudentDeleteButton);
            this.StudentGroupBox.Controls.Add(this.StudentAddButton);
            this.StudentGroupBox.Controls.Add(this.StudentDobTextBox);
            this.StudentGroupBox.Controls.Add(this.StudentNameTextBox);
            this.StudentGroupBox.Controls.Add(this.StudentIdTextBox);
            this.StudentGroupBox.Location = new System.Drawing.Point(13, 13);
            this.StudentGroupBox.Name = "StudentGroupBox";
            this.StudentGroupBox.Size = new System.Drawing.Size(172, 158);
            this.StudentGroupBox.TabIndex = 0;
            this.StudentGroupBox.TabStop = false;
            this.StudentGroupBox.Text = "Student";
            // 
            // StudentDobLabel
            // 
            this.StudentDobLabel.AutoSize = true;
            this.StudentDobLabel.Location = new System.Drawing.Point(6, 90);
            this.StudentDobLabel.Name = "StudentDobLabel";
            this.StudentDobLabel.Size = new System.Drawing.Size(31, 15);
            this.StudentDobLabel.TabIndex = 7;
            this.StudentDobLabel.Text = "DOB";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(6, 61);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(39, 15);
            this.StudentNameLabel.TabIndex = 6;
            this.StudentNameLabel.Text = "Name";
            // 
            // StudentIdLabel
            // 
            this.StudentIdLabel.AutoSize = true;
            this.StudentIdLabel.Location = new System.Drawing.Point(6, 31);
            this.StudentIdLabel.Name = "StudentIdLabel";
            this.StudentIdLabel.Size = new System.Drawing.Size(18, 15);
            this.StudentIdLabel.TabIndex = 5;
            this.StudentIdLabel.Text = "ID";
            // 
            // StudentDeleteButton
            // 
            this.StudentDeleteButton.Location = new System.Drawing.Point(87, 122);
            this.StudentDeleteButton.Name = "StudentDeleteButton";
            this.StudentDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.StudentDeleteButton.TabIndex = 4;
            this.StudentDeleteButton.Text = "Delete";
            this.StudentDeleteButton.UseVisualStyleBackColor = true;
            this.StudentDeleteButton.Click += new System.EventHandler(this.StudentDeleteButton_Click);
            // 
            // StudentAddButton
            // 
            this.StudentAddButton.Location = new System.Drawing.Point(6, 122);
            this.StudentAddButton.Name = "StudentAddButton";
            this.StudentAddButton.Size = new System.Drawing.Size(75, 23);
            this.StudentAddButton.TabIndex = 3;
            this.StudentAddButton.Text = "Add";
            this.StudentAddButton.UseVisualStyleBackColor = true;
            this.StudentAddButton.Click += new System.EventHandler(this.StudentAddButton_Click);
            // 
            // StudentDobTextBox
            // 
            this.StudentDobTextBox.Location = new System.Drawing.Point(62, 82);
            this.StudentDobTextBox.Name = "StudentDobTextBox";
            this.StudentDobTextBox.Size = new System.Drawing.Size(100, 23);
            this.StudentDobTextBox.TabIndex = 2;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(62, 53);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.StudentNameTextBox.TabIndex = 1;
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Location = new System.Drawing.Point(62, 24);
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.StudentIdTextBox.TabIndex = 0;
            // 
            // OperationsGroupBox
            // 
            this.OperationsGroupBox.Controls.Add(this.TopPercentTextBox);
            this.OperationsGroupBox.Controls.Add(this.TopPercentButton);
            this.OperationsGroupBox.Controls.Add(this.TopStudentButton);
            this.OperationsGroupBox.Controls.Add(this.BottomStudentButton);
            this.OperationsGroupBox.Location = new System.Drawing.Point(13, 177);
            this.OperationsGroupBox.Name = "OperationsGroupBox";
            this.OperationsGroupBox.Size = new System.Drawing.Size(172, 158);
            this.OperationsGroupBox.TabIndex = 1;
            this.OperationsGroupBox.TabStop = false;
            this.OperationsGroupBox.Text = "Operations";
            // 
            // TopPercentTextBox
            // 
            this.TopPercentTextBox.Location = new System.Drawing.Point(30, 128);
            this.TopPercentTextBox.Name = "TopPercentTextBox";
            this.TopPercentTextBox.PlaceholderText = "N%";
            this.TopPercentTextBox.Size = new System.Drawing.Size(110, 23);
            this.TopPercentTextBox.TabIndex = 3;
            this.TopPercentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopPercentButton
            // 
            this.TopPercentButton.Location = new System.Drawing.Point(30, 99);
            this.TopPercentButton.Name = "TopPercentButton";
            this.TopPercentButton.Size = new System.Drawing.Size(110, 23);
            this.TopPercentButton.TabIndex = 2;
            this.TopPercentButton.Text = "Top N% Students";
            this.TopPercentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TopPercentButton.UseVisualStyleBackColor = true;
            this.TopPercentButton.Click += new System.EventHandler(this.TopPercentButton_Click);
            // 
            // TopStudentButton
            // 
            this.TopStudentButton.Location = new System.Drawing.Point(30, 22);
            this.TopStudentButton.Name = "TopStudentButton";
            this.TopStudentButton.Size = new System.Drawing.Size(110, 23);
            this.TopStudentButton.TabIndex = 1;
            this.TopStudentButton.Text = "Top Student";
            this.TopStudentButton.UseVisualStyleBackColor = true;
            this.TopStudentButton.Click += new System.EventHandler(this.TopStudentButton_Click);
            // 
            // BottomStudentButton
            // 
            this.BottomStudentButton.Location = new System.Drawing.Point(30, 51);
            this.BottomStudentButton.Name = "BottomStudentButton";
            this.BottomStudentButton.Size = new System.Drawing.Size(110, 23);
            this.BottomStudentButton.TabIndex = 0;
            this.BottomStudentButton.Text = "Bottom Student";
            this.BottomStudentButton.UseVisualStyleBackColor = true;
            this.BottomStudentButton.Click += new System.EventHandler(this.BottomStudentButton_Click);
            // 
            // StudentDataGroupBox
            // 
            this.StudentDataGroupBox.Controls.Add(this.GradeTextBox);
            this.StudentDataGroupBox.Controls.Add(this.AddGradeButton);
            this.StudentDataGroupBox.Controls.Add(this.StudentDataRichTextBox);
            this.StudentDataGroupBox.Controls.Add(this.StudentDropDownLabel);
            this.StudentDataGroupBox.Controls.Add(this.StudentComboBox);
            this.StudentDataGroupBox.Location = new System.Drawing.Point(191, 13);
            this.StudentDataGroupBox.Name = "StudentDataGroupBox";
            this.StudentDataGroupBox.Size = new System.Drawing.Size(197, 322);
            this.StudentDataGroupBox.TabIndex = 2;
            this.StudentDataGroupBox.TabStop = false;
            this.StudentDataGroupBox.Text = "Student Data";
            // 
            // GradeTextBox
            // 
            this.GradeTextBox.Location = new System.Drawing.Point(10, 292);
            this.GradeTextBox.Name = "GradeTextBox";
            this.GradeTextBox.Size = new System.Drawing.Size(100, 23);
            this.GradeTextBox.TabIndex = 4;
            // 
            // AddGradeButton
            // 
            this.AddGradeButton.Location = new System.Drawing.Point(116, 292);
            this.AddGradeButton.Name = "AddGradeButton";
            this.AddGradeButton.Size = new System.Drawing.Size(75, 23);
            this.AddGradeButton.TabIndex = 3;
            this.AddGradeButton.Text = "Add Grade";
            this.AddGradeButton.UseVisualStyleBackColor = true;
            this.AddGradeButton.Click += new System.EventHandler(this.AddGradeButton_Click);
            // 
            // StudentDataRichTextBox
            // 
            this.StudentDataRichTextBox.Location = new System.Drawing.Point(6, 53);
            this.StudentDataRichTextBox.Name = "StudentDataRichTextBox";
            this.StudentDataRichTextBox.ReadOnly = true;
            this.StudentDataRichTextBox.Size = new System.Drawing.Size(185, 233);
            this.StudentDataRichTextBox.TabIndex = 2;
            this.StudentDataRichTextBox.Text = "";
            // 
            // StudentDropDownLabel
            // 
            this.StudentDropDownLabel.AutoSize = true;
            this.StudentDropDownLabel.Location = new System.Drawing.Point(6, 31);
            this.StudentDropDownLabel.Name = "StudentDropDownLabel";
            this.StudentDropDownLabel.Size = new System.Drawing.Size(48, 15);
            this.StudentDropDownLabel.TabIndex = 1;
            this.StudentDropDownLabel.Text = "Student";
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(60, 24);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(131, 23);
            this.StudentComboBox.TabIndex = 0;
            this.StudentComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentComboBox_SelectedIndexChanged);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 342);
            this.Controls.Add(this.StudentDataGroupBox);
            this.Controls.Add(this.OperationsGroupBox);
            this.Controls.Add(this.StudentGroupBox);
            this.Name = "StudentsForm";
            this.Text = "Students";
            this.StudentGroupBox.ResumeLayout(false);
            this.StudentGroupBox.PerformLayout();
            this.OperationsGroupBox.ResumeLayout(false);
            this.OperationsGroupBox.PerformLayout();
            this.StudentDataGroupBox.ResumeLayout(false);
            this.StudentDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StudentGroupBox;
        private System.Windows.Forms.Label StudentDobLabel;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label StudentIdLabel;
        private System.Windows.Forms.Button StudentDeleteButton;
        private System.Windows.Forms.Button StudentAddButton;
        private System.Windows.Forms.TextBox StudentDobTextBox;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.TextBox StudentIdTextBox;
        private System.Windows.Forms.GroupBox OperationsGroupBox;
        private System.Windows.Forms.GroupBox StudentDataGroupBox;
        private System.Windows.Forms.Label StudentDropDownLabel;
        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.RichTextBox StudentDataRichTextBox;
        private System.Windows.Forms.TextBox TopPercentTextBox;
        private System.Windows.Forms.Button TopPercentButton;
        private System.Windows.Forms.Button TopStudentButton;
        private System.Windows.Forms.Button BottomStudentButton;
        private System.Windows.Forms.TextBox AddGradeTextBox;
        private System.Windows.Forms.Button AddGradeButton;
        private System.Windows.Forms.TextBox GradeTextBox;
    }
}

