using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex03
    {
        private int _n1;
        private int _n2;
        private string _calculo;
        private int resultado;

        public int N1 { get => _n1; set => _n1 = value; }
        public int N2 { get => _n2; set => _n2 = value; }
        public string Calculo { get => _calculo; set => _calculo = value; }

        public void CalcularValor()
        {
            // Bloco de try/catch com validação de exceção para permitir apenas números inteiros
            try
            {
                Console.WriteLine("Digite o primeiro número: ");
                N1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                N2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha uma operação para realizar: ");
            } catch (FormatException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
                return;
            }

            // Aqui julguei não se fazer necessária nem uma validação pois dentro do switch já existe uma validação implicita dentro do default.
            Console.WriteLine("1 - Soma; 2 - Subtração; 3 - Multiplicação; 4 - Divisão");
            Calculo = Console.ReadLine();
            switch(Calculo)
            {
                case "1":
                    resultado = N1 + N2;
                    break;
                case "2":
                    resultado = N1 - N2;
                    break;
                case "3":
                    resultado = N1 * N2;
                    break;
                case "4":
                    if(N2 != 0) resultado = N1 / N2;
                    else Console.WriteLine("Divisão por zero não permitida");
                    break;
                default:
                    Console.WriteLine("Por favor digite uma operação válida...");
                    break;
            }
            Console.WriteLine($"Resultado: {resultado}");
        }

    }
}
