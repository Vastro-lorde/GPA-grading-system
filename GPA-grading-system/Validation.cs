using System;
using System.Collections.Generic;
using System.Text;

namespace GPA_grading_system
{
    public class Validation
    {
        public static bool inputValidation(string Input)
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
    }
}
