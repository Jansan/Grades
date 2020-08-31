using System.Collections.Generic;

namespace Grades
{
    internal class GradeBook
    {
        public GradeBook()
        {
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades;
    }
}