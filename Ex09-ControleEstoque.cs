using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex09_ControleEstoque
    {
        public void MenuEstoque()
        {
            List<Ex09_Produto> produtos = new List<Ex09_Produto>();
            Arquivo a = new Arquivo("estoque-BrunoWedley");

            bool sair = false;
            while (produtos.Count < 5 && !sair)
            {
                Console.WriteLine("\nDigite um comando:");
                Console.WriteLine("1 - Inserir Produto:");
                Console.WriteLine("2 - Listar Produtos:");
                Console.WriteLine("3 - Sair");
                int opcao;
                string opcaoDigitada = Console.ReadLine();
                if (!int.TryParse(opcaoDigitada, out opcao)) Console.WriteLine("Opção inválida, se atende as opções");
                else
                    switch (opcao)
                    {

                        case 1:
                            a.CriarArquivo();
                            Ex09_Produto p = new Ex09_Produto();
                            Console.WriteLine("Digite o nome do produto: ");
                            p.Nome = Console.ReadLine();
                            int quantidade;
                            bool validarInt = false;
                            bool validarPreco = false;
                            decimal valor;
                            while (!validarInt)
                            {
                                Console.WriteLine("Digite a quantidade em estoque: ");
                                string input = Console.ReadLine();
                                if (int.TryParse(input, out quantidade)) validarInt = true;
                                else Console.WriteLine("Digite um valor inteiro!");
                                p.QtdeEstoque = quantidade;
                            }
                            while (!validarPreco)
                            {
                                Console.WriteLine("Digite o preço unitário: ");
                                string input = Console.ReadLine();
                                if (decimal.TryParse(input, out valor)) validarPreco = true;
                                else Console.WriteLine("Digite um valor decimal, separado por vírgula!");
                                p.PrecoUnitario = valor;
                            }

                            //p.PrecoUnitario = decimal.Parse(Console.ReadLine());
                            a.GravarProdutos(p);
                            a.FecharArquivo();

                            produtos.Add(p);
                            Console.WriteLine($"Produto: {p.Nome} cadastrado!");

                            if(produtos.Count >= 5) Console.WriteLine("Número máximo de produtos cadastrados. Fechando aplicação");
                            break;

                        case 2:
                            produtos = a.LerProdutos();
                            if(produtos.Count == 0) Console.WriteLine("Não existem produtos cadastrados no sistema");
                            else
                                foreach (Ex09_Produto pr in produtos)
                                {
                                    Console.WriteLine($"Produto: {pr.Nome} | Quantidade: {pr.QtdeEstoque} | Preço: R${pr.PrecoUnitario}");

                                }
                            break;
                        case 3:
                            sair = true;
                            Console.WriteLine("Fechando o programa...");
                            break;

                        default:
                            Console.WriteLine("Operação inválida");
                            break;

                    }
            }
        }
        
    }
}
