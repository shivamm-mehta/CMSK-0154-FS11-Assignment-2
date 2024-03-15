class Program
{
    static void Main(string[] args)
    {
        int sumEven = 0;
        int sumOdd = 0;

        for (int num = 0; num < 10; num++)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even");
                sumEven += num;
            }
            else
            {
                Console.WriteLine($"{num} is an odd");
                sumOdd += num;
            }
        }

        Console.WriteLine($"Total of even numbers: {sumEven}");
        Console.WriteLine($"Total of odd numbers: {sumOdd}");
    }
}
