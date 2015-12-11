using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lab4 = new int[10] { 63119, 63122, 63204, 63606, 53048, 46897, 12548, 46875, 23095, 48316 };
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == lab4[0] || input == lab4[1] || input == lab4[2] || input == lab4[3] || input == lab4[4] || input == lab4[5] || input == lab4[6] || input == lab4[7] || input == lab4[8] || input == lab4[9])
            {
                Console.WriteLine("we can deliver in your zip code");

            }
            else
            {
                Console.WriteLine("sorry you have to live somewhere else");
            }

        }
    }
}
