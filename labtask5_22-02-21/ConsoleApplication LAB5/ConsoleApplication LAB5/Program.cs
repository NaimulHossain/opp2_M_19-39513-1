using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("NAIMUL", "1234", 500000);
            a1.ShowInfo();
            a1.deposit(2000);
            a1.withdraw(5000);
            a1.Transfer(200, a1);
            Console.WriteLine("............");
            Account a2 = new Account("HOSSAIN", "5678", 50000);
            a2.ShowInfo();
            a1.deposit(2000);
            a1.withdraw(5000);
            a2.Transfer(200, a1);
            Console.WriteLine(".........");
            savings s1 = new savings("KING", "1414", 13000);
            s1.ShowInfo();
            s1.withdraw(500);
            Console.WriteLine(".........");
            Special_current s2 = new Special_current("Shan", "2882", 15500);
            s2.ShowInfo();
            s2.withdraw(3000);
            Console.WriteLine(".........");
            Fixed f1 = new Fixed("Famim", "4444", 100000);
            f1.ShowInfo();
            f1.withdraw(3000);
            Console.WriteLine();
            Console.WriteLine(".......");
            Overdraft o = new Overdraft("omi", "3333", 100000);
            o.ShowInfo();
            o.withdraw(200);
            Console.WriteLine();

        }
    }
}

