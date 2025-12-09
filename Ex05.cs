using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex05
    {
        private DateTime _dataFormatura;
        private DateTime _dataAtual;

        public DateTime DataFormatura { get => _dataFormatura; set => _dataFormatura = value; }
        public DateTime DataAtual { get => _dataAtual; set => _dataAtual = value; }

        public void TempoRestante()
        {
            if (DataAtual > DataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
                return;
            }

            int anos = DataFormatura.Year - DataAtual.Year;
            int meses = DataFormatura.Month - DataAtual.Month;
            int dias = DataFormatura.Day - DataAtual.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(DataAtual.Year, DataAtual.Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;

            }

            Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para a sua formatura.");

            if(anos == 0 && meses < 6)
            {
                Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
            }
        }
    }
}
