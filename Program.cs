using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTest
{
    class Program
    {
        class Person 
        {
            public string name, phone;
        }
        static void Main(string[] args)
        {
            //Variabellösning
            string name, phone;
            name = "Arne Anka"; phone = "013-13 13 13";
            Console.WriteLine("{0}, tel. {1}", name, phone);
            //Objektlösning
            Person P = new Person();
            P.name = "Arne Anka"; P.phone = "013-13 13 13";
            Console.WriteLine("{0}, tel. {1}", P.name, P.phone);
        }
    }
}
