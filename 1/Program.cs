using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a purchace price: $");
            double price = Convert.ToDouble(Console.ReadLine());
            if (price > 5000)
            {
                Console.WriteLine("Error thats too much money yo");

            }
            else
            {
                Console.WriteLine("you can afford this bruh");
            }

        }
    }
}
