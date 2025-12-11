using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AT
{
    internal class Arquivo
    {
        private string _nome;
        private StreamWriter _sw;
        private StreamReader _sr;

        public string Nome
        {
            get => _nome;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
            }
        }

        public Arquivo (string nome)
        {
            Nome = nome;
        }

        public void CriarArquivo()
        {
            _sw = new StreamWriter($"C:\\ArquivoTesteATCSharp\\{Nome}.txt", true);
        }

        public void FecharArquivo()
        {
            _sw.Close();
        }

        public void LerArquivo()
        {
            string linha;
            _sr = new StreamReader($"C:\\ArquivoTesteATCSharp\\{Nome}.txt");
            linha = _sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = _sr.ReadLine();
            }
            _sr.Close();
        }

        //=======================================Gravação e leitura dos produtos para exercício 9=======================================
        public void GravarProdutos(Ex09_Produto p)
        {
            string linha;
            linha = linha = p.Nome + "," + p.QtdeEstoque + "," + p.PrecoUnitario.ToString(CultureInfo.InvariantCulture);
            _sw.WriteLine(linha);
        }

        public List<Ex09_Produto> LerProdutos()
        {
            List<Ex09_Produto> produtos = new List<Ex09_Produto>();
            string caminho = $"C:\\ArquivoTesteATCSharp\\{Nome}.txt";
            if (!File.Exists(caminho))
            {
                return produtos;
            }

            _sr = new StreamReader(caminho);
            string linha = _sr.ReadLine();
            while (linha != null)
            {
                string[] campos = linha.Split(",");
                produtos.Add(new Ex09_Produto(campos[0], int.Parse(campos[1]), decimal.Parse(campos[2], CultureInfo.InvariantCulture)));
                linha = _sr.ReadLine();
            }
            _sr.Close();        
            return produtos;
        }

        //=======================================Gravação e leitura dos contatos para exercício 11=======================================
        public void GravarContatos(Ex11_CadastroContatos c)
        {
            string linha;
            linha = linha = c.Nome + "," + c.Telefone + "," + c.Email;
            _sw.WriteLine(linha);
        }

        public List<Ex11_CadastroContatos> LerContatos()
        {
            List<Ex11_CadastroContatos> contatos = new List<Ex11_CadastroContatos>();
            string caminho = $"C:\\ArquivoTesteATCSharp\\{Nome}.txt";
            if (!File.Exists(caminho))
            {
                return contatos;
            }

            _sr = new StreamReader(caminho);
            string linha = _sr.ReadLine();
            while (linha != null)
            {
                string[] campos = linha.Split(",");
                contatos.Add(new Ex11_CadastroContatos(campos[0], campos[1], campos[2]));
                linha = _sr.ReadLine();
            }
            _sr.Close();
            return contatos;
        }

        //=======================================Gravação e leitura dos contatos para exercício 12=======================================
        //Poderia ter utilizado a mesma gravação de contatos anterior, mas optei por usar uma nova para deixar os métodos separados

        public void GravarContatosEx12(Ex12_CadastroContatosFormatados c)
        {
            string linha;
            linha = linha = c.Nome + "," + c.Telefone + "," + c.Email;
            _sw.WriteLine(linha);
        }
        public List<Ex12_CadastroContatosFormatados> LerContatosEx12()
        {
            List<Ex12_CadastroContatosFormatados> contatos = new List<Ex12_CadastroContatosFormatados>();
            string caminho = $"C:\\ArquivoTesteATCSharp\\{Nome}.txt";
            if (!File.Exists(caminho))
            {
                return contatos;
            }

            _sr = new StreamReader(caminho);
            string linha = _sr.ReadLine();
            while (linha != null)
            {
                string[] campos = linha.Split(",");
                contatos.Add(new Ex12_CadastroContatosFormatados(campos[0], campos[1], campos[2]));
                linha = _sr.ReadLine();
            }
            _sr.Close();
            return contatos;
        }
    }
}
