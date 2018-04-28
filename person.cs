using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    class person
    {
        private string firstName;
        private string lastName;
        private sbyte age;
        private double salary;
        private List<person> list;
        private bool tryIt = false;
        public person()
        {
        }
        public person(string name, string name2, sbyte age, double salary)
        {
            tryIt = false;
            if (name.Length < 3)
            {
                Console.WriteLine("First name cannot be less than 3 symbols");
                
                
            }
            else
            {
                this.firstName = name;
            }
            if (name2.Length < 3)
            {
                Console.WriteLine("Last name cannot be less than 3 symbols");
            }
            else
            {
                this.lastName = name2;
            }
            if (age < 0)
            {
                Console.WriteLine("Age cannot be zero or negative integer");
            }
            else
            {
                this.age = age;
            }
            if (salary < 460.00)
            {
                Console.WriteLine("Salary cannot be less than 460 leva");
            }
            else
            {
                this.salary = salary;
            }


        }
        public List<person> List
        {
            get { return this.list; }
            set { this.list = value; }
        }
        public void Bonus(List<person> list, double bonus)
        {
            foreach (var item in list)
            {
                if (item.age < 30)
                {


                    item.salary += item.salary * bonus / 2 / 100;

                }
                else
                {

                    double sum = item.salary * (bonus / 100);
                    //Console.WriteLine(sum + " ***********************");
                    item.salary += sum;

                }
            }

        }
        public void Print(List<person> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.firstName} {item.lastName } gets {item.salary:f2} leva");
            }
        }
    }
}
