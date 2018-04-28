using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Box
    {
        private double length;
        private double weight;
        private double high;

        public Box(double length, double weight, double high) {
            this.length = length;
            this.weight = weight;
            this.high = high;                                          
        }
        public void Print(){
            Console.WriteLine(3);
            double result = 2 * this.length * weight + 2 * length * high + 2 * weight * high;
            Console.WriteLine($"Surface Area - {result:f2}");
            result = 2 * length * high + 2 * weight * high;
            Console.WriteLine($"Lateral Surface Area - {result:f2}");
            result = length * weight * high;
            Console.WriteLine($"Volume - {result:f2}");
        }                               
    }
}
 