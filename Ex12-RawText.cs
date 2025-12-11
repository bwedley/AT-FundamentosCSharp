using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex12_RawText : FormatarContatos_Ex12
    {
        public override void ExibirContatos(List<Ex12_CadastroContatosFormatados> contatos)
        {
            Console.WriteLine("\n=== Lista de contatos ===");

            foreach (var c in contatos)
            {
                Console.WriteLine($"Nome: {c.Nome}, Telefone: {c.Telefone}, Email: {c.Email}");
            }
        }
    }
}
