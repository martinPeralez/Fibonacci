using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentFib = 0;
            int nextFib = 1;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(currentFib);
                int nextNextFib = currentFib + nextFib;
                currentFib = nextFib;
                nextFib = nextNextFib;
            }
        }
    }
}
