using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            double length = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            double high = double.Parse(Console.ReadLine());
            if (length < 0 || weight < 0 || high < 0)
            {
                Console.WriteLine(3);
                Console.WriteLine("Width cannot be zero or negative. ");
            }
            else
            {
                //Boxy-box
                Box boxy = new Box(length, weight, high);
                boxy.Print();
            }

            
        }
    }
}
