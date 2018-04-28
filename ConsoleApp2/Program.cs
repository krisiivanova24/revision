using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           List<List<string>> all = new List<List<string>>();
            List<string> input1 = Console.ReadLine().Split().ToList();
            while (!input1.Contains("End"))
            {
                all.Add(input1);
                input1 = Console.ReadLine().Split().ToList();
            }
            string input2 = Console.ReadLine();
            Google gog = new Google();
            List<string> pokem = new List<string>();
            List<string> per = new List<string>();
            List<string> child = new List<string>();
            for (int i = 0; i < all.Count; i++)
            {
                
                //Console.WriteLine(all[i][0]);
                if (String.Equals(all[i][0], input2 ))
                {
                    if (String.Equals(all[i][1], "company"))
                    {
                        gog.Company = all[i][2] + " " + all[i][3] + " " + all[i][4];
                    }
                    else
                    {
                        if (String.Equals(all[i][1], "car"))
                        {
                            gog.Car = all[i][2] + " " + all[i][3];
                            
                        }
                        else
                        {
                            if (String.Equals(all[i][1], "pokemon"))
                            {

                                gog.Pokemon = all[i][2] + " " + all[i][3];
                                pokem.Add(gog.Pokemon);

                            }
                            else
                            {
                                if (String.Equals(all[i][1], "parents"))
                                {
                                    gog.Parents = all[i][2] + " " + all[i][3];
                                    per.Add(gog.Parents);

                                }
                                else
                                {
                                        gog.Children = all[i][2] + " " + all[i][3];
                                    child.Add(gog.Children);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(input2);
            gog.Print(pokem, per, child);
        }
    }
}
