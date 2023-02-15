int GeneratingRandomNumber()
{
    var rnd = new Random();
    int number = rnd.Next(0, 1000);
    Console.Write($"{number} ");
    return number;
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
        int number = GeneratingRandomNumber();
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Sum of all digits of this random numbers is {sum}");
}
else
{
    for (int i = 0; i < n; i++)
    {
        int number = GeneratingRandomNumber();
        while (number > 0)
        {
            Console.Write(number % 10);
            number /= 10;
        }
        Console.WriteLine();
    }
}