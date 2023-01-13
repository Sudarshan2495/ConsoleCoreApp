using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreApp.OOPS
{
    internal class SingletonPattern
    {
        static SingletonPattern singleton;

        private SingletonPattern()
        {

        }

        public static SingletonPattern GetObject()
        {
            return singleton == null ? new SingletonPattern() : singleton;
        }

        public void Display()
        {
            Console.WriteLine("Display from Singleton");
        }
    }
}
