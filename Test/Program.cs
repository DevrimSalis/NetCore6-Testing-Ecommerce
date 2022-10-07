using System;
using System.Collections.Generic;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 3, 1, 5, 2 };

            int f = FirstDuplicate(a);

            Console.ReadLine();

        }

        static int FirstDuplicate(int[] a)
        {

            int[] answer = new int[2];
            answer[0] = -1;
            answer[1] = a.Length;
            for (int i = 0; i < a.Length - 1; i++)
            for (int j = i; j < a.Length; j++)
                if (a[i] == a[j] && i != j)
                {
                    if (i < answer[1])
                    {
                        answer[0] = a[i];
                        answer[1] = j;
                        break;

                    }
                }

            return answer[0];
        }
    }
}
