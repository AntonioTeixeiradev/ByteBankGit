using PadariaSonho.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaSonho
{
    public class GerenciadorDeBonus
    {
        private double _totalBonificacao;

        public void CadastrarBonus(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao(); 
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }

}
