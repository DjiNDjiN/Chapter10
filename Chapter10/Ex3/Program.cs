using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Variations(int[] output, int n, int iter, int start)
        {
            if (iter >= output.Length)
            {
                foreach (int value in output)
                {
                    Console.Write(valuе + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    output[iter] = i;
                    Variations(output, n, iter + 1, i);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Variations(arr, n, 0, 1);
        }
    }

}
