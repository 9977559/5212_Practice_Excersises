using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exCheck = true;
            bool inCheck = true;
            do
            {
                ShoppingCart s1 = new ShoppingCart();
                Console.WriteLine("Please enter your username: ");
                s1.Uname = Console.ReadLine();
                Console.WriteLine("Please enter your password ");
                s1.Pword = Console.ReadLine();
                do
                {
                    Console.WriteLine("What would you like to add?: ");
                    s1.Cart.Add(Console.ReadLine());
                    Console.WriteLine("How much was it?: $");
                    s1.CartTotal = Convert.ToDouble(Console.ReadLine());

                } while (inCheck);

            } while (exCheck);

        }
    }

    class ShoppingCart
    {
        private string username;
        private string password;
        private List<string> cart = new List<string>();
        private double cartTotal = 0;

        public string Uname
        {
            get { return username; }
            set { username = value; }
        }
        public string Pword
        {
            get { return password; }
            set { password = value; }
        }
        public List<string> Cart
        {
            get { return cart; }
            set { cart = value; }
        }
        public double CartTotal
        {
            get { return cartTotal; }
            set { cartTotal = value; }
        }


    }

}
