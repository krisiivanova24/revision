using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    class Team
    {
        private string name;
        private List<Person> list;
        private float rating = 0;

        public Team()
        {
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }
        public List<Person> List
        {
            get { return this.list; }
            set { this.list = value; }
        }

        //public Team(string name, List<Person> list)
        //{
        //    this.name = name;
        //    foreach (var item in list)
        //    {
        //        this.rating += item.Statistic;
        //    }
        //    this.rating = rating / list.Count;
        //}
        public void Add(string name, List<Person> list)
        {

            //if (!String.Equals(name, this.Name))
            //{
            //    Console.WriteLine($"Team {this.Name} does not exists.");
            //} else
            this.Name = name;
            this.List = list;
            //foreach (var item in list)
            //{
            //    this.rating += item.Statistic;
            //}
            //this.rating = rating / list.Count;
        }
        public void Remove(Team team, string person)
        {
            //if (String.Equals(this.name, team.Name))
            //{
            foreach (var item in team.List.ToList())
            {
                if (String.Equals(item.Name, person))
                {
                    this.List.Remove(item);
                }
                //else
                //{   Console.WriteLine($"Player {person} is not in {this.name} team.");
                //}

            }

            //}
        }
        public void Rating()
        {
            //if (String.Equals(this.name, team.Name))
            //{
            //if (List.Contains(0))
            //{
            //    Console.WriteLine($"{this.Name} - 0");
            //}else
            foreach (var item in List)
            {
                this.rating += item.Statistic;
            }
            this.rating = rating / list.Count;
            if (this.rating < 0 || this.rating > 100)
            {
                Console.WriteLine("Endurance should be between 0 and 100. ");
            }
            //}
        }
        public void Print()
        {
            if (this.rating == 0)
            {

            }
            else
            {
                Console.WriteLine($"{this.Name} - {Math.Ceiling(this.rating)}");
            }

        }
        public void Print2()
        {
            foreach (var item in List)
            {
                Console.WriteLine($"{item.Name} st- {Math.Ceiling(item.Statistic)}");
            }
        }
    }
}
