using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKrOSS.FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            foreach (var item in fizzBuzz.GenerateList())
            {
                System.Console.WriteLine(item);
            }

            return;
        }
    }
}
