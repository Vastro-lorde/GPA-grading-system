using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GPA_grading_system
{
    public class CourseCreator
    {
        public static List<List<string>> NewCourseList { get; set; } = new List<List<string>>();

        public List<string> CourseCreate(string course, int courseUnit, char courseGrade, int gradeUnit, int weightPoint, string remark)
        {
            var newCourse = new List<string>(6);
            newCourse.AddRange(new List<string>() { course.ToString(), courseUnit.ToString(), courseGrade.ToString(), gradeUnit.ToString(), weightPoint.ToString(), remark.ToString() });
            Console.WriteLine("created course");
            return newCourse;
        } 
        public List<List<string>> CourseListCreate(List<string> newCourse)
        {
            NewCourseList.Add(newCourse);
            Console.WriteLine("created course list");
            return NewCourseList;
        }
    }
}
