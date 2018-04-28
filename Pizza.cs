using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callories
{
    class Pizza
    {
        private string nameP;
        private byte num;
        private bool what = true;
        
        public bool What {
            get { return this.what; }
            set { this.what = value; }
        }
        public Pizza() { }
        public string NameP {
            get { return this.nameP; }
            set { this.nameP = value; }
        }
        public byte Num {
            get { return this.num; }
            set { this.num = value; }
        }
        public Pizza(string nameP, byte num) {
            //Console.WriteLine(nameP);
            if (nameP.ToCharArray().Length > 15)
            {
                Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                What= false;
                
            }
            else
            {
                if (num < 1 || num > 10)
                {
                    Console.WriteLine("Number of toppings should be in range [0..10].");
                    What = false;
                }
                else
                {
                    this.NameP= nameP;
                    this.Num = num;
                }
            }
        }
    }
}
