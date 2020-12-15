using System;

namespace HelloTraingle
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j, k, l, n;

            n = 5;
            char[] input = { 'H', 'e', 'l', 'l', 'o' };
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 0; k <= ((i - 1) * 2); k++)
                {
                    if (k == 0 || k == ((i-1)*2))
                    {
                        Console.Write(input[i - 1]);
                    }
                    else if(n == i)
                    {
                        if (k % 2 == 0)
                         Console.Write(input[i - 1]);
                        else
                            Console.Write(" ");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("\n");
            }

        }
    }
}
