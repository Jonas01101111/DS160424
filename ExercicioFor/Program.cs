using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 9; i++)
            {
                Console.Write(i);
                for (int j = 1; j <= 9; j++)
                {
                    if (i != j)
                    {
                        Console.Write(j);
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
