using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTruck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> allTr = new List<Truck>();
            List<Freight> allFr = new List<Freight>();
            List<string[]> all = new List<string[]>();
            List<string[]> all2 = new List<string[]>();            
            byte count = 0;

            string[] input = Console.ReadLine().Split(';').ToArray();
            all.Add(input);
            input = Console.ReadLine().Split(';').ToArray();
            all.Add(input);
           
            for (int i = 0; i < all.Count; i++)
            {                
                for (int y = 0; y < input.Length; y++)
                {
                    string[] split = all[i][y].Split('=').ToArray();

                    if (count < 3)
                    {
                        Truck tr = new Truck(split[0], ushort.Parse(split[1]));
                        count++;
                        allTr.Add(tr);

                    }
                    else
                    {
                        Freight fr = new Freight(split[0], ushort.Parse(split[1]));
                        allFr.Add(fr);
                    }
                }

            }
            string[] input2 = Console.ReadLine().Split().ToArray();
            while (!input2.Contains("END"))
            {
                foreach (var item in allTr)
                {
                    if (String.Equals(item.Name, input2[0]))
                    {
                        foreach (var pair in allFr)
                        {
                            if (String.Equals(pair.Name, input2[1]))
                            {
                                if (item.Izdryj >= pair.Tovi)
                                {
                                    item.Izdryj -= pair.Tovi;
                                    if (item.Tovar == null || item.Tovar != null)
                                    {
                                        item.AddTovi(pair.Name);
                                    }

                                    Console.WriteLine($"{item.Name} loaded {pair.Name} ");
                                }
                                else
                                {
                                    Console.WriteLine($"{item.Name} can't loaded {pair.Name} ");
                                }

                            }
                        }
                    }
                    
                }
                input2 = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine();
            foreach (var item in allTr)
            {
                Console.Write($"{item.Name} - ");
                if (item.Tovi  == null)
                {
                    Console.WriteLine("Nothing loaded");
                }
                else
                {
                    item.Print(item.Tovi);
                }


            }
        }
    }
}
