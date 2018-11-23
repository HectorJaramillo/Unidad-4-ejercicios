using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_3
{
    public class Proceso
    {
        public void Arbolico()
        {
            Arbol ab = new Arbol();
            Nodo raiz = ab.Insertar(6, null);  //INGRESO LOS NODOS AL ARBOL                              
            ab.Insertar(3, raiz);
            ab.Insertar(9, raiz);
            ab.Insertar(2, raiz);
            ab.Insertar(1, raiz);
            ab.Insertar(4, raiz);
            ab.Insertar(5, raiz);
            ab.Insertar(7, raiz);
            ab.Insertar(8, raiz);
            ab.Insertar(10, raiz);
            ab.Insertar(11, raiz);
            Console.WriteLine("Arbol Binario 3");
            ab.Impresion(raiz); //IMPRESION DEL ARBOL NORMAL
            Console.WriteLine("\nRecorridos Realizados\n");
            ab.OrdenacionConNombreLargo(raiz); // EMPRIME LOS NUMEROS EN ORDEN  DE ESTREMO A EXTREMOS
            Console.WriteLine("\n");
            ab.PreOrden(raiz); //IMPRIME NODOS DE LA IZQUIERDA Y LOS DE LA DERECHA PARA FINALIZAR CON LA RAIZ 
            Console.ReadKey();
        }
    }
}
