namespace GradeBook.GradeBooks
{
    using Enums;
    public class RankedGradeBook : BaseGradeBook
    {
        public float score = 10;
        
        public RankedGradeBook(string name):base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public char GetLetterGrade (double averageGrade)
        {
            if (Students.Count < 5)

            float studentScore = (score / 100) * 100;
            if (studentScore >= 80)
            {
                return 'A';
            }
            else if  (studentScore < 80 && studentScore >= 60 )
            {
                return 'B';
            }
            else if (studentScore < 60 && studentScore >= 40)
            {
                return 'C';
            }
            else if (studentScore < 40 && studentScore >= 20 )
            {
                return 'D';
            }
            else
            {
                return 'F';
            }

        }
    }
}
