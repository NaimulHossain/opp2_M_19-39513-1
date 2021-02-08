using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace lab_task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;



            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "\n");
                }
            }
        }
    }
}