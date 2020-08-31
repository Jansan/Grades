using System.Collections.Generic;

namespace Grades
{
    internal class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            return new GradeStatistics();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        private List<float> grades;
    }
}