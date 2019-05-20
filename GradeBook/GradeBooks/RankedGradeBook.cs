using System;
using System.Collections.Generic;
using System.Linq;


namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        // constructor
        public RankedGradeBook(string name) : base(name)
        {
            this.Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked requires at minimum 5 students");
            }

            var gradeLevel = Convert.ToInt32(Math.Ceiling(Students.Count * 0.2));

            var grades = Students.OrderByDescending(g => g.AverageGrade).Select(g => g.AverageGrade).ToList();

            if (grades[gradeLevel - 1] <= averageGrade)
            {
                return 'A';
            }
            else if (grades[(gradeLevel * 2) - 1] <= averageGrade)
            {
                return 'B';
            }
            else if (grades[(gradeLevel * 3) - 1] <= averageGrade)
            {
                return 'C';
            }
            else if (grades[(gradeLevel * 4) - 1] <= averageGrade)
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
