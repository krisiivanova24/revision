using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Google
    {
        private string company = "";
        private string pokemon = "";
       
        private string parents = "";
        private string children = "";
        private string car = "";
       
        public string Company
        {
            get { return this.company; }
            set { this.company = value; }
        }
        public string Pokemon
        {
            get { return pokemon; }
            set { pokemon = value; }
        }
        //public List<string> Pokemons 
        //{
        //    get { return this.pokemons; }
        //    set { this.pokemons = value; }
        //}
        public string Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }
        public string Children
        {
            get { return this.children; }
            set { this.children = value; }
        }
        public string Car
        {
            get { return this.car; }
            set { this.car = value; }
        }
        public void Print(List<string> pokem, List<string> per, List<string> child)
        {
            Console.WriteLine("Company:");
            if (!String.Equals(company, ""))
            {
                Console.WriteLine(company);
            }

            Console.WriteLine("Car:");
            if (!String.Equals(car, ""))
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("Pokemon:");
            if (!String.Equals(pokem, ""))
            {
                foreach (var item in pokem)
                {
                    Console.WriteLine(item);
                }

            }

            Console.WriteLine("Parents:");
            if (!String.Equals(per, ""))
            {
                foreach (var item in per)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Children:");
            if (!String.Equals(child, ""))
            {
                foreach (var item in child)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
