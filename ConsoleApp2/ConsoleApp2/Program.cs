using System.Collections;
using System.Linq;

using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int n;
            double m;
            if (args.Length == 0)
            {
                Console.WriteLine("Enter N");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter M");
                m = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                n = Convert.ToInt32(args[0]);
                m = Convert.ToDouble(args[1]);
            }
            var rnd = new Random();
            double probability = new Random().NextDouble();
            IEnumerable<int> numbers = Enumerable.Range(0, n).Select(_ => rnd.Next(0, 1000)).ToList();
            Console.WriteLine("Initial numbers are:");
            foreach (var k in numbers)
            {
                Console.Write($"{k} ");
            }
            Console.WriteLine();
            if (probability >= m)
            {
                foreach (var k in numbers)
                {
                    string b = new string (k.ToString().Reverse().ToArray());
                    Console.Write($"{b} ");
                }
            }
            else
            {
                int sum = 0;
                foreach (var k in numbers)
                {
                    var d = k.ToString().ToList();
                    foreach (var b in d)
                    {
                        sum += Convert.ToInt32(b.ToString());
                    }
                }
                Console.Write($"Sum of all chasrecters of this numbers are {sum}");
            }
        }
    }
}