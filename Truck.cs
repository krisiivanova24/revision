using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTruck
{
    class Truck
    {
        private string name;
        private ushort izdryj;
        private List<Freight> tovar;
        private List<string> addTovi;

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public ushort Izdryj {
            get { return this.izdryj; }
            set { this.izdryj = value; }
        }
        public Truck(string name, ushort izdryj) {
            this.Name = name;
            this.Izdryj = izdryj;
            this.Tovi = new List<string>();///////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }
        public List<Freight> Tovar{
            get { return this.tovar; }
            set { this.tovar = value; }
        }
        public List<string> Tovi {
            get { return this.addTovi; }
            set { this.addTovi = value; }
        }
        public void AddTovi(string tovar) {
            this.Tovi.Add(tovar);
        }
        public void Print(List<string > ttovar) {
            foreach (var item in ttovar )
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
