using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("First Grade");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.AddGrade(56.7);

            var stats = book.GetStatistics();

            Console.WriteLine($"Sum is {stats.Sum}");
            Console.WriteLine($"Average is {stats.Average:N2}");
            Console.WriteLine($"High grade is {stats.High}");
            Console.WriteLine($"Low grade is {stats.Low}");
        }
    }
}
