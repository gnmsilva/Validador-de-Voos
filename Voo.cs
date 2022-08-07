using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MAPA_ALP1
{
    /// <summary>
    /// Classe contendo construtores e todos os métodos utilizados para calculos e validações
    /// </summary>
    public class Voo
    {
        /// <summary>
        /// Construtor que chamará o método ValidaVoo assim que iniciar um objeto da classe
        /// </summary>
        /// <param name="trechoPlanejado">Trecho planejado do voo</param>
        /// <param name="trechoAlternativo">Trecho alternativo do voo</param>
        /// <param name="consumoMedio">Consumo médio da aeronave</param>
        /// <param name="combustivelExistente">Combustível já presente na aeronave</param>
        /// <param name="capacidadeMaxima">Capacidade máxima do tanque da aeronave</param>
        public Voo(double trechoPlanejado, double trechoAlternativo, double consumoMedio, double combustivelExistente, double capacidadeMaxima)
        {
            ValidaVoo(trechoPlanejado, trechoAlternativo, consumoMedio, combustivelExistente, capacidadeMaxima);
        }

        /// <summary>
        /// Cálculo do trecho total
        /// </summary>
        /// <param name="trechoPlanejado">Trecho planejado do voo</param>
        /// <param name="trechoAlternativo">Trecho alternativo do voo</param>
        /// <returns>Retorna a soma do trecho planejado e alternativo</returns>
        private double TrechoTotal(double trechoPlanejado, double trechoAlternativo)
        {
            return trechoPlanejado + trechoAlternativo;
        }

        /// <summary>
        /// Cálculo do trecho total com a margem de segurança
        /// </summary>
        /// <param name="trechoPlanejado">Trecho planejado do voo</param>
        /// <param name="trechoAlternativo">Trecho alternativo do voo</param>
        /// <returns>Retorna o trecho total multiplicado pelo percentual de segurança</returns>
        private double Margem(double trechoPlanejado, double trechoAlternativo)
        {
            return TrechoTotal(trechoPlanejado, trechoAlternativo) * 1.3; 
        }

        /// <summary>
        /// Cálculo do combustivel necessário para o trajeto total
        /// </summary>
        /// <param name="trechoPlanejado">Trecho planejado do voo</param>
        /// <param name="trechoAlternativo">Trecho alternativo do voo</param>
        /// <param name="consumoMedio">Consumo médio da aeronave</param>
        /// <returns>Retorna o total do trecho multiplicado pelo consumo médio</returns>
        private double CombustivelNecessario(double trechoPlanejado, double trechoAlternativo, double consumoMedio)
        {
            return Margem(trechoPlanejado, trechoAlternativo) * consumoMedio;
        }

        /// <summary>
        /// Cálculo do combustível necessário a ser abastecido
        /// </summary>
        /// <param name="trechoPlanejado">Trecho planejado do voo</param>
        /// <param name="trechoAlternativo">Trecho alternativo do voo</param>
        /// <param name="consumoMedio">Consumo médio da aeronave</param>
        /// <param name="combustivelExistente">Combustível já presente na aeronave</param>
        /// <returns>Retorna a subtração do combustivel necessário com o existente</returns>
        private double AbastecimentoNecessario(double trechoPlanejado, double trechoAlternativo, double consumoMedio, double combustivelExistente)
        {
            return CombustivelNecessario(trechoPlanejado, trechoAlternativo, consumoMedio) - combustivelExistente;
        }

        /// <summary>
        /// Realiza a validação do voo de acordo com os métodos anteriores
        /// O combustível necessário para o trecho com margem de segurança não pode ser maior que a capacidade máxima da aerovane
        /// </summary>
        /// <param name="trechoPlanejado"></param>
        /// <param name="trechoAlternativo"></param>
        /// <param name="consumoMedio"></param>
        /// <param name="combustivelExistente"></param>
        /// <param name="capacidadeMaxima"></param>
        private void ValidaVoo(double trechoPlanejado, double trechoAlternativo, double consumoMedio, double combustivelExistente, double capacidadeMaxima)
        {
            //Imprimindo mensagem de validação com timer
            MensagemAguardar();
            
            // Se o combustivel total é maior que a capacidade máxima da aeronave
            // o voo não é aprovado avisando o usuário, senão é aprovado e imprime informações do voo.
            if (CombustivelNecessario(trechoPlanejado, trechoAlternativo, consumoMedio) > capacidadeMaxima)
            {
                //Mensagem que o voo foi reprovado
                Cabecalho();
                Console.WriteLine("Voo reprovado! Reveja o planejamento." +
                    $"\n\nPara o trejeto é necessário ao menos {CombustivelNecessario(trechoPlanejado, trechoAlternativo, consumoMedio)} litros." +
                    "\n\nReinicie o programa para um novo cálculo!\n");
            }
            else
            {
                //Mensagem de voo aprovado e informações
                Cabecalho();
                Console.WriteLine($"Voo aprovado!\n\n" +
                    $"Seguem abaixo as informações:" +
                    $"\n\n- O trecho planejado é de {trechoPlanejado} km." +
                    $"\n- O trecho alternativo é de {trechoAlternativo} km." +
                    $"\n- O total com margem de segurança (+30%) é de {Margem(trechoPlanejado, trechoAlternativo)} km" +
                    $"\n- O total de combustível necessário para o trecho é de {CombustivelNecessario(trechoPlanejado, trechoAlternativo, consumoMedio)} litros." +
                    $"\n- O abastecimento necessário é de {AbastecimentoNecessario(trechoPlanejado, trechoAlternativo, consumoMedio, combustivelExistente)} litros.\n");
            }
        }

        /// <summary>
        /// Reseta o console e imprime um cabeçalho para a aplicação
        /// </summary>
        public static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine($"{string.Concat(Enumerable.Repeat('=', 50))}" +
                $"\n{"Validador de Voos",32}" +
                $"\n{string.Concat(Enumerable.Repeat('=', 50))}\n");
        }

        /// <summary>
        /// Chama o cabeçalho e imprime que esta validando o voo com timer
        /// </summary>
        public static void MensagemAguardar()
        {
            Cabecalho();
            Console.Write("Estamos validando seu voo .");
            Thread.Sleep(1000);
            Console.Write(" .");
            Thread.Sleep(1000);
            Console.Write(" .");
            Thread.Sleep(1000);
        }

    }
}
