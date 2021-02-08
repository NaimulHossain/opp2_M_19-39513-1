using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastlabtask3
{
    class Program
    {static void Main(string[] args)
        {
            Student s1 = new Student("NAIMUL","19-39513-1");
            s1.Department = "CSE";
            s1.Cgpa = 3.64f;
            s1.showInfo();

            Triangle t1 = new Triangle(5, 6, 7);
            t1.showInfo();
            t1.TestTriangle();

            Account a1 = new Account("NAIMUL", "12345678", 50000);

            Course c1 = new Course("OOP2","123",3);
            c1.ShowCourseInfo();

        }
    }

}
