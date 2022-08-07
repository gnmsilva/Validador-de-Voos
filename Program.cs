using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MAPA_ALP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarando as variaveis necessárias
            double consumoMedio;
            double capacidadeMaxima;
            double trechoPlanejado; 
            double trechoAlternativo;
            double combustivelExistente;

            //
            while (true)
            {
                // Inicializando cabeçalho para o programa
                Cabecalho();
                Console.WriteLine("Informe a seguir as informações do voo:\n");

                // Solicitando as informações necessário para a validação do voo.
                // Try para caso o usuário digite algo inválido, informe na tela
                // e recomece.
                try
                {
                    Console.Write("Qual o consumo médio da aerovave [L/km]: ");
                    consumoMedio = double.Parse(Console.ReadLine());

                    Console.Write("Qual a capacidade máxima do tanque [L]: ");
                    capacidadeMaxima = double.Parse(Console.ReadLine());

                    Console.Write("Qual o trecho planejado [km]: ");
                    trechoPlanejado = double.Parse(Console.ReadLine());

                    Console.Write("Qual o trecho alternativo [km]: ");
                    trechoAlternativo = double.Parse(Console.ReadLine());

                    Console.Write("Qual a quantidade de combustivel ja existente na aeronave [L]: ");
                    combustivelExistente = double.Parse(Console.ReadLine());

                    break;

                }
                catch (Exception)
                {
                    // Informa que digitou algo inválido
                    Cabecalho();
                    Console.WriteLine("Informação inválida!\n" +
                        "\nTente novamente.\n");
                    Thread.Sleep(1500);
                   
                }
            }

            // Após as informações, inicia um novo objeto 'Voo'
            // passando os parâmentro necessários (informados pelo usuário)
            Voo voo1 = new Voo(trechoPlanejado, trechoAlternativo, consumoMedio, combustivelExistente, capacidadeMaxima);

        }

        /// <summary>
        /// Chama o cabeçalho e imprime que esta validando o voo com timer
        /// </summary>
        public static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine($"{string.Concat(Enumerable.Repeat('=', 50))}" +
                $"\n{"Validador de Voos",32}" +
                $"\n{string.Concat(Enumerable.Repeat('=', 50))}\n");
        }

    }
}
