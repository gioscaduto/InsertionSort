using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro[] carros =
            {
                new Carro("Ferrari", 500_000),
                new Carro("Hilux", 150_000),
                new Carro("Gol", 40_000),
                new Carro("Onix", 40_000),
                new Carro("Mobi", 30_000)
            };

            ImprimeCarros(carros, "Carros");

            Ordena(carros, carros.Length);

            ImprimeCarros(carros, "Carros - Ordenados por Preço");

            Console.ReadLine();
        }

        private static void Ordena(Carro[] carros, int qtdElementos)
        {
            int analise;

            for (int atual = 1; atual < qtdElementos; atual++)
            {
                analise = atual;

                while (analise > 0 && carros[analise].Preco < carros[analise - 1].Preco)
                {
                    Troca(carros, analise, analise - 1);
                    analise--;
                }
            }
        }

        private static void Troca(Carro[] carros, int primeiro, int segundo)
        {
            Carro primeiroCarro = carros[primeiro];
            Carro segundoCarro = carros[segundo];
            carros[primeiro] = segundoCarro;
            carros[segundo] = primeiroCarro;
        }

        private static void ImprimeCarros(Carro[] carros, string titulo)
        {
            Console.WriteLine(titulo);
            foreach (var carro in carros)
            {
                Console.WriteLine(carro.ToString());
            }
            Console.WriteLine();
        }
    }
}
