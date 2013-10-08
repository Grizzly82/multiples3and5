using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplesof3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If we list all the natural numbers below 10 that are ");
            Console.WriteLine("multiples of 3 or 5, we get 3, 5, 6 and 9.");
            Console.WriteLine("The sum of these multiples is 23.");
            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");
            Console.WriteLine("");

            AddMultiples myNewSum = new AddMultiples();

            double myValue = myNewSum.MyMultiples();

            Console.WriteLine(myValue);
            Console.ReadLine();
        }


    }// end of class program

    class AddMultiples
    {
        public double MyMultiples()
        {
            int y = 0;

            for (int i = 0; i < 1000; i++)
            {

                if (i % 3 == 0 ||  i % 5 == 0)
                {
                    y = y + i;

                }
                else
                {
                    //Console.WriteLine(" ");
                }
            }

            return y;
        }

    }

}
