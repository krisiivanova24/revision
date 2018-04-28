using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs1 = Console.ReadLine().Split().ToList();

            byte broqch = 0;
            List<Trainer> tr = new List<Trainer>();
            List<Pokemon> pokies = new List<Pokemon>();
            Trainer train = new Trainer();

            Dictionary<string, List<Pokemon>> allD = new Dictionary<string, List<Pokemon>>();
            while (!inputs1.Contains("Tournament"))
            {
                if (allD.ContainsKey(inputs1[0]))
                {
                    Pokemon poki1 = new Pokemon(inputs1[1], inputs1[2], int.Parse(inputs1[3]), 0);
                    broqch++;
                    allD[inputs1[0]].Add(poki1);

                }
                else
                {
                    Pokemon poki = new Pokemon(inputs1[1], inputs1[2], int.Parse(inputs1[3]), 0);

                    pokies = new List<Pokemon>();
                    pokies.Add(poki);
                    broqch++;
                    train = new Trainer(inputs1[0], 0, 1);
                    tr.Add(train);



                    allD[inputs1[0]] = pokies;

                }
                inputs1 = Console.ReadLine().Split().ToList();

            }

            Console.WriteLine(broqch);
            Console.WriteLine();
            train.Print2(tr);
            Console.WriteLine();
            string com = Console.ReadLine();
            
            foreach (var item in allD.Values)
            {
                foreach (var we in item)
                {
                    Console.WriteLine(",,,,,,,,,,,,");
                    we.Print(we);
                    Console.WriteLine(",,,,,,,,,,,,");
                }
            }
            bool what = false;
            while (com != "End")
            {
                foreach (var list in allD.Values)
                {



                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i].Print(list[i]);
                        if (list == null)
                        {
                            Console.WriteLine("DADADADADADADADADADADAADADADADAADAD");
                        }
                        else
                        if (String.Equals(list[i].Element, com))//!String.Equals(list[i].Element, "") && !String.Equals("", com) && 
                        {
                            foreach (var item in allD.Keys)
                            {
                                for (int t = 0; t < tr.Count; t++)
                                {
                                    if (String.Equals(item, tr[t].Name))
                                    {
                                        tr[t].Znachki++;
                                        Console.WriteLine(tr[t].Znachki + " znachki");
                                        what = true;
                                        break;
                                    }
                                    if (what == true)
                                    {
                                        break;
                                    }
                                }
                                if (what == true)
                                {
                                    break;
                                }
                            }
                            
                        }
                        else
                        {
                            list[i].Health -= 10;
                            Console.WriteLine(list[i].Health + " health");
                            if (list[i].Health < 0)
                            {
                                list[i].NameP = "";
                                list[i].Element = "";
                                list[i].Health = 0;
                                Console.WriteLine("k");
                                list[i].Print(list[i]);
                            }
                        }
                    }

                }
                com = Console.ReadLine();
            }
            //allD.OrderByDescending(x => x.Value.Where(y => y.Znachki == y.Znachki));
            byte count = 0;
        train.Print2(tr);
            foreach (var item in allD)
            {
                byte num = 0;

        Console.WriteLine(count);
                Console.Write($"{item.Key} ------> ");
                foreach (var list in allD.Values)
                {
                    
                    Console.Write(tr[count].Znachki);
                    Console.Write(" ;;;;;  ");
                    Console.Write(" ");
                for (int e = 0; e<item.Value.Count; e++)
                {
                    num++;
                }
    Console.WriteLine(num);
                    break;

                }
count++;


            }
        }
        }
        
    }

