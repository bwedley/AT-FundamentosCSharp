using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex08_CadastroFuncionario
    {
        private string _nome;
        private string _cargo;
        private decimal _salarioBase;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cargo { get => _cargo; set => _cargo = value; }
        public decimal SalarioBase { get => _salarioBase; set => _salarioBase = value; }

        public void ExibirDados()
        {
            Console.WriteLine("Dados do funcionário:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salario: {SalarioBase}");
        }

    }
}
