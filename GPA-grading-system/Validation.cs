using System;
using System.Collections.Generic;
using System.Text;

namespace GPA_grading_system
{
    public class Validation
    {
        public static bool NumInputValidation( string Input)
        {
            bool success = int.TryParse(Input, out _);
            if (success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool CourseInputValidation(string courseName)
        {
            if (courseName.Length > 3)
            {
                return false;
            }
            else
            {
                return true ;
            }
        }
    }
}
