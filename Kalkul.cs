using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulyator
{
    internal class Kalkul
    {

        double num_one;
        double num_two;

        public void plus(double num_one, double num_two)
        {
            Console.WriteLine(num_one + num_two);
        }
        public void minus(double num_one, double num_two)
        {
            Console.WriteLine(num_one - num_two);
        }
        public void multiplication(double num_one, double num_two)
        {
            Console.WriteLine(num_one * num_two);
        }
        public void division(double num_one, double num_two)
        {
            if (num_two == 0)
            {
                Console.WriteLine("На 0 делить нельзя");
            }
            else
            {
                Console.WriteLine(num_one / num_two);
            }

        }

        public void rounding(double num_one, double num_two) //округление
        {
            Console.WriteLine(Math.Round(num_one));
            Console.WriteLine(Math.Round(num_two));
        }

        public void arksin(double num_one, double num_two) //arksin
        {
            Console.WriteLine(Math.Atan(num_one));
        }

        public void degree(double num_one, double num_two) // степень
        {
            Console.WriteLine(Math.Pow(num_one, num_two));
        }

        public void square(double num_one, double num_two) // квадрат
        {
            Console.WriteLine(Math.Sqrt(num_one));
            Console.WriteLine(Math.Sqrt(num_two));
        }
        public void sin(double num_one, double num_two) //синус
        {
            Console.WriteLine(Math.Sin(num_one));
            Console.WriteLine(Math.Sin(num_two));
        }
        public void tan(double num_one, double num_two)
        {
            Console.WriteLine(Math.Tan(num_one));
        }
    }
}