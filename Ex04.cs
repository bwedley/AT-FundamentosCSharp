using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex04
    {
        public void DataNascimento()
        {
            Console.WriteLine("Digite sua data de nascimento: (dd/mm/aaaa)");
            DateTime data;
            DateTime.TryParse(Console.ReadLine(), out data);

            DateTime diaHoje = DateTime.Today;
            DateTime proxAniversario = new DateTime(diaHoje.Year, data.Month, data.Day);

            if (proxAniversario < diaHoje)
            {
                proxAniversario = proxAniversario.AddYears(1);
            }

            int diasAteAniversario = (proxAniversario - diaHoje).Days;

            if(diasAteAniversario < 7)
            {
                Console.WriteLine("Já começaram os preparativos? Falta menos de 1 semana!!!");
                return;
            }
            Console.WriteLine($"Faltam {diasAteAniversario} dias para o próximo aniversário");
        }
    }
}
