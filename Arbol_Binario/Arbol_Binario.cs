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
                Raiz.hizquierda = 0;
                Raiz.hderecha = 0;


            }
            else
                Raiz = Raiz.Insertar(x, Raiz, Raiz.hizquierda, Raiz.hderecha);
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
            {
                Raiz.buscar(x, Raiz);
            }
        }
        public void Altura()
        {
            int h = 0;

            if (Raiz == null)
            {
                ErrorForm ErrorForm = new ErrorForm();
                ErrorForm.Show();
            }
            else
            {
                ExtrasData.altura = Raiz.alturaABB(ref Raiz, ref h);
                AlturaForm AlturaForm = new AlturaForm();
                AlturaForm.Show();
            }
        }

        public void Suma()
        {
            int s = 0;
            if (Raiz == null)
            {
                ErrorForm ErrorForm = new ErrorForm();
                ErrorForm.Show();
            }

            else
            {
                SumaDato.suma = Raiz.Suma(ref Raiz, ref s);
                SumaForm SumaForm = new SumaForm();
                SumaForm.Show();
            }

        }

        public void Recorrido ()
        {
            if (Raiz == null)
            {
                ErrorForm ErrorForm = new ErrorForm();
                ErrorForm.Show();
            }

            else
            {
                string po = "";
                RecoData.posorden = Raiz.PosOrden(ref Raiz, ref po);

                string ino = "";
                RecoData.inorden = Raiz.InOrden(ref Raiz, ref ino);

                string pre = "";
                RecoData.preorden = Raiz.PreOrden(ref Raiz, ref pre);

                RecoForm RecoForm = new RecoForm();
                RecoForm.Show();
            }
        }

        public void Multiplos()
        {

            if (Raiz == null)
            {
                ErrorForm ErrorForm = new ErrorForm();
                ErrorForm.Show();
            }

            else
            {
               string sx2data = "";
                MultiplosData.datax2 = Raiz.Mx2Data(ref Raiz, ref sx2data);

                int smx2 = 0;
                MultiplosData.sumax2 = Raiz.Multiplox2(ref Raiz, ref smx2);

                string sx3data = "";
                MultiplosData.datax3 = Raiz.Mx3Data(ref Raiz, ref sx3data);

                int smx3 = 0;
                MultiplosData.sumax3 = Raiz.Multiplox3(ref Raiz, ref smx3);

                string sx5data = "";
                MultiplosData.datax5 = Raiz.Mx5Data(ref Raiz, ref sx5data);

                int smx5 = 0;
                MultiplosData.sumax5 = Raiz.Multiplox5(ref Raiz, ref smx5);

                Mx2Form Mx2Form = new Mx2Form();
                Mx2Form.Show(); 
             }
        }

        public void Mayor ()
        {
            int my = 0;
            if (Raiz == null)
            {
                ErrorForm ErrorForm = new ErrorForm();
                ErrorForm.Show();
            }

            else
            {
                ExtrasData.mayor = Raiz.Mayor(ref Raiz, ref my);
                MayorForm MayorForm = new MayorForm();
                MayorForm.Show();
            }
        }

        public void Menor()
        {
            int mn = 0;
            if (Raiz == null)
            {
                ErrorForm ErrorForm = new ErrorForm();
                ErrorForm.Show();
            }

            else
            {
                ExtrasData.menor = Raiz.Menor(ref Raiz, ref mn);
                MenorForm MenorForm = new MenorForm();
                MenorForm.Show();
            }
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
