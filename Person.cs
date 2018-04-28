using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAndReserve
{
    class Person
    {
        private string fName;
        private string lName;
        private int age;
        //obrabotka
        public string FName
        {
            get { return this.fName; }
            set { this.fName = value; }
        }
        public string LName
        {
            get { return this.lName; }
            set { this.lName = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Person(string fName, string lName, int age)
        {
           this.FName = fName;
            this.LName = lName;
            this.Age = age;
        }
    }
}
