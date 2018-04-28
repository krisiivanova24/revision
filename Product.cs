using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonApetit
{
    class Product
    {
        private string name;
        private double price;
        private int weight;
        private List<Product> list;

        public Product() { }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public List<Product> List
        {
            get { return this.list; }
            set { this.list = value; }
        }
        public Product(string name, double price, int weight)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
            this.List = new List<Product>();
        }
        public void AddProduct(string name, double price, int weight)
        {
            Product pr = new Product(name, price, weight);
            //this.Name = name;
            // this.Price = price;
            //this.Weight = weight;
            List.Add(pr);
        }
        public void AddMultiProducts(byte num)
        {
            for (int i = 0; i < num; i++)
            {
                string[] inputs = Console.ReadLine().Split().ToArray();
                Product pr = new Product(inputs[0], double.Parse(inputs[1]), int.Parse(inputs[2]));
                // this.Name = inputs[0];
                //this.Price = double.Parse(inputs[1]);
                //this.Weight = int.Parse(inputs[2]);
                List.Add(pr);
            }
        }
        public void PrintProduct(string name)
        {
            foreach (var item in List)
            {
                if (string.Equals(item.Name, name))
                {
                    Console.WriteLine($"{item.Name} - {item.Weight}");
                }
            }

        }
        
    }
}
