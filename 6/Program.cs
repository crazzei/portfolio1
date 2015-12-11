using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class hockeyplayer
    {
        public int jerseyNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int goalsScored { get; set; }

        public hockeyplayer()
        {

        }

        public hockeyplayer(int jerseyNumber, string firstName, string lastName, int goalsScored)
        {
            this.jerseyNumber = jerseyNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.goalsScored = goalsScored;
        }

    }
}

// first class 


namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            hockeyplayer p1 = new hockeyplayer(67, "daniel", "moore", 46);
            Console.WriteLine("The player {0} {1} has the jersey number {2} and has scored {3} goals", p1.firstName, p1.lastName, p1.jerseyNumber, p1.goalsScored);


        }
    }
}
