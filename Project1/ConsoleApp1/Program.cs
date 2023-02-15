int GeneratingRandomNumber(ref int a)
{
    int b = a % 10;
    a /= 10;
    return (b);
}

Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter M");
double m = Convert.ToDouble(Console.ReadLine());
var rnd = new Random();
double probability = rnd.NextDouble();
if (probability >= m)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        int number = rnd.Next(0,1000);
        Console.Write($"{number} ");
        while (number > 0)
        {
            sum += GeneratingRandomNumber(ref number);
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Sum of all digits of this random numbers is {sum}");
}
else
{
    for (int i = 0; i < n; i++)
    {
        int number = rnd.Next(0, 1000);
        Console.Write($"{number} ");
        while (number > 0)
        {
            Console.Write(GeneratingRandomNumber(ref number));
        }
        Console.WriteLine();
    }
}