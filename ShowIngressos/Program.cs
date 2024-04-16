using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowIngressos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = 0; //$$
            string caso = "insira texto";
            int contmeia = 0;
            int contint= 0;
            for (int lote = 1; lote <= 30; lote++)
            {
                Console.WriteLine("Ingresso número: "+lote+ "\nMeia S/N");
                caso = Console.ReadLine().ToLower();


                switch (caso)
                {
                    case "s":
                        if (lote <= 10)
                        {
                            money += 100/2;
                            contmeia++;
                        }
                        else if (lote <= 20 && lote >= 10)
                        {
                            money += 150/2;
                            contmeia++;
                        }
                        else if (lote <= 30 && lote >= 20)
                        {
                            money += 200 / 2;
                            contmeia++;
                        }
                        break;
                    case "n":
                        if (lote <= 10)
                        {
                            money += 100;
                            contint++;
                        }
                        else if (lote <= 20 && lote >= 10)
                        {
                            money += 150;
                            contint ++;
                        }
                        else if (lote <= 30 && lote >= 20)
                        {
                            money += 200;
                            contint ++;
                        }
                        break;
                
                }
                Console.Clear();
            }
            Console.WriteLine("Total arrecadado: "+ money.ToString("C"));
            Console.WriteLine("Quantidade de meios ingresssos: "+ contmeia);
            Console.WriteLine("Quantidade de ingressos inteiros: " + contint);

            Console.ReadKey();
        }
    }
}
