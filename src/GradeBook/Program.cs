using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
	        {	        
	        	Console.WriteLine($"Hello {args[0]}!");
	        }
	        catch (Exception)
	        {
                Console.WriteLine("Oops, got exception " + Exception);
	        }
        }
    }
}
