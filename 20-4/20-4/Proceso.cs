using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_4
{
    public class Proceso
    {
        public void Fruta()
        {
            Console.WriteLine("<<<<<<< Arbol Binario >>>>>>>>");
            Arbol Arbol = new Arbol(); //Se crea un objeto de la clase arbol
            //Se insertan datos en nuestro arbol
            Arbol.Insertar(0);
            Arbol.Insertar(1);
            Arbol.Insertar(2);
            Arbol.Insertar(3);
            Arbol.Insertar(4);
            Arbol.Insertar(5);
            Arbol.Insertar(6);
            //Impresion en preorden
            Console.WriteLine("Impresion preorden: \n");
            Arbol.ImprimirPre();
            //Impresion en entreorden
            Console.WriteLine("\nImpresion inorden: \n");
            Arbol.ImprimirEntre();
            //Impresion en postorden
            Console.WriteLine("\nImpresion postorden: \n");
            Arbol.ImprimirPost();
            Console.ReadKey();
        }
    }
}
