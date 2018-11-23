using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1
{
    public class Nodo
    {
        public string Name { get; set; } // Atributo de nombre
        public string Lata { get; set; }
        public Nodo[] Arreglo; // Arreglo de nod
        public Nodo(string Nombre, string Latilla)//Un constructor donde se le tenga que introducir el nombre del nodo a crear
        {
            Name = Nombre;
            Lata = Latilla;
        }
        public Nodo(string Nombre)//Un constructor donde se le tenga que introducir el nombre del nodo a crear
        {
            Name = Nombre;
        }
        public string Izquierda { get; set; }
        public string Derecha { get; set; }
    }
}
