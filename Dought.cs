using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callories
{
    class Dought
    {
        private string flour;
        // private string technic;
        private float grams;
        private string way;
        private double callorie;
        private bool what = true;
        public bool What
        {
            get { return this.what; }
            set { this.what = value; }
        }

        public Dought() { }
        public Dought(string input1, string input2, float input3)
        {
            string input12 = input1.ToLower();
            string input22 = input2.ToLower();

            if (!String.Equals(input12, "white") && !String.Equals(input12, "wholegrain"))
            {
                Console.WriteLine("Invalid type of dough.");
                What = false;
            }
            else
            {

                if (!String.Equals(input22, "crispy") && !String.Equals(input22, "chewy") && !String.Equals(input22, "homemade"))
                {
                    Console.WriteLine("Invalid type of dough.");
                    What = false;
                }
                else
                {

                    if (input3 < 1 || input3 > 200)
                    {
                        Console.WriteLine("Dough weight should be in the range [1..200].");
                        What = false;
                    }
                    else
                    {
                        this.Flour = input12;
                        this.Way = input22;
                        this.Grams = input3;
                        switch (input1)
                        {
                            case "white":
                                {
                                    this.callorie = (this.Grams * 2) * 1.5;
                                }
                                break;
                            case "wholegrain":
                                {
                                    this.callorie = (this.Grams * 2) * 1.0;
                                }
                                break;

                        }
                        switch (input22)
                        {
                            case "crispy":
                                {
                                    this.callorie *= 0.9;
                                }
                                break;
                            case "chewy":
                                {
                                    this.callorie *= 1.1;
                                }
                                break;
                            case "homemade":
                                {
                                    this.callorie *= 1.0;
                                }
                                break;
                        }
                    }
                }
            }

        }
        public string Way
        {
            get { return this.way; }
            set
            {
                this.way = value;
            }
        }
        public string Flour
        {
            get { return this.flour; }
            set
            {
                this.flour = value;

            }
        }
        public float Grams
        {
            get { return this.grams; }
            set
            {
                this.grams = value;
            }
        }
        public double Callorie {
            get { return this.callorie; }
            set { this.callorie = value; }
        }
        public void Print()
        {
            if (this.callorie != 0)
            {
                Console.WriteLine($"{callorie:f2}");
            }

        }
    }
}
