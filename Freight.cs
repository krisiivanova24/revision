using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTruck
{
    class Freight
    {
        private string name;
        private ushort tovi;

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public ushort Tovi {
            get { return this.tovi; }
            set { this.tovi = value; }
        }
        public Freight(string name, ushort tovi) {
            this.Name = name;
            this.Tovi = tovi;
        }
    }
}
