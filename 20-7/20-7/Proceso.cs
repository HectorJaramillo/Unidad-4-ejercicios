using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_7
{
    public class Proceso
    {
        public void ArbolShido()
        {
            Arbol Instancia = new Arbol();//Instanciamos nuestra clase Arbol
            Console.WriteLine("\n---Diagrama 3---");//Repetimos el proceso para el ultimo nodo
            Nodo arbol = new Nodo("B");//Creamos su nodo raiz y repetimos el proceso
            Instancia.Add(arbol, "B", new string[] { "C", "D" });
            Instancia.Add(arbol, "C", new string[] { "F", "I" });
            Instancia.Add(arbol, "F", new string[] { "A", "E" });
            Instancia.Add(arbol, "D", new string[] { "G" });
            Instancia.Add(arbol, "G", new string[] { "H", "J" });
            Instancia.Add(arbol, "H", new string[] { "K", "O" });
            Instancia.Add(arbol, "J", new string[] { "L" });
            Instancia.Add(arbol, "L", new string[] { "P", "U" });
            Instancia.Print(arbol);
            Instancia.Height(arbol);
            Instancia.FindLongest(arbol);
            Instancia.Find(arbol, "A");//Solo quea hora se usua otro metodo llamado Find, que busca e imprime el camino al nodo que se busca
            Instancia.Find(arbol, "E");//Donde se le ingresa el nodo raiz y el nombre que se busca
            Instancia.Find(arbol, "I");
            Instancia.Find(arbol, "O");
            Instancia.Find(arbol, "U");
            Instancia.Find(arbol, "P");
            Instancia.Find(arbol, "K");
            Console.ReadKey();
        }
    }
}
