using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EXCERSISE 2*/


            /*Q2*/
            // Create a program that will create an array of 100 random numbers from 0 to 100. 
            //The program then needs to display the sum of all of the numbers in the array.

            int[] nums = new int[100];
            nums = Populate(nums);
            Console.WriteLine("Array contents:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]}");
                if ((i + 1) % 5 == 0) ;
                Console.WriteLine();
            }
            Console.WriteLine($"\n The sum of the numbers in the array is : {Sum(nums)}");
            Console.ReadLine();
        }
        static int[] Populate(int[] nums)
        {
            Random rand = new Random();
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(100);
            }
            return nums;
        }
        static int Sum(int[] nums)
        {
            int total = 0;
            foreach (int x in nums)
                total = +x;
            return total;
        }


    }
}
