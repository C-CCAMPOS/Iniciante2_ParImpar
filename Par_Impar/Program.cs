using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int resultado = 0;

            Console.Write(">>>>> DEFINA SE O NÚMERO É PAR OU IMPAR<<<<<");

            Console.Write("\n\n\nDigite o número desejado: ");
            numero = Convert.ToInt32(Console.ReadLine());

            resultado = numero % 2;

            if (resultado == 1)
            {
                Console.Write("\n\nO número informado é Impar.");
            }
            else 
            {
                Console.Write("\n\nO número informado é Par.");
            }

            Console.Write("\n\n\n\n>>>>>Estou ficando bom nisso. hahaha<<<<<");

            Console.ReadKey();
        }
    }
}
