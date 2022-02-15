using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GPA_grading_system
{
    public class GPArun
    {   
        CourseCreator creator = new CourseCreator();
        PrintTable table = new PrintTable();
                    public static string course = string.Empty;
                    public static string courseCode = string.Empty;
                    public static string courseUnit = string.Empty;
                    public static string courseScore = string.Empty;
                    public static char courseGrade = char.MinValue;
                    public static int gradeUnit = 0;
                    public static int weightPoint = 0;
                    public static string remark = string.Empty;
                    public List<List<string>> savedCourses = new List<List<string>>();
        public void StartTable()
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
            if (addCourse == "y" || addCourse == "Y")
            {
                bool inputing = true;
                /*List< List<string>> savedCourses = null;*/
                while (inputing)
                {
                    
                    
                    Console.WriteLine("Enter the abbrevated course name : ");
                    course = Console.ReadLine();
                    if (Validation.CourseInputValidation(course) && !int.TryParse(course, out _))
                    {
                        course = course.ToUpper();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please input a valid coures name");
                        continue;
                    }

                    Console.WriteLine("Enter the 3 digit course code : ");
                    courseCode = Console.ReadLine();
                    if (Validation.NumInputValidation(courseCode) && Validation.CourseInputValidation(courseCode) && Convert.ToInt32(courseCode) >= 100 && Convert.ToInt32(courseCode) <= 999)
                    {
                        courseCode = course + courseCode;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please input a valid coures code ranging from 100-999");
                        continue;
                    }

                    Console.WriteLine("Enter the course unit which ranges from 1 - 5");
                    courseUnit = Console.ReadLine();
                    if (Validation.NumInputValidation(courseUnit) && Convert.ToInt32(courseUnit) <= 5 && Convert.ToInt32(courseUnit) >= 1)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please input a valid coures unit");
                        continue;
                    }
                    Console.WriteLine("Enter the score");
                    courseScore = Console.ReadLine();
                    if (Validation.NumInputValidation(courseScore) && Convert.ToInt32(courseScore) <= 100)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please input a valid coures name");
                        continue;
                    }
                    /*function to create the arraylist should be here*/
                    (courseGrade, gradeUnit, weightPoint, remark) = Calculate.ScoreGradeUnitWeight(Convert.ToInt32(courseScore), Convert.ToInt32(courseUnit));

                    var saveCourse = creator.CourseCreate(course, Convert.ToInt32(courseUnit), courseGrade, gradeUnit, weightPoint, remark);
                    savedCourses =creator.CourseListCreate(saveCourse);
                   
                    Console.WriteLine("Enter \"Y\" if you which to add another course else type \"N\"");
                    var addMoreCourse = Console.ReadLine();
                    if (addMoreCourse == "y" || addMoreCourse == "Y")
                    {
                        continue;
                    }
                    else 
                    {
                        Console.WriteLine(savedCourses.Count);
                        table.MakeDynamicTable(savedCourses);
                        break; 
                    }
                }
                
                

            }
            else
            {
                StartTable();
            }

        }
    }
}
