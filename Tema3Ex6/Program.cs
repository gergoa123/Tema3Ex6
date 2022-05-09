using System;

namespace Tema3Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul");
            int numar = int.Parse(Console.ReadLine());
            int i = 1;
            int aux = 0;

            while (i != numar)
            {
                if (numar % i == 0)
                {
                    aux = aux + 1;
                }

                i++;
            }

            if (aux == 1)
            {
                Console.Write(numar + " Este numar prim!");
            }
            else
            {
                Console.Write(numar + " Nu este numar prim!");
            }



        }
    }
}
