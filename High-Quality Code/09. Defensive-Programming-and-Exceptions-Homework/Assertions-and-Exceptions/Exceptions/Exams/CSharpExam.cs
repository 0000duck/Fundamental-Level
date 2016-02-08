using System;

namespace Exceptions_Homework.Exams
{
    public class CSharpExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("score", "The score cannot be negative.");
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, MinScore, MaxScore, "Exam results calculated by score.");
        }
    }
}