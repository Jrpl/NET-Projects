
namespace Students
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class StudentsForm : Form
    {
        // Initialize list of students
        List<Student> Students = new List<Student>();

        // Properties to hold input values
        public long StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime StudentDob { get; set; }
        public Student SelectedStudent { get; set; }

        public StudentsForm()
        {
            this.InitializeComponent();
        }

        private void StudentAddButton_Click(object sender, EventArgs e)
        {
            // Check if Id is greater than 0
            int TempId;
            int.TryParse(this.StudentIdTextBox.Text, out TempId);
            if (TempId <= 0)
            {
                MessageBox.Show("Student ID must be greater than 0");
                this.StudentIdTextBox.Clear();
            }
            else
            {
                this.StudentId = Convert.ToInt64(TempId);
            }

            // Check if Name is 4 char or longer
            string TempName = this.StudentNameTextBox.Text;
            if (TempName.Length < 4)
            {
                MessageBox.Show("Student Name must be at least 4 characters in length");
                this.StudentNameTextBox.Clear();
            }
            else
            {
                this.StudentName = TempName;
            }

            // Check if DOB is before today
            // Not Working?
            DateTime TempDob = DateTime.Parse(this.StudentDobTextBox.Text);
            if (DateTime.Compare(TempDob, DateTime.Now) >= 0)
            {
                MessageBox.Show("Student DOB must be older than Today");
                this.StudentDobTextBox.Clear();
            }
            else
            {
                this.StudentDob = TempDob;
            }

            // Check student doesn't already exist
            if (this.Students.Contains(new Student { Id = this.StudentId }))
            {
                MessageBox.Show("Student already exists");
                this.StudentIdTextBox.Clear();
            }
            else
            {
                this.Students.Add(new Student() { Id = this.StudentId, Name = this.StudentName, Dob = this.StudentDob, Grades = new List<double>() });
                this.BindComboBox();
            }
        }

        private void StudentDeleteButton_Click(object sender, EventArgs e)
        {
            long TempId;
            long.TryParse(this.StudentIdTextBox.Text, out TempId);
            if (this.Students.Contains(new Student() { Id = TempId }))
            {
                var result = MessageBox.Show("Are you sure you want to delete this Student?", "Deleting Student", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Students.Remove(new Student() { Id = TempId });
                    this.StudentDataRichTextBox.Clear();
                    this.BindComboBox();
                }
                else
                {
                    this.StudentIdTextBox.Clear();
                    this.StudentNameTextBox.Clear();
                    this.StudentDobTextBox.Clear();
                }
            }
        }

        private void BindComboBox()
        {
            var bindingSource = new BindingSource(this.Students, null);
            this.StudentComboBox.DataSource = bindingSource;
            this.StudentComboBox.DisplayMember = "DisplayName";
        }

        private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Selected = this.StudentComboBox.GetItemText(this.StudentComboBox.SelectedItem);
            long SelectedId = Convert.ToInt64(Regex.Replace(Selected, "[^0-9.]", ""));
            
            foreach (Student student in this.Students)
            {
                if (student.Id == SelectedId)
                {
                    this.StudentDataRichTextBox.Text = student.ToString();
                    this.SelectedStudent = student;
                }
            }
        }

        private void AddGradeButton_Click(object sender, EventArgs e)
        {
            if (this.SelectedStudent == null)
            {
                MessageBox.Show("Select a Student before adding a grade");
            }

            double Grade;
            double.TryParse(this.GradeTextBox.Text, out Grade);
            Math.Round(Grade, 2);

            this.SelectedStudent.Grades.Add(Grade);
            this.BindComboBox();
        }

        private void TopStudentButton_Click(object sender, EventArgs e)
        {
            double Average = 0.0;
            Student TopStudent = new Student();

            foreach (Student student in this.Students)
            {
                if (student.Grades.Average() > Average)
                {
                    Average = student.Grades.Average();
                    TopStudent = student;
                }
            }

            TopStudent.Average = Average;

            this.StudentDataRichTextBox.Text = TopStudent.DisplayAverage;
        }

        private void BottomStudentButton_Click(object sender, EventArgs e)
        {
            double Average = 100.0;
            Student BottomStudent = new Student();

            foreach (Student student in this.Students)
            {
                if (student.Grades.Average() < Average)
                {
                    Average = student.Grades.Average();
                    BottomStudent = student;
                }
            }

            BottomStudent.Average = Average;

            this.StudentDataRichTextBox.Text = BottomStudent.DisplayAverage;
        }

        // NOT WORKING
        private void TopPercentButton_Click(object sender, EventArgs e)
        {
            List<Student> TopStudents = new List<Student>();
            int Percent = Convert.ToInt32(this.TopPercentTextBox.Text);
            if (Percent >= 1 || Percent <= 100)
            {
                MessageBox.Show("Please insert a value between 1 and 100");
            }
            int NumberOfStudents = this.Students.Count * (Percent / 100);
            
            foreach (Student student in this.Students)
            {
                student.Average = student.Grades.Average();
            }

            foreach (Student student in TopStudents)
            {
                this.StudentDataRichTextBox.Text += student.DisplayAverage;
            }
        }
    }

    // Create Student Class
    public class Student : IEquatable<Student>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public double Average { get; set; }
        public List<double> Grades;
        private string GradesString;

        public string DisplayName
        {
            get
            {
                return $"{this.Id} {this.Name}";
            }
        }

        public string DisplayAverage
        {
            get
            {
                var Builder = new StringBuilder();
                Builder.Append($"Student Id:     {this.Id}{Environment.NewLine}");
                Builder.Append($"Student Name:   {this.Name:F2}{Environment.NewLine}");
                Builder.Append($"Student DOB:    {this.Dob.ToShortDateString():F2}{Environment.NewLine}");
                GradeStringConstructor();
                Builder.Append($"Student Average: {this.Average:F2}");

                return Builder.ToString();
            }
        }

        private string GradeStringConstructor()
        {
            return this.GradesString = string.Join(" ", Grades);
        }

        public override string ToString()
        {
            var Builder = new StringBuilder();
            Builder.Append($"Student Id:     {this.Id}{Environment.NewLine}");
            Builder.Append($"Student Name:   {this.Name:F2}{Environment.NewLine}");
            Builder.Append($"Student DOB:    {this.Dob:F2}{Environment.NewLine}");
            GradeStringConstructor();
            Builder.Append($"Student Grades: {this.GradesString:F2}");

            return Builder.ToString();
        }

        // Retrieved these overides from the official documentation
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Student objAsStudent = obj as Student;
            if (objAsStudent == null) return false;
            else return Equals(objAsStudent);
        }
        public override int GetHashCode()
        {
            int IntId = (int)this.Id;
            return IntId;
        }
        public bool Equals(Student other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }
    }
}
