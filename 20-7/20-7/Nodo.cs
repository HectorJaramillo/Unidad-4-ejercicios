using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_7
{
    public class Nodo
    {
        public string Name { get; set; }//Nombre del nodo
        public int Level { get; set; }//Nivel del nodo
        public string Path { get; set; }//Camino al nodo
        public Nodo[] next;
        public Nodo(string nombre)//Este constructor es para el nodo origen
        {
            Name = nombre;
            Level = 0;
            Path = nombre;
        }
        public Nodo(string nombre, int nivel, string camino)//Este constructor es para los hijos cuando se crean dentro del metodo Arbol
        {//Donde se pide, el nombre del hijo, el nivel y el camino a el
            Name = nombre;
            Level = nivel;
            Path = camino;
        }
    }
}
