using System;

namespace assignment2oop
{
   
        internal class Employee
        {
            int empId;//Access Specifier for empId is Private
                      //Create an Public property using get and set
            public int EMPID { get; set; }
            string empName;
            public string EMPNAME { get; set; }



            //To initialize the data members of an class 
            //this 
            public Employee(int empid, string ename)
            {
                this.EMPID = empid;
                this.EMPNAME = ename;
            }
            //Member fnctions
            public void DisplayEmpDetails()
            {
                Console.WriteLine("The Emp Id is " + EMPID + " The Emp Name is " + EMPNAME);
            }



        }
        }


