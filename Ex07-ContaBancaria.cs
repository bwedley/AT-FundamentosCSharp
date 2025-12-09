using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex07_ContaBancaria
    {
        private string _titular;
        private decimal _saldo;

        public string Titular { get => _titular; set => _titular = value; }
        
        public decimal Saldo { get => _saldo; set => _saldo = value; }

        public void Depositar(decimal valor)
        {
            if(valor < 0)
            {
                Console.WriteLine($"O valor do depósito deve ser positivo! Tentativa de valor R${valor}");
            }
            else 
            {
                Saldo = Saldo + valor;
                Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
            }
        }

        public void Sacar(decimal valor)
        {
            if(valor > Saldo)
            {
                Console.WriteLine($"Saldo insuficiente para realizar o saque! Saldo atual R${Saldo}");
            }
            else
            {
                Saldo = Saldo - valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso!");
            }
        }
    }
}
