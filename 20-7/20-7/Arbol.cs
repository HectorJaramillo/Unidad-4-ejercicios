using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_7
{
     class Arbol
    {
        bool encontrado = false;//un bool para no repetir pasos dentro del proceso de busqueda

        public void Add(Nodo nodo, string nombre, string[] nombres)//Aqui añadimos uniones a lo que serian las hojas del arbol para convertirlas en ramas
        {//Le ingresamos el nodo raiz, nombre del nodo que buscamos y los nombres de las uniones que vamos a crear en ese nodo(uno por nodo)
            if (nodo.next != null)//Si el nodo tiene hijos
            {
                foreach (Nodo item in nodo.next)//Por cada hijo
                {
                    Add(item, nombre, nombres);//Aplicamos recursividad del mismo metodo ingresando el nodo hijo de nodo raiz
                }
            }
            else//Si no tienen hijos
            {
                if (nodo.Name == nombre)//Si es el nombre del nodo es el mismo que se busca
                {
                    nodo.next = new Nodo[nombres.Length];//Iniciamos el arreglo de nodos con el numero de nombres a colocar
                    for (int i = 0; i < nombres.Length; i++)//Y por cada nombre
                    {
                        nodo.next[i] = new Nodo(nombres[i], nodo.Level + 1, nodo.Path + "-> " + nombres[i]);//Creamos un nodo hijo con su nombre, nivel y camino a el
                    }
                }
            }
        }

        public void Print(Nodo nodo)//Imprime el digrama de todas las uniones
        {
            if (nodo.next != null)//Si no es nulo
            {
                PrintNodeInPriority(nodo);//Llamamos al metodo que imprime la posicion del nodo
                for (int i = 0; i < nodo.next.Length; i++)//Y por cada union que tenga llamamos el mismo metodo
                {
                    Print(nodo.next[i]);//metiendo el nodo de la union siguiente
                }
            }
            else//Si no es nulo significa que llegamos a una hoja y ya no hay a donde ir
            {
                PrintNodeInPriority(nodo);//Llamamos al metodo que imprime la posicion del nodo
            }
        }
        private void PrintNodeInPriority(Nodo nodo)//Imprime el nodo en la posicion que debe ir
        {
            if (nodo.Level == 0)//Si es el primer dato se imprime directamente su nivel y posicion
            {
                Console.Write("\n({0}){1}\n", nodo.Level, nodo.Name);
            }
            else//Si no, dependiendo de su posicion con un for se modifica el lugar de impresion
            {
                for (int i = 0; i < nodo.Level; i++)
                    Console.Write("   ");
                Console.Write("-->({0}){1}\n", nodo.Level, nodo.Name);//y se imprime
            }

        }

        public void Find(Nodo nodo, string nombre)//Imprime el camino del vertice que se busca, se le coloca el nodo origen y el nommbre del dato que se busca
        {
            Console.WriteLine("\nEl camino a {0} es:\n", nombre);
            FindNodePath(nodo, nombre);//Imprime el camino al vertice
            encontrado = false;//Cambiamos el bool de busqueda a su estado original
        }
        private void FindNodePath(Nodo nodo, string nombre)//Con el nodo origen y el vertice que se busca
        {
            if (!encontrado)//Mientas que no se encuentre el vertice
            {
                if (nodo.Name == nombre)//Si el nombre del nodo es el que se busca
                {
                    Console.WriteLine(nodo.Path);//Escribe el camino al nodo
                    encontrado = true;//Y se dice que encontro el nombre
                }
                else//Si no es el mismo nombre
                {
                    if (nodo.next != null)//Y tiene hijos
                    {
                        for (int i = 0; i < nodo.next.Length; i++)//Por cada hijo
                        {
                            FindNodePath(nodo.next[i], nombre);//Llama al mismo metodo pero con el nodo hijo y pasando el nombre que busca
                        }
                    }
                }
            }
        }

        public void Height(Nodo nodo)//Imprime la altura
        {
            Console.WriteLine("\nLa altura es de: " + Height(nodo, 1, 1));//Para ello se llama al metodo height
        }
        private int Height(Nodo nodo, int alturaTemp, int alturaMax)//Regresa el valor de la altura que tiene el grafo, ingresas el nodo origen, 
                                                                    //la altura temporal que tiene que ser 1 y la altura que tiene que ser 1 tambien para que funcione, pero eso lo hace el metodo que lo llama
        {
            if (nodo.next != null)//Si el vertice tiene hijos
            {
                ++alturaTemp;//Sumale uno a la altura
                for (int i = 0; i < nodo.next.Length; i++)//Y por cada hijo
                {
                    alturaMax = Height(nodo.next[i], alturaTemp, alturaMax);//Se le asigna a la altura maxima el valor que regrese
                }
                return alturaMax;//Devuelve altura
            }
            else//Si no tiene hijos
            {
                if (alturaTemp > alturaMax)//Pregunta si la altura a que se llego es mayor a la altura maxima
                {
                    alturaMax = alturaTemp;//Si lo es remplaza a la altura maxima
                }
                return alturaMax;//Devuelve la altura
            }
        }

        public void FindLongest(Nodo nodo)//Imprime los caminos mas largos a los ultimos nodos intoduciendo el nodo origen
        {
            Console.WriteLine("\nLos caminos mas largos son: ");
            int altura = Height(nodo, 0, 0);//Busca la altura maxima con el metodo Heigth
            PrintLongestPath(nodo, altura);//Y usa el metodo PrintLongestPath, ingresando el nodo origen y la altura maxima del arbol
        }
        private void PrintLongestPath(Nodo nodo, int altura)//Con los datos ingresados del nodo origen y la altura maxima del arbol
        {
            if (nodo.next != null)//Si el nodo tiene hijos
            {
                for (int i = 0; i < nodo.next.Length; i++)//Por cada hijo
                {
                    PrintLongestPath(nodo.next[i], altura);//Llama se llama a si mismo introduciendo el nodo hijo y la altura maxima
                }
            }
            else//Si no tiene hijos
            {
                if (nodo.Level == altura)//Si el nivel del nodo es igual a la altura maxima
                    Console.WriteLine(nodo.Path);//Se imprime al camino
            }
        }
    }
}
