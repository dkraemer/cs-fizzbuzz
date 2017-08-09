using System.Collections.Generic;

namespace DKrOSS.FizzBuzz
{
    public class FizzBuzz
    {
        public bool IsFizz(int number) => number % 3 == 0;
        public bool IsBuzz(int number) => number % 5 == 0;

        public IReadOnlyList<string> GenerateList()
        {
            var list = new List<string>(100);

            for (int i = 1; i <= 100; i++)
            {
                string output = null;

                if(IsFizz(i))
                {
                    output = "Fizz";
                }
                if(IsBuzz(i))
                {
                    output += "Buzz";
                }

                if(output == null)
                {
                    output = i.ToString();
                }

                list.Add(output);
            }

            return list;
        }
    }
}
