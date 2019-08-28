using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j < 7; j++)
                {
                    k = i + j;

                }
                

            }
                    Console.Write(k);

            Console.ReadLine();
        }
    }
}
