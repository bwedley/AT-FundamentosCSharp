using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex01
    {

        //exemplo de como eu faria, caso o exercício 1 pedisse com classe
        private string _nome;

        public string Nome { get => _nome; set => _nome = value; }

        public void ExibirDados()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }
    }
}
