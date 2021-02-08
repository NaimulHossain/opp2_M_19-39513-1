using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_system
{
    class Program
    {
        static void Main(string[] args)
        {
            double Physics = 80;
            double Chemistry = 85;
            double Biology = 90;
            double Mathematics = 80;
            double Computer = 90;

            double percentage = (Physics + Chemistry + Biology + Mathematics + Computer) / 5;
            Console.WriteLine("Percentage = " + percentage);

            if (percentage >= 90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (percentage >= 85 && percentage < 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 80 && percentage < 85)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (percentage >= 75 && percentage < 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 50 && percentage < 75)
            {
                Console.WriteLine("Grade: C+");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            Console.WriteLine("");
        }
    }
}