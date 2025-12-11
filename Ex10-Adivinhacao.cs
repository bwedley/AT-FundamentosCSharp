using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex10_Adivinhacao
    {
        public void Adivinhar()
        {
            Console.WriteLine("Digite num número inteiro entre 1 e 50");
            int num = 0;
            int palpites = 1;

            Random random = new Random();
            int randomNum = random.Next(1, 51);

            while (num != randomNum && palpites <= 5)
            {
                Console.WriteLine($"\nEsse é seu palpite número: {palpites}");
                Console.WriteLine("Digite seu palpite: ");
                int.TryParse(Console.ReadLine(), out num);
                palpites++;

                if (num < randomNum && palpites <= 5)
                {
                    Console.WriteLine("O número aleatório é maior.");
                }
                else if(num > 50 || num < 0)
                {
                    Console.WriteLine("Digite um número entre 1 e 50");
                    palpites--;
                    //Aqui decidi por não contar como um palpite quando for fora do intervalo.
                }
                else if (num > randomNum && palpites <= 5)
                {
                    Console.WriteLine("O número aleatório é menor.");
                }
                else if (num == randomNum && palpites <= 5)
                {
                    Console.WriteLine($"Muito bem! Você acertou o número {randomNum} em {palpites} tentativas");
                }
                else if (palpites > 5)
                {
                    Console.WriteLine($"Infelizmente você chegou no limite de tentativas e não acertou o número, que era: {randomNum}");
                }
            }
        }
    }
}
