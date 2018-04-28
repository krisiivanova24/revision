using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Trainer
    {
        private string name;
        private int znachki;
        private List<Pokemon> poke;
        private byte br;
        //private List<>

        public Trainer()
        {
        }
        public Trainer(string name, byte znachki, byte br)
        {
            this.Name = name;
            this.Znachki = znachki;
            this.Br = br;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Znachki
        {
            get { return this.znachki; }
            set { this.znachki = value; }
        }
        public List<Pokemon> Poke
        {
            get { return this.poke; }
            set { this.poke = value; }
        }
        public byte Br
        {
            get { return this.br; }
            set { this.br = value; }
        }
        public void Print2(List<Trainer> list1)
        {
            foreach (var list in list1)
            {
                Console.WriteLine($"{list.Name} {list.Znachki} {list.Br}");
            }


        }
    }
}
