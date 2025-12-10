using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    internal class Ex08_Gerente : Ex08_CadastroFuncionario
    {
        const decimal ValorBonusGerente = 1.2m;
        public Ex08_Gerente()
        {
            Cargo = "Gerente";
        }

        public void BonusGerente()
        {
            SalarioBase *= ValorBonusGerente;
        }
        
    }
}
