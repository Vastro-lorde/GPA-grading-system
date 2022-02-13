using System;
using System.Collections.Generic;
using System.Text;

namespace GPA_grading_system
{
    public static class GPArun
    {
        public static void StartTable()
        {
            Console.Clear();
            Console.WriteLine("Spirit University GPA");
            PrintTable.PrintLine();
            PrintTable.PrintRow("COURSE & CODE", "COURSE UNIT", "GRADE", "GRADE-UNIT", "WEIGHT Pt.", "REMARK");
            PrintTable.PrintLine();
            PrintTable.PrintRow("", "", "", "", "", "");
            PrintTable.PrintRow("", "", "", "", "", "");
            PrintTable.PrintLine();

            Console.WriteLine("To add a course type \"y\"");
            string addCourse = Console.ReadLine();
            if (addCourse == "y")
            {
                bool inputing = true;
                while (inputing)
                {
                    Console.WriteLine("Enter the abbrevated course name : ");
                    string course = Console.ReadLine();
                    Console.WriteLine("Enter the 3 digit course code : ");
                    string courseCode = Console.ReadLine();
                    Console.WriteLine("Enter the course unit which ranges from 1 - 5");
                    string courseUnit = Console.ReadLine();
                    Console.WriteLine("Enter the score");
                    string courseScore = Console.ReadLine();
                    Console.WriteLine("Enter \"Y\" if you which to add another course else type \"N\"");
                    var addMoreCourse = Console.ReadLine();
                    if (addMoreCourse == "y")
                    {
                        continue;
                    }
                    else { break; }
                }
                

            }
            else
            {
                StartTable();
            }

        }
        public static void takeInput()
        {

        }
    }
}
