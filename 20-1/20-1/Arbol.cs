using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1
{
    public class Arbol
    {
        int x = 0, y = 2, Altura = 0, Nivel = 0;
        public void AgregarNodo(Nodo nodo, string nombre, string[] nombres) // Metodo para agregar valores
        {
            if (nodo.Arreglo != null) // Si en el arreglo hay valor
            {
                foreach (Nodo item in nodo.Arreglo)//Por cada nodo en el arreglo del nodo 
                {
                    AgregarNodo(item, nombre, nombres); // Va mandar llamar el metodo agregar 
                }
            }
            else  //Si no tiene valor
            {
                if (nodo.Name == nombre) //Si el atributo name del nodo es igual al nombre que ingresamos en el metodo 
                {
                    nodo.Arreglo = new Nodo[nombres.Length]; // EL arreglo inicializado sera de tamaño
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        nodo.Arreglo[i] = new Nodo(nombres[i]); //Y les creamos los nodos a las uniones con su nombre
                    }
                }
            }
        }
        public void ImprimirNodo(Nodo nodo)//Imprime el Nodo
        {

            if (nodo.Arreglo != null) //Si en el arreglo no hay valor
            {
                Console.SetCursorPosition(x, y);
                Console.Write(nodo.Name); // imprime el nombre del nodo
                x = x + 5;
                ++y;
                for (int i = 0; i < nodo.Arreglo.Length; i++)// un ciclo for del 0 hasta el tamaño del arreglo
                {
                    ImprimirNodo(nodo.Arreglo[i]); // MAndamos llamar el metodo imprimir nodo con el Nodo y el indice i
                }
                x += 5;
            }
            else//Si hay valor
            {
                Console.SetCursorPosition(x, y);
                Console.Write(nodo.Name); // Imprimimos el atributo nombre del tipo nodo

                ++y; //Agregamos uno a y

            }
            Altura = (y - 2) / 2; // Altura es igual a la y-2 /2
            Nivel = Altura;//La altura es igual al nivel solo aqui
        }             
    }
}
