using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso p = new Proceso();//INSTANCIA Y LLAMADO DEL METODO ESPECILIDAD DE LA CLASE PROCESO
            p.Oracion();
            Console.ReadKey(true);
        }
    }
}
