using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex06
    {
        private string _nome;
        private string _matricula;
        private string _curso;
        private decimal _media;

        public string Nome { get => _nome; set => _nome = value; }
        public string Matricula { get => _matricula; set => _matricula = value; }
        public string Curso { get => _curso; set => _curso = value; }
        public decimal Media { get => _media; set => _media = value; }

        public void ExibirDados()
        {
            Console.WriteLine("Dados do aluno: ");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Média: {Media}");
        }

        public void VerificarAprovacao()
        {
            if (Media >= 7)
                Console.WriteLine("Aprovado");
            else
                Console.WriteLine("Reprovado");
        }
    }
}
