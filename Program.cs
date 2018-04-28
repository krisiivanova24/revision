using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            List<person> people = new List<person>();
            List<string[]> list = new List<string[]>();
            person per = new person();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                list.Add(input);

            }
            float percent = float.Parse(Console.ReadLine());
            for (int i = 0; i < list.Count; i++)
            {
                per = new person(list[i][0], list[i][1], sbyte.Parse(list[i][2]), double.Parse(list[i][3]));
                if (list[i][0].Length < 3 || list[i][1].Length < 3 || sbyte.Parse(list[i][2]) < 0 || double.Parse(list[i][3]) < 460.00)
                {

                }
                else
                {
                    people.Add(per);

                }
                
                
            }
            per.Bonus(people, percent);
            per.Print(people);

        }
    }
}
