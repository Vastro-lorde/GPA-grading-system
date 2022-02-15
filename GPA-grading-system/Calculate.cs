using System;
using System.Collections.Generic;
using System.Text;

namespace GPA_grading_system
{
    public class Calculate
    {
        public static (char, int, int, string) ScoreGradeUnitWeight(int score, int courseUnit)
        {
            char courseGrade = ' ';
            int gradeUnit = 0;
            
            string remark = "";
            if (score >= 70 && score <= 100)
            {
                courseGrade = 'A';
                gradeUnit = 5;
                remark = "Excellent";
            }
            else if (score >= 60 && score <= 69)
            {
                courseGrade = 'B';
                gradeUnit = 4;
                remark = "Very Good";
            }
            else if (score >= 50 && score <= 59)
            {
                courseGrade = 'C';
                gradeUnit = 3;
                remark = "Good";
            }
            else if (score >= 45 && score <= 49)
            {
                courseGrade = 'D';
                gradeUnit= 2;
                remark = "Fair";
            }
            else if (score >= 40 && score <= 44)
            {
                courseGrade = 'E';
                gradeUnit = 1;
                remark = "Pass";
            }
            else if (score >= 0 && score <= 39)
            {
                courseGrade = 'F';
                gradeUnit = 0;
                remark = "Fail";
            }
            int weightPoint = courseUnit * gradeUnit;


            return (courseGrade, gradeUnit, weightPoint, remark);
        }
    }
}
