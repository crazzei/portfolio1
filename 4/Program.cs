using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the Length of the room: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the width of the room: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(PaintCost(length, width).ToString("C"));



        }
        private static double PaintCost(double length, double width)
        {


            double big = (length * 9) * 2;
            double small = (width * 9) * 2;
            double total = big + small;
            double price = total * 6;
            return price;



        }



    }
}
