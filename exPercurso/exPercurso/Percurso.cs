using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exPercurso
{
    class Percurso
    {

        private double kmPercorrida;
        private double valorCombustivel;
        private double valorPedagio;


        public double GetKmPercorrida()
        {
            return kmPercorrida;
        }

        public void SetKmPercorrida(double KmPercorrida)
        {
            kmPercorrida = KmPercorrida;
        }

        public double GetValorCombustivel()
        {
            return valorCombustivel;
        }
        public void SetValorCombustivel(double ValorCombustivel)
        {
            valorCombustivel = ValorCombustivel;
        }

        public double GetValorPedagio()
        {
            return valorPedagio;
        }  

        public void SetValorPedagio(double ValorPedagio)
        {
            valorPedagio = ValorPedagio;
        }

        public Percurso()
        {
            kmPercorrida = 0;
            valorCombustivel = 0;
            valorPedagio = 0;
        }

        public Percurso(double KmPercorrida, double ValorCombustivel, double ValorPedagio)
        {
            kmPercorrida = KmPercorrida;
            valorCombustivel = ValorCombustivel;
            valorPedagio = ValorPedagio;
        }
        public string listarPercurso()
        {
           return "KmPercorrida = " + GetKmPercorrida() + "\nValorCombustível = " + GetValorCombustivel() +
                "\nValorPedagio = " + GetValorPedagio() ;
        
        }
    }
}
