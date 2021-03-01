using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask6
{
    

          class Program
    {
        static void Main(string[] args)
        {
      
            Student stu1 = new Student("19-39537-1", "NAIMUL", 3.621F);
            Student stu2 = new Student("19-39537-2", "ARAF", 3.64F);
            Student stu3 = new Student("19-39537-3", "HOSSAIN", 3.5F);

 

            Department dept1 = new Department("CS", "Computer Science");
            Department dept2 = new Department("EE","Electronic Engineering");

 

            stu1.Dept = dept1;
            stu2.Dept = dept2;
            stu3.Dept = dept2;

 

            stu1.ShowInfo();
            stu1.ShowDepartment();

 

            stu2.ShowInfo();
            stu2.ShowDepartment();

 

            stu3.ShowInfo();
            stu3.ShowDepartment();

 

          
            dept1.Name = "Computer Science and Engineering";

 

            stu1.ShowInfo();
            stu1.ShowDepartment();

 


            dept1.AddStudent(stu1);
            dept1.AddStudent(stu2);

 

            dept1.PrintStudent();
        }
    }
}













