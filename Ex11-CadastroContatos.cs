using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex11_CadastroContatos
    {
        private string _nome;
        private string _telefone;
        private string _email;

        public string Nome { get => _nome; set => _nome = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Email { get => _email; set => _email = value; }

        
        public Ex11_CadastroContatos() { }

        public Ex11_CadastroContatos(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public virtual void MenuContatos()
        {
            List<Ex11_CadastroContatos> contatos = new List<Ex11_CadastroContatos>();
            Arquivo a = new Arquivo("contatos-BrunoWedley");

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
                            Ex11_CadastroContatos c = new Ex11_CadastroContatos();
                            Console.WriteLine("Digite o nome do contato: ");
                            c.Nome = Console.ReadLine();
                          
                            Console.WriteLine("Digite o telefone: ");
                            c.Telefone = Console.ReadLine();
                               
                            Console.WriteLine("Digite o E-mail: ");
                            c.Email = Console.ReadLine();

                            //p.PrecoUnitario = decimal.Parse(Console.ReadLine());
                            a.GravarContatos(c);
                            a.FecharArquivo();

                            contatos.Add(c);
                            Console.WriteLine($"contato {c.Nome} cadastrado com sucesso!");
                            break;

                        case 2:
                            contatos = a.LerContatos();
                            if (contatos.Count == 0) Console.WriteLine("Não existem cadastros no sistema");
                            else
                                foreach (Ex11_CadastroContatos co in contatos)
                                {
                                    Console.WriteLine($"Nome: {co.Nome} | Telefone: {co.Telefone} | Email: {co.Email}");

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
