using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing; // Libreria para dibujar figuras geometricas
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    class Arbol_Binario
    {
        public Nodo_Arbol Raiz;

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
                Raiz = new Nodo_Arbol(x, null, null);
                Raiz.altura = 0;

            }
            else
                Raiz = Raiz.Insertar(x, Raiz, Raiz.altura);
        }

        //Funcion para eliminar un nodo (valor) del Arbol Binario
        public void Eliminar (int x)
        {
            if (Raiz == null)
                Raiz = new Nodo_Arbol(x, null, null);
            else
                Raiz.Eliminar(x, ref Raiz);
        }

        public void Buscar (int x)
        {

            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null);
            }
            else
                Raiz.buscar2(x, Raiz);
        }
        public void Altura()
        {
            int h = 0;

            if (Raiz == null)
            {
                MessageBox.Show("No existe arbol");
            }
            else
            MessageBox.Show("La altura es: " + Raiz.alturaABB(ref Raiz, ref h));
        }

        public void Suma()
        {
            int s = 0;
            if (Raiz == null)
            {
                MessageBox.Show("No existe arbol");
            }
            else
            MessageBox.Show("La suma total es: " + Raiz.Suma(ref Raiz, ref s));
        }

        public void Recorrido ()
        {
            if (Raiz == null)
            {
                MessageBox.Show("No existe arbol");
            }

            else
            {
                string po = "";
                MessageBox.Show("El recorrido Posorder es: " + Raiz.PosOrden(ref Raiz, ref po));
                string io = "";
                MessageBox.Show("El recorrido Inorder es: " + Raiz.InOrden(ref Raiz, ref io));
                string pro = "";
                MessageBox.Show("El recorrido Preorder es: " + Raiz.PreOrden(ref Raiz, ref pro));
            }
        }

        public void Multiplos()
        {

            if (Raiz == null)
            {
                MessageBox.Show("No existe arbol");
            }

            else
            {
                int smx2 = 0;
               // string sx2data = "";
                MessageBox.Show("La suma de multiplos de 2 es: ", "Los mutiplos de 2 son: " + Raiz.Multiplox2(ref Raiz, ref smx2));
                int smx3 = 0;
                MessageBox.Show("La suma de multiplos de 3 es: " + Raiz.Multiplox3(ref Raiz, ref smx3));
                int smx5 = 0;
                MessageBox.Show("La suma de multiplos de 5 es: " + Raiz.Multiplox5(ref Raiz, ref smx5));
            }
        }

        public void Mayor ()
        {
            int my = 0;
            if (Raiz == null)
            {
                MessageBox.Show("No existe arbol");
            }

            else
                MessageBox.Show("El nodo mayor es: " + Raiz.Mayor(ref Raiz, ref my));
        }

        public void Menor()
        {
            int mn = 0;
            if (Raiz == null)
            {
                MessageBox.Show("No existe arbol");
            }

            else
                MessageBox.Show("El nodo mayor es: " + Raiz.Menor(ref Raiz, ref mn));
        }

       // public void Valores ()
       // {
        //    int x = 0;
       //     int y;

               // MessageBox.Show("El valor es es: " + Raiz.PosicionNodo(ref x, ref y));
       // }

        //Funciones para el dibujo del arbol binario en el formulario

        //Funcion que dibuja el arbol binario 
        public void DibujarArbol (Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            int x = 450; //Posiciones de la raiz del arbol
            int y = 65;

            if (Raiz == null) return;

            Raiz.PosicionNodo(ref x, y); //Posicion de cada nodo

            Raiz.DibujarRamas(grafo, Lapiz); //Dibujar los enlaces entre los nodos

            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }
    }
}
