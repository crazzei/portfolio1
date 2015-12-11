using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter in any number up to 10 times.");
                array[i] = int.Parse(Console.ReadLine());
            }

            method(array);
        }
        private static void method(params double[] array)
        {

            double sum = 0;
            foreach (int thing in array)
            {
                sum += thing;
                Console.Write(thing + ", ");
            }
            Console.WriteLine("average = {0}", sum / array.Length);

        }
    }
}
