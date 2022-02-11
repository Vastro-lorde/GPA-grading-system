using System;
using System.Collections.Generic;
using System.Text;

namespace GPA_grading_system
{
    public class PrintTable
    {
        static int tableWidth = 50;
        public static void StartTable()
        {
            Console.Clear();
            PrintTable.PrintLine();
            PrintTable.PrintRow("COURSE & CODE", "Column 2", "Column 3", "Column 4", "Column 5", "Column 6");
            PrintTable.PrintLine();
            PrintTable.PrintRow("", "", "", "", "");
            PrintTable.PrintRow("", "", "", "", "");
            PrintTable.PrintLine();
            Console.ReadLine();
        }
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
    }
}
