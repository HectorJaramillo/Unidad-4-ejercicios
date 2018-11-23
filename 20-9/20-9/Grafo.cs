using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20_9
{
    public class Grafo//CREO LA CLASE GRAFO
    {
        private int Vertices;//CANTIDAD DE VERTICES QUE HABRA
        private List<Int32>[] Adj;//LISTA PARA ALMACENAR LOS DATOS
        public Grafo(int V)//CONSTRUCTOR DE LA CLASE NODO PIDE PARAMETROS DE TIPO INT
        {
            Vertices = V;
            Adj = new List<Int32>[V];
            for (int i = 0; i < V; i++)//RECORRE TODAS LAS POSICIONES DE LA LISTA
            {
                Adj[i] = new List<int>();
            }
        }
        public void AñadirFinal(int C, int V)//METODO QUE CONECTA LOS NODOS PIDE EL NODO CONECTOR Y CONECTADO
        {
            Adj[C].Add(V);
        }
        public void DFS(int V)//METODO PARA RECORRER Y IMPRIMIR LOS NODOS PIDE DE QUE NODO SE EMPEZARA EL RECORRIDO
        {
            List<char> Lista = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
            bool[] Visitado = new bool[Vertices];//ARREGLO PARA SABER QUE NODOS YA HAN SIDO VISITADOS
            Stack<Int32> Pila = new Stack<int>();//PILA PARA ALMACENAR LOS NODOS VISITADOS
            Visitado[V] = true;
            Pila.Push(V);//SE AÑADE EL ELEMENTO A LA PILA
            while (Pila.Count != 0)//MIENTRAS LA PILA CONTENGA ELEMENTOS
            {
                V = Pila.Pop();//SE ELIMINA EL ULTIMO ELEMENTO
                Console.Write("-->" + Lista[V]);//SE IMPRIME EL NODO VISITADO
                foreach (int i in Adj[V])// EL FOREACH TOMA COMO REFERENCIA EL VALOR CONECTOR PARA LLEGAR A LA SIGUIENTE CONEXION (1--> 2)
                {
                    if (!Visitado[i])//SI EL GRAFO NO HA SIDO VISITADO ENTONCES SE VISITA
                    {
                        Visitado[i] = true;
                        Pila.Push(i);//SE AGREGA A LA PILA
                    }
                }
            }

        }
    }
}
