using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_10
{
    public class Proceso
    {
        public void GrafoA()
        {
            Grafo grafito = new Grafo(5);//AGREGO LA CANTIDAD DE VERTICES+1 NO SE PORQUE HAHA SALUDOS
            Console.WriteLine("Grafo A");
            Console.Write("Recorrido: \n");
            grafito.AñadirFinal(0, 1);//AGREGO LAS CONEXIONES EXISTENTES EN EL GRAFO
            grafito.AñadirFinal(1, 4);
            grafito.AñadirFinal(4, 2);
            grafito.AñadirFinal(4, 1);
            grafito.DFS(0);//INDICO DESDE QUE POSICION INICIARE EL GRAFO
            Console.WriteLine("->B");//EL GRAFO NO PERMITE VISITAR 2 VECES Y NODO POR ESO ESCRIBO EL REPETIDO
            Console.WriteLine("Es un Camino Simple");
        }
        public void GrafoB()
        {
            Grafo grafito = new Grafo(5);//AGREGO LA CANTIDAD DE VERTICES+1 NO SE PORQUE HAHA SALUDOS
            Console.WriteLine("Grafo B");
            Console.Write("Recorrido: \n");
            grafito.AñadirFinal(0, 3);//AGREGO LAS CONEXIONES EXISTENTES EN EL GRAFO
            grafito.AñadirFinal(3, 0);//
            grafito.AñadirFinal(0, 3);
            grafito.AñadirFinal(3, 0);
            grafito.DFS(0);//INDICO DESDE QUE POSICION INICIARE EL GRAFO
            grafito.DFS(0);
            Console.WriteLine("->A");//EL GRAFO NO PERMITE VISITAR 2 VECES Y NODO POR ESO ESCRIBO EL REPETIDO
            Console.WriteLine("Es un Circuito");
        }
        public void GrafoC()
        {
            //a,d,b,e,a
            Grafo grafito = new Grafo(5);//AGREGO LA CANTIDAD DE VERTICES+1 NO SE PORQUE HAHA SALUDOS
            Console.WriteLine("Grafo C");
            Console.Write("Recorrido: \n");
            grafito.AñadirFinal(0, 3);//AGREGO LAS CONEXIONES EXISTENTES EN EL GRAFO
            grafito.AñadirFinal(3, 1);//
            grafito.AñadirFinal(1, 4);
            grafito.AñadirFinal(4, 0);
            grafito.DFS(0);//INDICO DESDE QUE POSICION INICIARE EL GRAFO
            Console.WriteLine("->A");//EL GRAFO NO PERMITE VISITAR 2 VECES Y NODO POR ESO ESCRIBO EL REPETIDO
            Console.WriteLine("Es un Circuito");
        }
        public void GrafoD()
        {
            //a,b,e,c,b,d,a
            Grafo grafito = new Grafo(5);//AGREGO LA CANTIDAD DE VERTICES+1 NO SE PORQUE HAHA SALUDOS
            Console.WriteLine("Grafo D");
            Console.Write("Recorrido: \n");
            grafito.AñadirFinal(0, 1);//AGREGO LAS CONEXIONES EXISTENTES EN EL GRAFO
            grafito.AñadirFinal(1, 4);//
            grafito.AñadirFinal(4, 2);
            grafito.AñadirFinal(2, 1);
            //grafito.AñadirFinal(1, 3);
            grafito.AñadirFinal(3, 0);
            grafito.DFS(0);//INDICO DESDE QUE POSICION INICIARE EL GRAFO
            Console.WriteLine("->B->D->A");//EL GRAFO NO PERMITE VISITAR 2 VECES Y NODO POR ESO ESCRIBO EL REPETIDO
            Console.WriteLine("Es un Circuito");
        }
    }
}
