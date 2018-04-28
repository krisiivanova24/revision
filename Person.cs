using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    class Person
    {
        private string name;
        private float statistic;
        private float resistance;
        private float sprint;
        private float drible;
        private float feeds;
        private float shooting;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Person(string name, int resistance, int sprint, int drible, int feeds, int shooting)
        {
            if (name != "" && name.Trim().Length != 0)
            {
                this.name = name;
            }
            else
            {
                Console.WriteLine("A name should not be empty. ");
                
            }

            this.resistance = resistance;
            this.sprint = sprint;
            this.drible = drible;
            this.feeds = feeds;
            this.shooting = shooting;
            this.statistic = (this.resistance + this.sprint + this.drible + this.feeds + this.shooting) / 5;
        }
        public float Statistic
        {
            get { return this.statistic; }
            set { this.statistic = value; }
        }
    }
}
