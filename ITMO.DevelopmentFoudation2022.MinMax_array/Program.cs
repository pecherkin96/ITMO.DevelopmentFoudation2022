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
            int Min = M[1];
            int Max = M[1];
            for (int i = 2; i <= n; i + 1)
            {
                if(Max < M[i])
                {
                    Max = M[i];
                    indMax = i;
                }
                if(Min > M[i])
                {
                    Min = M[i];
                    indMin = i;
                }
            }
        }
    }
}
