using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Person
{
    class Program
    {
        static void Main(string[] args)
        {

            Person P1 = new Person("Dan", "Hollander", 22);
            Person P2 = new Person("Sebastian", "Smith", 32);
           
          
            Console.WriteLine( P1.ReturnDeets());
            Console.WriteLine(P2.ReturnDeets());
            Console.WriteLine(Person.counter);
            Console.ReadLine();

        }

   


    }

    class Person
    {
        private string fname;
        private string lname;
        private int age;
        public static int counter = 0;

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Counter { get { return counter; } set { counter = value; } }

        public string ReturnDeets()
        {
            return $"Name: {Fname} {Lname}\n Age: {Age}";
        }

        public Person() { }
        public Person(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;

            Counter++;
        }
    }


}
