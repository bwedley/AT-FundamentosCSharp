using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex09_Produto
    {
        private string _nome;
        private int _qtdeEstoque;
        private decimal _precoUnitario;

        public Ex09_Produto(string nome, int qtdeEstoque, decimal precoUnitario)
        {
            Nome = nome;
            QtdeEstoque = qtdeEstoque;
            PrecoUnitario = precoUnitario;
            
        }

        public Ex09_Produto()
        {

        }

        public string Nome { get => _nome; set => _nome = value; }
        public int QtdeEstoque { get => _qtdeEstoque; set => _qtdeEstoque = value; }
        public decimal PrecoUnitario { get => _precoUnitario; set => _precoUnitario = value; }
       
    }
}
