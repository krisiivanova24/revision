using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonApetit
{
    class Meal
    {
        private string name;
        private string type;
        private List<Product> allPr;
        private int ordered;
        private double price;
        private byte count;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public List<Product> AllPr
        {
            get { return this.allPr; }
            set { this.allPr = value; }
        }
        public int Ordered
        {
            get { return this.ordered; }
            set { this.ordered = value; }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                foreach (var item in allPr)
                {
                    this.price += item.Price;
                }
                this.price += this.price * 30 / 100;
            }
        }
        public Meal(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
        public Meal(string name, string type, List<Product> prs)
        {
            this.Name = name;
            this.Type = type;
            this.AllPr = prs;
        }
        public void AddMeal(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
        public void AddMealProducts(string name, string type, byte num)
        {
            string[] inputs = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < num; i++)
            {
                Product pr = new Product();
                pr.Name = inputs[i];
                AllPr.Add(pr);
            }
        }
        public void PrintMeal(Meal name)
        {
            Console.WriteLine($"{this.Name} - {this.Type}");
        }
        public void AddProductToMeal(Product pr, string name)
        {
            this.AllPr.Add(pr);
        }
        public void ContainsProduct(Product pr, Meal name)
        {
            if (this.AllPr.Contains(pr))
            {
                Console.WriteLine($"{pr.Name} is contained in {this.Name}. ");
            }
            else
            {
                Console.WriteLine($"{pr.Name} is NOT contained in {this.Name}. ");
            }
        }
        public void GetMealPrice(Meal name) {
            Console.WriteLine( $"The price of {this.name} is: {this.Price:f2}.");
        }
        public void PrintMealRecipe(Meal name) {
            Console.WriteLine(new string('-',25));
            Console.WriteLine($"{name.Name} RECIPE");
            Console.WriteLine(new string('-', 25));
            foreach (var item in name.allPr)
            {
                Console.WriteLine($"{item.Name} - {item.Weight}");
            }
            Console.WriteLine(new string('-', 25));
        }
        public void OrderMeal(Meal name) {
            this.count++;
        }
        public void GetSpeciality() {
            Console.WriteLine($": “The current specialty is: {this.Name}");
        }
    }

}

