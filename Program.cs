using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callories
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            List<string[]> all = new List<string[]>();
            Pizza piz = new Pizza();
            Dought dou = new Dought();
            Topping top = new Topping();
            double call = 0;

            while (!input.Contains("END"))
            {
                all.Add(input);
                input = Console.ReadLine().Split().ToArray();
            }
            for (int i = 0; i < all.Count; i++)
            {
                if (all[i][0] == "Dough")
                {
                    dou = new Dought(all[i][1].ToLower(), all[i][2].ToLower(), float.Parse(all[i][3]));
                    if (dou.What == false)
                    {
                        break;
                    }
                    call += dou.Callorie;
                    //dou.Print();

                }
                else
                {
                    if (String.Equals(all[i][0], "Topping"))
                    {
                        top = new Topping(all[i][1], ushort.Parse(all[i][2]));
                        if (top.What == false)
                        {
                            break;
                        }
                        call += top.Call;
                        // top.PrintCall();
                    }
                    else
                    {
                        piz = new Pizza(all[i][1], byte.Parse(all[i][2]));
                        if (piz.What == false)
                        {
                            break;
                        }
                    }
                }

            }
            if (piz.What == true && dou.What == true && top.What == true)
            {
                Console.WriteLine($"{piz.NameP} - {call:f2} Callories");
            }


        }
    }
}
