using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(';').ToArray();
            string[] inputs = Console.ReadLine().Split(';').ToArray();
            Team team = new Team();
            List<Person> list = new List<Person>();
            while (!inputs.Contains("END"))
            {
                if (String.Equals(inputs[0], "Add"))
                {
                    Person per = new Person(inputs[2], int.Parse(inputs[3]), int.Parse(inputs[4]), int.Parse(inputs[5]), int.Parse(inputs[6]), int.Parse(inputs[7]));
                    list.Add(per);
                    team.Add(inputs[1], list);
                    //team.Print2();
                }
                else
                {
                    if (String.Equals(inputs[0], "Remove") && team.List != null )
                    {
                        Console.WriteLine(inputs[2]);
                        team.Remove(team,inputs[2]);
                    }
                    else
                    {
                        team.Rating();
                    }
                }
                inputs = Console.ReadLine().Split(';').ToArray();
            }
            team.Print();
        }
    }
}
