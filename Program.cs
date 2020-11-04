using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTest
{
    class Program
    {
        static double Sqr(double X)
        {
            return X * X;
        }
        class Person 
        {
            private string name, phone;
            public Person(string N, string P)
            {
                name = N; 
                phone = P;
            }
            public string NamePhone()
            {
                return $"{name}, tel. {phone}";
            }
        }
        static void Main(string[] args)
        {
            //Skyddad Objektlösning
            Person P = new Person("Arne Anka", "013-13 13 13");
            Person Q = new Person("Anna Anka", "013-14 15 16");
            Console.WriteLine(P.NamePhone());
            Console.WriteLine(Q.NamePhone());
            //

        }
    }
}
