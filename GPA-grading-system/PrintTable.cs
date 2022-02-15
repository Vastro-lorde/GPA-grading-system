using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GPA_grading_system
{
    public class PrintTable
    {
        public static int tableWidth = 100;
       
        public static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        public static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += MakeTextCenter(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        public static string MakeTextCenter(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
        public void MakeDynamicTable( List<List<string>> savedCourses)
        {
            Console.Clear();
            Console.WriteLine("Spirit University GPA");
            PrintTable.PrintLine();
            PrintTable.PrintRow("COURSE & CODE", "COURSE UNIT", "GRADE", "GRADE-UNIT", "WEIGHT Pt.", "REMARK");
            PrintTable.PrintLine();
            foreach (var course in savedCourses)
            {
                PrintTable.PrintRow(course[0], course[1], course[2], course[3], course[4], course[5]);
            }
            PrintTable.PrintLine();
        }
    }
}
