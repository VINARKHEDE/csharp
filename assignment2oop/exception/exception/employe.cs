using System;
using System.Collections.Generic;
using System.Text;

namespace exception
{
    class Employe
    {
        private int EmpNo;
        private string empName;
        private double salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;
        public int EMPNO
        {
            get { return EmpNo; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new Exception("employee number cannot be negative");
                    }
                    this.EmpNo = value;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);

                }
            }
        }
        public string EMPNAME
        {
            get { return empName; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("Employee name cannot be zero");
                    }
                    this.empName = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);

                }
            }
        }
        public double SALARY
        {
            get { return salary; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new Exception("salary cannot be zero");
                    }
                    this.salary = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);

                }
            }
        }
        public double GROSSSALARY
        {
            get { return GrossSalary; }
            set
            {


                if (SALARY < 5000)
                {
                    HRA = (SALARY * 10) / 100;
                    TA = (SALARY * 5) / 100;
                    DA = (SALARY * 15) / 100;
                    GrossSalary = SALARY + HRA + TA + DA;
                }

                else if (SALARY < 10000)
                {
                    HRA = (SALARY * 15) / 100;
                    TA = (SALARY * 10) / 100;
                    DA = (SALARY * 20) / 100;
                    GrossSalary = SALARY + HRA + TA + DA;
                }
                else if (SALARY < 15000)
                {
                    HRA = (SALARY * 20) / 100;
                    TA = (SALARY * 15) / 100;
                    DA = (SALARY * 25) / 100;
                    GrossSalary = SALARY + HRA + TA + DA;
                }
                else if (SALARY < 20000)
                {
                    HRA = (SALARY * 25) / 100;
                    TA = (SALARY * 20) / 100;
                    DA = (SALARY * 30) / 100;
                    GrossSalary = SALARY + HRA + TA + DA;
                }
                else if (SALARY >= 20000)
                {
                    HRA = (SALARY * 30) / 100;
                    TA = (SALARY * 25) / 100;
                    DA = (SALARY * 30) / 100;
                    GrossSalary = SALARY + HRA + TA + DA;
                }
            }
        }
        public Employe(int empid, string ename, double salary)
        {
            this.EMPNO = empid;
            this.EMPNAME = ename;
            this.SALARY = salary;
            this.GROSSSALARY = GROSSSALARY;
        }
        public void CalculateSalary()
        {
            Console.WriteLine(GROSSSALARY);
            PF = (GROSSSALARY * 10) / 100;
            TDS = (GROSSSALARY * 18) / 100;
            NetSalary = GROSSSALARY - (PF + TDS);
            Console.WriteLine("The netsalary is " + NetSalary);

        }
        public void displayDetais()
        {
            Console.WriteLine($"Employee No: {EMPNO}");
            Console.WriteLine($"Employee Name: {EMPNAME}");
            Console.WriteLine($"Employee Salary: Rs.{SALARY}");
            Console.WriteLine($"Gross Salary: Rs.{GROSSSALARY}");
        }
    }
}
	

