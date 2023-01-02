using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple C# Class !");
            //Create an Object of an Employee Class



            Employee emp = new Employee(100, "Rashmi");
            //emp.EMPID = 100;
            // emp.EMPNAME = "Rashmi";



            //How to access the Methods outside the class
            emp.DisplayEmpDetails();
            Console.ReadKey();



        }
    }
}
