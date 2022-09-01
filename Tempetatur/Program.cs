using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempetatur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tast inn temperaturen");

            int temperatur = int.Parse(Console.ReadLine());

            if (temperatur > 0)

            {

                Console.WriteLine("Temperaturen er varmegrader");

            }

            else

            {

                Console.WriteLine("Temperaturen er kalde grader");

            }
        }
    }
}
