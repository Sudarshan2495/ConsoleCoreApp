using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class MethodCalling
    {
        //Call by Value Behaviour Method
        public void CallByValue(int x, int y)
        {
            x = x + 20;
            y = y + 30;
            Console.WriteLine($"X is : {x} ,\tY is : {y}");
        }

        //Call by Reference Behaviour Method
        public void CallByReference( ref int x, ref int y)
        {
            x = x + 20;
            y = y + 30;
            Console.WriteLine($"X is : {x} ,\tY is : {y}");
        }

        public void CallByOutput(int x, int y, out int s, out int m, out int d)
        {
            s = x + y;
            m = x * y;
            d = x / y;            
        }

        //Method for call by Named/Optional arguments
        public void CallByNamedOptional(int id, string fname, string surname="Gautre", float salary = 45782.0f)
        {
            Console.WriteLine($"Welcome : {fname} {surname}");
            Console.WriteLine($"ID : {id}, \tSalary : {salary}");
        }
    }
}
