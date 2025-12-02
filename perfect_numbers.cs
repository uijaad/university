using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter First Number : ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("\n");
        for (int i = n1; i <= n2; i++)
        {
            int sum = 0;
            for (int j = 1; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    sum += j;
                }
            }
            if (sum == i)
            {
                Console.WriteLine(i + " Is Perfect Number");
            }
        }
        Console.Write("\n");
    }
}
