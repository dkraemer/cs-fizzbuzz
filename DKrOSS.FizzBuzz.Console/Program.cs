using static System.Console;

namespace DKrOSS.FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            foreach (var item in fizzBuzz.GenerateList())
            {
                WriteLine(item);
            }

            ReadKey();
        }
    }
}
