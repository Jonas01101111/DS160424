using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalmenteTesteDeArraysMeu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var lista = new List<string> { };

            for (int i = 0; i < 10; i++)
            { 
            lista.Add(Console.ReadLine());
            }
            Console.Clear();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadKey();


        }
    }
}
