using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PadariaSonho.Funcionarios;

namespace PadariaSonho
{
    public class GerenciadorDeAumentos
    {
        private double _totalDeAumentos;

        public void CadastrarAumento(Funcionario funcionario)
        {
            _totalDeAumentos += funcionario.AumentoAnual();
        }

        public double AumentoTotalAnual()
        {
            return _totalDeAumentos;
        }

    }
}
