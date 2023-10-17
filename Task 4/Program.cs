using System;

class Program
{
    static void SieveOfEratosthenes(int n)
    {
       
        bool[] primes = new bool[n + 1];
        for (int i = 0; i <= n; i++)
        {
            primes[i] = true;
        }

        primes[0] = primes[1] = false;

        
        for (int p = 2; p * p <= n; p++)
        {
            if (primes[p] == true)
            {
                
                Console.WriteLine(p);

                
                for (int i = p * p; i <= n; i += p)
                {
                    primes[i] = false;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers in the range [1, " + n + "]:");
        SieveOfEratosthenes(n);
    }
}
