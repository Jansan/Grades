using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(85);
            book.AddGrade(89.5f);

            GradeStatistics stats = book.ComputeStatistics();
            

            GradeBook book2 = book;
            book2.AddGrade(75);
            
        }
    }
}
