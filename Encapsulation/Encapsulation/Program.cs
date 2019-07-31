using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] people = new Employee[]
            {
                new Employee("bob", "0220220222", "k@gmail.com", "123-456-789", "01-1234-12345678-99", "bobby", "B.0.B"),
                new Employee("Steve", "0220220522", "S@gmail.com", "123-896-789", "01-9934-12345678-99", "Steveis", "StevesPassword1"),
                new Employee("Kyle", "02202266666", "kyle@gmail.com", "123-456-888", "01-1234-12348523-99", "Monsterk", "DryWallDieWall"),
                new Employee("Joseph", "0228888222", "j@gmail.com", "895-456-789", "01-1234-1258978-99", "Joseph", "Password1"),

            };
            foreach(Employee x in people)
            {
             Console.WriteLine($"\n {x.Workers()}");
            }
            Console.ReadLine();
        }
    }

    class Employee
    {
        private string fullname { get; set; }
        private string phone { get; set; }
        private string email { get; set; }
        private string ird { get; set; }
        private string bank { get; set; }
        private string uname { get; set; }
        private string pass { get; set; }

        public Employee()
        {
        }
        public Employee(string _fullname, string _phone, string _email, 
            string _ird, string _bank, string _uname, string _pass)
        {
            fullname = _fullname;
            phone = _phone;
            email = _email;
            ird = _ird;
            bank = _bank;
            uname = _uname;
            pass = _pass;
        }

        public string Workers()
        {

            return 
                $"FullName: {fullname}\n" +
                $"Phone: {phone}\n" +
                $"Email: {email}\n" +
                $"Ird: {ird}\n" +
                $"Bank: {bank}\n" +
                $"User Name: {uname}\n" +
                $"Password: {pass}\n";
        }
    }

}
