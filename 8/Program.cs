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
            double userInput;
            bool info = true;
            do
            {
                try
                {
                    userInput = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("enter in a valid nunber");
                    userInput = 0;
                    info = true;


                }
            }
            while (info == true);






        }
    }
}
