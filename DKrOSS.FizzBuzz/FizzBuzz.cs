using System;
using System.Collections.Generic;

namespace DKrOSS.FizzBuzz
{
    public class FizzBuzz
    {
        public bool IsFizz(int number) => number % 3 == 0;
        public bool IsBuzz(int number) => number % 5 == 0;
        public bool IsFizzBuzz(int number) => IsFizz(number) && IsBuzz(number);

        public IReadOnlyList<string> GenerateList()
        {
            var list = new List<string>(100);

            for (int i = 1; i <= 100; i++)
            {
                if(IsFizzBuzz(i))
                {
                    list.Add("FizzBuzz");
                    continue;
                }

                if(IsBuzz(i))
                {
                    list.Add("Buzz");
                    continue;
                }

                if(IsFizz(i))
                {
                    list.Add("Fizz");
                    continue;
                }

                list.Add(i.ToString());
            }

            return list;
        }
    }
}
