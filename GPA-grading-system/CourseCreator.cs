using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GPA_grading_system
{
    public static class CourseCreator
    {

        public static ArrayList CourseCreate(string course, string courseCode, int courseUnit, string courseGrade, int gradeUnit, int weightPoint, string remark)
        {
            var newCourse = new ArrayList(7);
            newCourse.AddRange(new ArrayList() { course, courseCode, courseUnit, courseGrade, gradeUnit, weightPoint, remark });
            return newCourse;
        } 
        public static List<ArrayList> CourseListCreate(ArrayList newCourse)
        {
            List<ArrayList> newCourseList = new List<ArrayList>();
            newCourseList.ForEach(course => newCourseList.Add(newCourse));
            return newCourseList;
        }
    }
}
