using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_9
{
    public class Proceso
    {
        public void GrafoA()
        {
            Grafo grafito = new Grafo(8);//AGREGO LA CANTIDAD DE VERTICES+1 NO SE PORQUE HAHA SALUDOS
            Console.WriteLine("Grafo A");
            Console.WriteLine("Nodos Fuertemente Conexos: ");
            grafito.AñadirFinal(0, 4);//AGREGO LAS CONEXIONES EXISTENTES EN EL GRAFO
            grafito.AñadirFinal(4, 1);
            grafito.AñadirFinal(1, 0);
            /*grafito.AñadirFinal(1, 2); //OTRAS CONEXIONES DEL GRAFO QUE NO SON FUERTEMENTE CONEXAS
            grafito.AñadirFinal(3, 1);
            grafito.AñadirFinal(3, 4);
            grafito.AñadirFinal(3, 2);
            */
            grafito.DFS(0);//INDICO DESDE QUE POSICION INICIARE EL GRAFO          
        }
        public void GrafoB()//Solo agregue los nodos conexos
        {
            Grafo grafito = new Grafo(5);//AGREGO LA CANTIDAD DE VERTICES+1 NO SE PORQUE HAHA SALUDOS
            Console.WriteLine("\nGrafo B");
            Console.WriteLine("Nodos Fuertemente Conexos:");
            grafito.AñadirFinal(2, 3);//AGREGO LAS CONEXIONES EXISTENTES EN EL GRAFO
            grafito.AñadirFinal(3, 4);//
            grafito.DFS(2);//INDICO DESDE QUE POSICION INICIARE EL GRAFO
        }
        public void GrafoC()//solo agregue los nodos conexos
        {
            //a,d,b,e,a
            Grafo grafito = new Grafo(10);//AGREGO LA CANTIDAD DE VERTICES+1 NO SE PORQUE HAHA SALUDOS
            Console.WriteLine("\nGrafo C");
            Console.WriteLine("Nodos Fuertemente Conexos:");
            grafito.AñadirFinal(0, 8);//AGREGO LAS CONEXIONES EXISTENTES EN EL GRAFO
            grafito.DFS(0);//INDICO DESDE QUE POSICION INICIARE EL GRAFO

        }

    }
}
