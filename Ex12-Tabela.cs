using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex12_Tabela : FormatarContatos_Ex12
    {
        public override void ExibirContatos(List<Ex12_CadastroContatosFormatados> contatos)
        {
            Console.WriteLine($"{"NOME",-20} | {"TELEFONE",-15} | {"EMAIL",-25}");
            Console.WriteLine("-----------------------------------------------------------------");

            foreach(var c in contatos)
            {
                Console.WriteLine($"{c.Nome,-20} | {c.Telefone,-15} | {c.Email,-25}");
            }
        }
    }
}
