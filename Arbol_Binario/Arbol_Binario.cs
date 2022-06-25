using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing; // Libreria para dibujar figuras geometricas
using System.Windows.Forms;
using System.Threading; //Libreria para manejo de Hilos
using System.Threading.Tasks;

namespace Arbol_Binario
{
    class Arbol_Binario
    {
        public Nodo_Arbol Raiz;
        public Nodo_Arbol aux;
        int h = 0;
        int s = 0;




        //Constructor por defecto
        public Arbol_Binario()
        {
            aux = new Nodo_Arbol();
        }

        // Constructor con parametros 
        public Arbol_Binario (Nodo_Arbol nueva_raiz)
        {
            Raiz = nueva_raiz;
        }
         //Funcion para agregar un nuevo nodo

        public void Insertar (int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
            }
            else
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel, Raiz.altura);
        }

        //Funcion para eliminar un nodo (valor) del Arbol Binario
        public void Eliminar (int x)
        {
            if (Raiz == null)
                Raiz = new Nodo_Arbol(x, null, null, null);
            else
                Raiz.Eliminar(x, ref Raiz);
        }

        public void Buscar (int x)
        {
            Raiz.buscar(x, Raiz);
        }
        public void Altura()
        {
            MessageBox.Show("La altura es: " + Raiz.alturaABB(ref Raiz, ref h));
        }

        public void Suma()
        {
            MessageBox.Show("La altura es: " + Raiz.Suma(ref Raiz, ref s));
        }

        //Funciones para el dibujo del arbol binario en el formulario

        //Funcion que dibuja el arbol binario 
        public void DibujarArbol (Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            int x = 520; //Posiciones de la raiz del arbol
            int y = 65;

            if (Raiz == null) return;

            Raiz.PosicionNodo(ref x, y); //Posicion de cada nodo

            Raiz.DibujarRamas(grafo, Lapiz); //Dibujar los enlaces entre los nodos

            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }
    }
}
