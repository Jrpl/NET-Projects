
namespace Quiz
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class QuizSettings : IEquatable<QuizSettings>
    {
        public int NumQuestions { get; set; }
        public int MinNum { get; set; }
        public int MaxNum { get; set; }
        public int Time { get; set; }
        public List<char> Operands;

        // Retrieved these overides from the official documentation
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            QuizSettings objAsQuizSettings = obj as QuizSettings;
            if (objAsQuizSettings == null) return false;
            else return Equals(objAsQuizSettings);
        }
        public override int GetHashCode()
        {
            int IntId = (int)this.NumQuestions;
            return IntId;
        }
        public bool Equals(QuizSettings other)
        {
            if (other == null) return false;
            return (this.NumQuestions.Equals(other.NumQuestions));
        }
    }

    public record Question (int Num1, char Operand, int Num2);
    public record QuestionResults(Question Question, double Answer, bool Correct);

    public class QuizData : IEquatable<QuizData>
    {
        public double Score { get; set; }
        public int NumCorrect { get; set; }
        public int CurrentQuestion { get; set; }
        public List<Question> Questions;
        public List<QuestionResults> Results;
        public List<string> ResultsStrings;

        public void DisplayResults()
        {
            this.ResultsStrings = new List<string>();

            foreach (QuestionResults result in Results)
            {
                 var Builder = new StringBuilder();
                 Builder.Append($"Question: {result.Question}{Environment.NewLine}");
                 Builder.Append($"Answer:   {result.Answer:F2}{Environment.NewLine}");
                 Builder.Append($"Correct:  {result.Correct:F2}{Environment.NewLine}");
                 this.ResultsStrings.Add(Builder.ToString());
            }
            this.ResultsStrings.Add($"Percent: {this.Score.ToString()}%");
        }

        // Retrieved these overides from the official documentation
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            QuizData objAsQuizData = obj as QuizData;
            if (objAsQuizData == null) return false;
            else return Equals(objAsQuizData);
        }
        public override int GetHashCode()
        {
            int IntId = (int)this.Score;
            return IntId;
        }
        public bool Equals(QuizData other)
        {
            if (other == null) return false;
            return (this.Score.Equals(other.Score));
        }
    }
}