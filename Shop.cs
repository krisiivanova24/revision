using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Shop
    {
        private List<Product> spisyk;
        public List<Product> Spisyk
        {
            get { return this.spisyk; }
            set { this.spisyk = value; }
        }

        public void Add(string bar, string name, double price, double kg)
        {
            Product product = new Product(bar, name, price, kg);
            Spisyk.Add(product);
        }
        public void Sell(string bar, double kg)
        {
            foreach (var item in spisyk)
            {
                //Console.WriteLine($"{bar }  +  { item.Barcode}");
                if (String.Equals(bar, item.Barcode))
                {
                    if (item.Kg >= kg)
                    {
                        item.Kg -= kg;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not enough quantity ");
                    }
                }
                else
                {
                    Console.WriteLine("Not enough quantity");
                }
            }
        }
        public void Update(string bar, double kg)
        {
            foreach (var item in spisyk)
            {
                if (String.Equals(bar, item.Barcode))
                {
                    item.Kg += kg;
                   // Console.WriteLine(7878787877 + " " + item.Kg);

                }
                else
                {
                    Console.WriteLine("Please add your product first!");
                }
            }
        }
        public void PrintA()
        {
            List<Product> spisyk2 = spisyk.OrderBy(x => x.Name).ToList();
            foreach (var item in spisyk2)
            {
                if (item.Kg > 0)
                {
                    Console.WriteLine($"{item.Name} ({item.Barcode}) ");
                }

            }
        }
        public void PrintU()
        {
            List<Product> spisyk3 = new List<Product>();
            foreach (var item in spisyk)
            {
                if (item.Kg == 0)
                {
                    spisyk3.Add(item);
                }
            }
            foreach (var item3 in spisyk3)
            {
                Console.WriteLine($"{item3.Name} ({item3.Barcode})");
            }
        }
        public void PrintD()
        {
            List<Product> spisyk4 = spisyk.OrderByDescending(x => x.Kg).ToList();
            foreach (var item in spisyk4)
            {
                if (item.Kg > 0)
                {
                    Console.WriteLine($"{item.Name} ({item.Barcode}) ");
                }

            }
        }
        public void Calculate()
        {
            double result = 0.0;
            foreach (var item in spisyk)
            {
                result += item.Kg * item.Price;
            }
            Console.WriteLine(result);
        }

    }
}

