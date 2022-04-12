using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.DevelopmentFoudation2022.MinMax_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] M = new int[] { 11, 4, 34, 10, 19, 7, 9, 26 };
            int Min = M[1];
            int Max = M[1];
            for (int i = 2; i <= M.Length - 1; i ++)
            {
                if(Max < M[i])
                {
                    Max = M[i];
                }
                if(Min > M[i])
                {
                    Min = M[i];
                }
            }
            Console.WriteLine(Max);
            Console.WriteLine(Min);
        }
    }
}
