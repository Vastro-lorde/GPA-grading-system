using System;
using System.Collections.Generic;
using System.Text;

namespace GPA_grading_system
{
    internal class Calculate
    {
        public static (char, int, int) ScoreGradeUnitWeight(int score, int courseUnit)
        {
            char courseGrade = ' ';
            int gradeUnit = 0;
            int weightPoint = courseUnit * gradeUnit;
            if (score >= 70 && score <= 100)
            {
                courseGrade = 'A';
                gradeUnit = 5;
            }
            else if (score >= 60 && score <= 69)
            {
                courseGrade = 'B';
                gradeUnit = 4;
            }
            else if (score >= 50 && score <= 59)
            {
                courseGrade = 'C';
                gradeUnit = 3;
            }
            else if (score >= 45 && score <= 49)
            {
                courseGrade = 'D';
                gradeUnit= 2;
            }
            else if (score >= 40 && score <= 44)
            {
                courseGrade = 'E';
                gradeUnit = 1;
            }
            else if (score >= 0 && score <= 39)
            {
                courseGrade = 'F';
                gradeUnit = 0;
            }



            return (courseGrade, gradeUnit, weightPoint);
        }
    }
}
