namespace GradeBook.GradeBooks
{
    using Enums;
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name):base(name)
        {
            GradeBookType Type = GradeBookType.Ranked;
        }
    }
}
