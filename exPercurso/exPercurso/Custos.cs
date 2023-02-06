using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exPercurso
{
    class Custos
    {
        Percurso p = new Percurso();
        public string calcularViagem(Percurso p)
        {
            double totalPercurso = (p.GetKmPercorrida() * p.GetValorCombustivel()) + p.GetValorPedagio();

            return p.listarPercurso()+ "\nTotalPercurso = " + totalPercurso.ToString();       
        }

        
    }
}
