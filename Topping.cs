using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callories
{
    class Topping
    {
        private float meat = 1.2f;
        private float veggies = 0.8f;
        private float cheese = 1.1f;
        private float sauce = 0.9f;
        private double call;
        private List<double> allTop;
        private bool what = true;

        public Topping() { }
        public bool What
        {
            get { return this.what; }
            set { this.what = value; }
        }

        public Topping(string product, ushort grams)
        {
            string product2 = product;
            product = product.ToLower();
            if (!String.Equals(product, "meat") && !String.Equals(product, "veggies") && !String.Equals(product, "cheese") && !String.Equals(product, "sauce"))
            {
                Console.WriteLine($"Cannot place {product2} on top of your pizza.");
                What = false;
            }
            else
            {
                if (grams < 1 || grams > 50)
                {
                    Console.WriteLine($"{product2} weight should be in the range [1..50].");
                    What = false;
                }
                else
                {
                    if (String.Equals(product, "meat"))
                    {
                        call = this.meat * 2 * grams;
                    }
                    else
                    {
                        if (String.Equals(product, "veggies"))
                        {
                            call = this.veggies * 2 * grams;
                        }
                        else
                        {
                            if (String.Equals(product, "cheese"))
                            {
                                call = this.cheese * 2 * grams;
                            }
                            else
                            {
                                call = this.sauce * 2 * grams;
                            }
                        }
                    }
                    //AllTop.Add(call);
                }
            }
        }
        public List<double> AllTop {
            get { return this.allTop; }
            set { this.allTop = value; }
        }
        public double Call
        {
            get { return this.call; }
            set { this.call = value; }
        }
        public void PrintCall()
        {
            if (call != 0)
            {
                Console.WriteLine($"{call:f2}");
            }

        }
    }
}
