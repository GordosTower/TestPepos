using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trynagle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

               for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("SURMAN " );
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
