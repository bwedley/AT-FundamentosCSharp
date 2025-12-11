using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex12_CadastroContatosFormatados : Ex11_CadastroContatos
    {
        public Ex12_CadastroContatosFormatados()
        {
        }

        public Ex12_CadastroContatosFormatados(string nome, string telefone, string email) : base(nome, telefone, email)
        {
        }

        public override void MenuContatos()
        {
            List<Ex11_CadastroContatos> contatos = new List<Ex11_CadastroContatos>();
            Arquivo a = new Arquivo("contatos-BrunoWedley-Ex12");

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\n=== Gerenciador de Contatos ===");
                Console.WriteLine("1 - Adicionar novo contato:");
                Console.WriteLine("2 - Listar contatos cadastrados:");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("Escolha uma opção: ");
                int opcao;
                string opcaoDigitada = Console.ReadLine();
                if (!int.TryParse(opcaoDigitada, out opcao)) Console.WriteLine("Opção inválida, se atende as opções");
                else
                    switch (opcao)
                    {

                        case 1:
                            a.CriarArquivo();
                            Ex12_CadastroContatosFormatados c = new Ex12_CadastroContatosFormatados();
                            Console.WriteLine("Digite o nome do contato: ");
                            c.Nome = Console.ReadLine();

                            Console.WriteLine("Digite o telefone: ");
                            c.Telefone = Console.ReadLine();

                            Console.WriteLine("Digite o E-mail: ");
                            c.Email = Console.ReadLine();

                            //p.PrecoUnitario = decimal.Parse(Console.ReadLine());
                            a.GravarContatosEx12(c);
                            a.FecharArquivo();

                            contatos.Add(c);
                            Console.WriteLine($"contato {c.Nome} cadastrado com sucesso!");
                            break;

                        case 2:
                            ListarContatos(a);
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
        private void ListarContatos(Arquivo arquivo) {
            List<Ex12_CadastroContatosFormatados> contatos = arquivo.LerContatosEx12();
            if(contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }

            Console.WriteLine("\nEscolha o formato de exibição:");
            Console.WriteLine("1 - Markdown");
            Console.WriteLine("2 - Tabela");
            Console.WriteLine("3 - Texto Puro");
            Console.Write("Opção: ");
            int opcao;
            string opcaoDigitada = Console.ReadLine();
            if (!int.TryParse(opcaoDigitada, out opcao)) Console.WriteLine("Opção inválida, se atende as opções");

            FormatarContatos_Ex12 formatador;

            switch(opcao)
            {
                case 1: formatador = new Ex12_Markdown(); 
                    break;
                case 2: formatador = new Ex12_Tabela();
                    break;
                default: formatador = new Ex12_RawText();
                    break;
                
            }
            formatador.ExibirContatos(contatos);

        }
    }
}
