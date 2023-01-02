using System;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter employee id ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee salary");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employe emp = new Employe(id, name, salary);
            emp.displayDetais();
            emp.CalculateSalary();
            Console.ReadKey();
        }
    }
 }
    

