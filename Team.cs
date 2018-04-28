using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAndReserve
{
    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        private byte br1;
        private byte br2;
        
        public List<Person> FirstTea {
            get { return this.firstTeam; }
            set { this.firstTeam = value; }
        }

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public void AddPlayer(Person person)
        {
            
            if (person.Age < 40)
            {
                firstTeam.Add(person);
                br1++;
            }
            else
            {
                reserveTeam.Add(person);
                br2++;
            }
        }
        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return this.firstTeam.AsReadOnly(); }
        }                                                     //ne znam kak da gi izpolzvam tezi dvete
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this.reserveTeam.AsReadOnly(); }
        }
        public void Print() {
            Console.WriteLine($"First team has {br1} players");
            Console.WriteLine($"Reserve team has {br2} players");
        }
    }
}
