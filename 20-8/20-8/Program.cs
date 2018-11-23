using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();
            Arbol2 arbol2 = new Arbol2();        
            // ELEMENTOS DEL ARBOL A
            //  -1,0,2,-2,3,6,-3,5,1,4
            //ELEMENTOS DEL ARBOL B
            //- 1,7,4,11,5,-8,15,-3,-2,6,10,3, 
            Console.WriteLine("Ejercicio 8 \nArbol A ");
            arbol.ArbolA();
            Console.WriteLine("Arbol B ");
            arbol2.ArbolB();
            Console.ReadKey();

        }
    }
}
