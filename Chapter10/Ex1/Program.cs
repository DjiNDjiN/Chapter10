using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void PrintNumbers(int[] n, int iter)
        {
            if (iter >= n.Length)
            {
                foreach (int element in n)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= n.Length; i++)
                {
                    n[iter] = i;
                    PrintNumbers(n, iter + 1);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (numberOfLoops < 1)
            {
                throw new ArgumentException("Number of loops should be 1 or higher.");
            }
            int[] arr = new int[n];
            PrintNumbers(arr, 0);
        }

    }
}
