using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class Employee
    {
        int _EmpCode;
        string _EmpName;
        float _EmpSalary;

        public Employee()
        {
            Console.WriteLine("Default Constructor Call");
            this._EmpSalary = 75000;
        }

        public Employee(int _EmpCode, string _EmpName, float _EmpSalary)
        {
            this._EmpCode = _EmpCode;
            this._EmpName = _EmpName;
            this._EmpSalary = _EmpSalary;
            Console.WriteLine("Parametric Constructor - 1");
        }

        public Employee(int _EmpCode, float _EmpSalary )
        {
            this._EmpCode = _EmpCode;
            this._EmpSalary = _EmpSalary;
            Console.WriteLine("Parametric Constructor - 2");
        }
            
        static Employee() //static constructor
        {
            Console.WriteLine("Static Constructor Call");  
        }

        ~Employee() //Destructor
        {
            Console.WriteLine("Object Removed");
        }


        public void SetEmployeeDetails(int _EmpCode,string _EmpName,float _EmpSalary)
        {
            this._EmpCode = _EmpCode;
            this._EmpName = _EmpName;
            this._EmpSalary = _EmpSalary;

            Console.WriteLine("Details Saved..!!!");
        }
        public void DisplayEmployeeDetails() 
        {
            Console.WriteLine("Employee Details is: ");
            Console.WriteLine($"Code : {_EmpCode},Name: {_EmpName},Salary: {_EmpSalary}");
        }
    }
}
