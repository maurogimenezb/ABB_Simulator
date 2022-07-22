using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace ABB_Final_LP2
{
    class Arbol_Binario
    {
        public Nodo_Arbol Raiz;
        public Nodo_Arbol aux;

        //Constructor por defecto
        public Arbol_Binario()
        {
            aux = new Nodo_Arbol();
        }

        //Constructor con parametros
        public Arbol_Binario(Nodo_Arbol nueva_raiz)
        {
            Raiz = nueva_raiz;
        }


        //Funcion para agregar un nuevo nodo (valor) al Arbol Binario
        public void Insertar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
            }
            else
            {
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
            }
        }


        //Funcion para eliminar un nodo (valor) del Arbol Binario
        public void Eliminar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
            }
            else
            {
                Raiz.Eliminar(x, ref Raiz);
            }
        }

         //Funciones para el dibujo del Arbol Binario en el Formulario

        //Funcion que dibuja el Arbol Binario
        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush
            RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            int x = 400;            //Posiciones de la raiz del arbol
            int y = 75;

            if (Raiz == null) return;

            Raiz.PosicionNodo(ref x, y);    //Posicion de cada nodo

            Raiz.DibujarRamas(grafo, Lapiz);    //Dibuja los Enlaces entre nodos

            //Dibuja todos los Nodos
            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }


        public int x1 = 400;    //Posiciones iniciales de la raiz del arbol
        public int y2 = 75;

        //Funcion para colorear los nodos
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente,
    Pen Lapiz, Nodo_Arbol Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;
            if (inor == true) //Si es recorrido en orden
            {
                if (Raiz != null) //Si la raiz no es null
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor); //Se colorea el nodo izquiero
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz); //Se colorea la raiz
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz); //Se vuelve a colorear la raiz
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor); //Se colorea el nodo derecho
                }
            }
            else if (preor == true) //Si es recorrido pre orden
            {
                if (Raiz != null) //Si la raiz no es null
                {
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz); //Se colorea la raiz
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz); //Se colorea la raiz 
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor); //Se colorea el nodo izquierdo
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor); //Se colorea el nodo derecho
                }
            }
            else if (post == true) //Si es recorrido post orden
            {
                if (Raiz != null) //Si la raiz no es null
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor); //Se colorea el nodo izquiero
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor); //Se colorea el nodo derecho
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz); //Se colorea la raiz
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz); //Se colorea la raiz
                }
            }
        }


    }
}
