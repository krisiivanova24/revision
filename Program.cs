using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            List<string[]> allIn = new List<string[]>();

            Shop shop = new Shop();
            List<Product> prs = new List<Product>(); //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            shop.Spisyk = prs; //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            while (!input.Contains ("Close"))
            {
                allIn.Add(input);
                input = Console.ReadLine().Split().ToArray();
            }
            for (int i = 0; i < allIn.Count; i++)
            {
                //Console.WriteLine(allIn[i][0] + " /////");
                if (String.Equals(allIn[i][0], "Add"))
                {
                    Product pr = new Product(allIn[i][1], allIn[i][2], double.Parse(allIn[i][3]), double.Parse(allIn[i][4]));
                    //pr.ToString();
                    prs.Add(pr);
                    
                    //shop.Add(allIn[i][1], allIn[i][2], double.Parse(allIn[i][3]), double.Parse(allIn[i][4]));
                }
                else
                {
                    if (String.Equals(allIn[i][0], "Sell"))
                    {
                        shop.Sell(allIn[i][1], double.Parse(allIn[i][2]));
                    }
                    else
                    {
                        if (String.Equals(allIn[i][0], "Update"))
                        {
                            shop.Update(allIn[i][1], double.Parse(allIn[i][2]));
                        }
                        else
                        {
                            if (String.Equals(allIn[i][0], "PrintA"))
                            {
                                shop.PrintA();
                            }
                            else
                            {
                                if (String.Equals(allIn[i][0], "PrintU"))
                                {
                                    shop.PrintU();
                                }
                                else
                                {
                                    if (String.Equals(allIn[i][0], "PrintD"))
                                    {
                                        shop.PrintD();
                                    }
                                    else
                                    {
                                        shop.Calculate();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
