using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter First Number : ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        int n2 = int.Parse(Console.ReadLine());
        for (int x = n1; x <= n2; x++)
        {
            bool isPrime = true;
            if (x < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i * i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime Number : " + x);
            }
        }
    }
    
}
