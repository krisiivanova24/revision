using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Product
    {
        private string name;
        private string barcode;
        private double price;
        private double kg;
        private List<Product> spisyk;

        public List<Product> Spisyk {
            get { return this.spisyk; }
            set { this.spisyk = value; }
            
        }
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Barcode {
            get { return this.barcode; }
            set { this.barcode = value; }
        }
        public double Price {
            get { return this.price; }
            set { this.price = value; }
        }
        public double Kg {
            get { return this.kg; }
            set { this.kg = value; }
        }
        public Product(string bar, string name, double price, double kg) {
            this.Barcode = bar;
            this.Name = name;
            this.Price = price;
            this.Kg = kg;
            
        }
        public void ToString()
        {
            Console.WriteLine($"{name} {barcode } {price } {kg}"); ;
        }
    }
}
