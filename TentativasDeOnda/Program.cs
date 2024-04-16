using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TentativasDeOnda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String wave = "▒";
            string added = "▒";
            while (true)
            {
                wave = "▒";
                for (int i = 0; i <= 15; i++)
                {
                    wave += added;
                    Console.WriteLine(wave);
                }
             }

        }
    }
}
