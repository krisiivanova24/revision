using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pokemon
    {
        private string nameP;
        private string element;
        private int health;
        private int znachki;

        public Pokemon(string nameP, string element, int health, int znachki) {
            this.NameP = nameP;
            this.Element = element;
            this.Health = health;
            this.Znachki = znachki;

        }
        public string NameP {
            get { return this.nameP; }
            set { this.nameP = value; }
        }
        public string Element {
            get { return this.element; }
            set { this.element = value; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public void Print (Pokemon list){
            
                Console.WriteLine($"{NameP} {element} {Health}");
            
        }
        public int Znachki {
            get { return this.znachki; }
            set { this.znachki = value; }
        }
    }
}
