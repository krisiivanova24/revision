using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAndReserve
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            Team team = new Team("Winners");
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Person person = new Person(input[0], input[1], int.Parse(input[2]));
                team.AddPlayer(person);                
            }
            team.Print();           
        }
    }
}
