using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso Op = new Proceso();//INSTANCIA DE OBJETO 
            Op.GrafoA();//LLAMADA DEL Los 4 Grafos
            Op.GrafoB();
            Op.GrafoC();
            Op.GrafoD();
            Console.ReadKey(true);
        }
    }
}
