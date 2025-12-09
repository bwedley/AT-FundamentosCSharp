using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex02
    {
        private string _nome;

        public string Nome { get => _nome; set => _nome = value; }

        public void TransformarNome()
        {
            char[] palavra =  Nome.ToCharArray();
            
            for(int i = 0; i< palavra.Length; i++)
            {
                char letraAtual = palavra[i];

                if (letraAtual == 'ç') letraAtual = 'c';
                if (letraAtual == 'Ç') letraAtual = 'C';

                if (letraAtual == ' ') continue;
                if(!char.IsLetter(letraAtual)) continue;

                char inicio = char.IsUpper(letraAtual) ? 'A' : 'a';

                int posicao = letraAtual - inicio;

                int novaPosicao = (posicao + 2) % 26;

                char novaLetra = (char)(inicio + novaPosicao);

                palavra[i] = novaLetra;
            }
            string nomeResultante = new string(palavra);

            Console.WriteLine($"Resultado final: {nomeResultante}");
        }
    }
}
