using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DISPLAYS GREETING:
            Console.WriteLine("Welcome:\n" +
                "1. Addition\n" +
                "2. Circle \n" +
                "3. Times Tables \n" +
                "4. Array");
            int nav = Convert.ToInt32(Console.ReadLine());

            if (nav == 1)
            {
                Console.WriteLine("You chose Addition");
                Console.WriteLine("Please enter first number to add: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Second number to add: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Addition(num1, num2));

            }
            else if (nav == 2)
            {
                Console.WriteLine("You chose Circle");
            }
            else if (nav == 3)
            {
                Console.WriteLine("you chose Times Tables");
            }
            else if (nav == 4)
            {

            }

            Console.ReadLine();


        }

        public static int Addition(int num1, int num2)
        {
        //ADDS TWO NUMS TOGETHER
        int num3 = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {num3}");
            return (num3);
          }
        //public double Circle()
        //{
        //    //CIRCLE CALCULATOR
        //    Console.WriteLine("Please enter the radius: ");
        //    double rad = Convert.ToDouble(Console.ReadLine());
        //    double cir = (rad * 2) * 3.15;
        //    double area = 3.15 * (rad * rad);
        //    Console.WriteLine($"Circumfrence = {cir}\n" +
        //        $"Area = {area}");
        //}
        //public int TimesTable()
        //{
        //    //DISPLAYS FIRST 10 TIMES TABLES OF A NUMBER:
        //    Console.WriteLine("Please enter a number to display it's times tables: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i <= 10; i++)
        //    {
        //        int timesnum = number * i;
        //        Console.WriteLine($"{number} x {i} = {timesnum}");
        //    }
        //}
    }
}
