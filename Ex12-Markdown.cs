using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex12_Markdown : FormatarContatos_Ex12
    {
        public override void ExibirContatos(List<Ex12_CadastroContatosFormatados> contatos)
        {
            Console.WriteLine("\n## Lista de contatos em markdown\n");

            foreach (var c in contatos)
            {
                Console.WriteLine($"- **Nome:** {c.Nome}");
                Console.WriteLine($"- Telefone: {c.Telefone}");
                Console.WriteLine($"- Email: {c.Email}\n");
            }
        }
    }
}
