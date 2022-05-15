using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class MatrBubl
    {
        public int[][] Array { get; set; }

        public MatrBubl(int[][] a)
        {
            Array = a;
        }

        public void Show()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void BubbleSort(Func<int, int, bool> comp, Func<int[], int> p)
        {
            int[] temp;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (comp(p(Array[i]), p(Array[j])))
                    {
                        temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;

                    }
                }
            }
        }


    }


    public static class Operat
    {
        public static int Sum(int[] ar)
        {
            int s = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                s += ar[i];
            }
            return s;
        }

        public static int Max(int[] ar)
        {
            int m = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > m) m = ar[i];
            }
            return m;

        }

        public static int Min(int[] ar)
        {
            int m = 100000;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < m) m = ar[i];
            }
            return m;

        }
    }
}
