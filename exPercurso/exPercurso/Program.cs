using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exPercurso
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Custos c = new Custos();
            Percurso p = new Percurso();

            while (true)
            {

                Console.Clear();
                Console.WriteLine("Informe a opção desejada: \n 1 - Novo percurso " +
                "\n 2 - Listar percurso \n 3 - Calcular custos \n 0 - Sair");
            double op = int.Parse(Console.ReadLine());
                Console.Clear();
            switch (op)
            {
                    
                case 1:

                    Console.WriteLine("Informe a Kilometragem Percorrida");
                    p.SetKmPercorrida(Double.Parse(Console.ReadLine()));

                    Console.WriteLine("Informe o valor do Combustivel");
                    p.SetValorCombustivel(Double.Parse(Console.ReadLine()));

                    Console.WriteLine("Informe o custo do Pedagio");
                    p.SetValorPedagio(Double.Parse(Console.ReadLine()));
                    break;
                case 2:

                    Console.WriteLine(p.listarPercurso());
                    break;

                case 3:

                    Console.WriteLine(c.calcularViagem(p));

                    break;

                case 0:
                    Environment.Exit(0);
                    break;
                        
            }
            Console.ReadKey();


            }
        }
    }
}
