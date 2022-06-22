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
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
        }

        //Funcion para eliminar un nodo (valor) del Arbol Binario
        public void Eliminar (int x)
        {
            if (Raiz == null)
                Raiz = new Nodo_Arbol(x, null, null, null);
            else
                Raiz.Eliminar(x, ref Raiz);
        }

        //Funciones para el dibujo del arbol binario en el formulario

        //Funcion que dibuja el arbol binario 
        public void DibujarArbol (Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            int x = 400; //Posiciones de la raiz del arbol
            int y = 75;

            if (Raiz == null) return;

            Raiz.PosicionNodo(ref x, y); //Posicion de cada nodo

            Raiz.DibujarRamas(grafo, Lapiz); //Dibujar los enlaces entre los nodos

            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }

        //public int x1 = 400; //Posiciones iniciales de la raiz del arbol
       // public int y2 = 75;
        public void colorear (Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Nodo_Arbol Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;

            if (inor == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecucion 100 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                }
            }

            else if (preor == true)
            {
                if (Raiz != null)
                {
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecucion 100 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);

                }
            }

            else if (post == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecucion 100 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                }
            }
        }
    }
}
