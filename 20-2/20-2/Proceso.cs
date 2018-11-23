using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_2
{
    public class Nodo
    {
        public Nodo Hijo; //Este sera un arbol practicamente lineal
        public double CartasEnviadas = 0;
    }
    public class Proceso
    {
        Nodo Raiz;      
        public void MetodoBasicoArbol()//Este es un metodo basico de una arbol
        {
            Console.WriteLine("Problema de las Cartas\n");
            int valor = 1, Guardado = 0, Auxiliar=0, Ultimas3=0;
            for (int i = 1; i < 8; i++)//For para calcular la cantidad de cartas
            {
                valor = valor * 5;
                Auxiliar = valor * 2;                                              
                Guardado += Auxiliar; //Variable que almacena el total de cartas enviadas 
                if (i > 4)
                {
                    Ultimas3 += Auxiliar;//Variable que almacena el total de cartas enviadas las ultimas 3 semanas
                }
            }
            for (int Indice = 1; Indice < 8; Indice++)
            {
                Nodo Nuevo;
                Nuevo = new Nodo
                {//Al momento de crear un nodo cada nodo tendra 10 hijos simulando llos 2 arboles
                    CartasEnviadas = Guardado,
                    Hijo = null
                };
                if (Raiz == null)
                {
                    Raiz = Nuevo;//Como siempre el primer dato que entra es la raiz
                }
                else 
                {//Y los demas datos son los nodos o ramas
                    Nodo Nodo = null, Cantidad;
                    Cantidad = Raiz;
                    while (Cantidad != null) 
                    {
                        Nodo = Cantidad;
                        Cantidad = Cantidad.Hijo;
                    }
                    Nodo.Hijo = Nuevo;
                }             
            }
            Console.WriteLine("Durante las 7 semanas se enviaron: "+ Guardado);
            Console.WriteLine("Las ultimas 3 semanas se enviaron: "+ Ultimas3);
        }    
    }
}
