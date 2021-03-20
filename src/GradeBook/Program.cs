using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("First Grade");
            var count = 1;
            while (true)
            {
                Console.WriteLine($"Please enter grade number {count} (Q to Quit):");
                var input = Console.ReadLine();
                if (input.ToUpper() == "Q" || input == "")
                {
                    break;
                }

                try{
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                    count++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            var stats = book.GetStatistics();

            Console.WriteLine($"The sum total is {stats.Sum}");
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
