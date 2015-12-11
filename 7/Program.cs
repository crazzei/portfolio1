using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Conference : IComparable
    {
        public string GroupName { get; set; }
        public string StartingDate { get; set; }
        public int NumofAttendants { get; set; }

        public Conference(string nameInput, string dateInput, int numInput)
        {
            GroupName = nameInput;
            StartingDate = dateInput;
            NumofAttendants = numInput;
        }

        int IComparable.CompareTo(Object i)
        {

            Conference temp = (Conference)i;
            if (this.NumofAttendants > temp.NumofAttendants)
            {
                return 1;
            }
            else if (this.NumofAttendants == temp.NumofAttendants)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}

//first class
namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Conference[] newCon = new Conference[2];
            string nameInput;
            string dateInput;
            int numInput;
            for (int i = 0; i < newCon.Length; i++)
            {
                Console.WriteLine("Enter in conference name:");
                nameInput = Console.ReadLine();
                Console.WriteLine("Enter in the starting date:");
                dateInput = Console.ReadLine();
                Console.WriteLine("Enter in the number of attendants:");
                numInput = int.Parse(Console.ReadLine());
                newCon[i] = new Conference(nameInput, dateInput, numInput);
            }

            Array.Sort(newCon);
            foreach (Conference item in newCon)
            {
                Console.WriteLine();
                Console.Write("The {0} group ", item.GroupName);
                Console.Write("had its event on {0} ", item.StartingDate);
                Console.Write("with {0} people attending ", item.NumofAttendants);
            }


        }
    }
}