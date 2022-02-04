using System;

namespace ZampolloEsercizio1StringheApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string parola;
            
            int N;
            int i = 0;
            int contavocale = 0;
            int contaconsonante = 0;

            Console.WriteLine("Inserisci numero N di parole da analizzare: ");
            N = Convert.ToInt32(Console.ReadLine());


            while (i <= N)
            {
                Console.WriteLine("Inserisci parola:");
                parola = Console.ReadLine();

                char carattere = parola[0];

                if(carattere == 'a')
                {
                    contavocale++;
                }

                if (carattere == 'e')
                {
                    contavocale++;
                }

                if (carattere == 'i')
                {
                    contavocale++;
                }


                if (carattere == 'o')
                {
                    contavocale++;
                }


                if (carattere == 'u')
                {
                    contavocale++;
                }


                else
                {
                    contaconsonante++;
                }
                i++;
            }

            Console.WriteLine($"Il numero di parole che iniziano con una vocale sono {contavocale}");
            Console.WriteLine($"Il numero di parola che iniziano con una consonante sono {contaconsonante}");
        }
    }
}
