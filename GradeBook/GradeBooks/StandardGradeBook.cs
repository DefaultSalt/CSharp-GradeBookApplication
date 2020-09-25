namespace GradeBook.GradeBooks
{
    using Enums;
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name):base(name)
        {
            GradeBookType Type = GradeBookType.Standard;
        }
    }
}
