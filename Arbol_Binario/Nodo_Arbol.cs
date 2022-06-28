using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing; // Libreria para dibujar figuras geometricas
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Media; // Libreria para reproducir los sonidos


namespace Arbol_Binario
{
    class Nodo_Arbol
    {
        public int info; // Dato a almacenar en el nodo
        public Nodo_Arbol Izquierdo; //Nodo izquierdo del arbol
        public Nodo_Arbol Derecho; //Nodo izquierdo del arbol
        public int altura; // Variable para ir guardando la altura del arbol segun su nivel

        public Nodo_Arbol(int nueva_info, Nodo_Arbol izquierdo, Nodo_Arbol derecho)
        {
            info = nueva_info;
            Izquierdo = izquierdo;
            Derecho = derecho;
            altura = 0;
        }

        //Funcion para insertar un nodo en el Arbol
        public Nodo_Arbol Insertar (int x, Nodo_Arbol t, int Altura)
        {
            if (t==null)
            {
                t = new Nodo_Arbol(x, null, null);
               // t.nivel = Level;
                t.altura = Altura;

            }
            else if (x<t.info) //Si el valor a insertar es menor que la raiz
            {
                Altura++;
                t.Izquierdo = Insertar(x, t.Izquierdo, Altura);


            }
            else if (x > t.info) //Si el valor a insertar es mayor que la raiz
            {
                Altura++;
                t.Derecho = Insertar(x, t.Derecho, Altura);

            }

            else
            {
                MessageBox.Show("Dato existente en el arbol", "Error de ingreso");
            }
            return t;
        }

        public Nodo_Arbol Insertar2(int x, Nodo_Arbol t, int Level, int Altura)
        {

            if (x < t.info)
            {

                if (t.Izquierdo == null)
                {
                    t = new Nodo_Arbol(x, null, null);
                  //  t.nivel = Level;
                  //  t.altura = Altura;
                }

                else         
                  //  Level++;
                  //  Altura++;
                    t.Izquierdo = Insertar2(x, t.Izquierdo, Level, Altura);
            }

            else if (x > t.info)
            {
                if (t.Derecho == null)
                {
                    t = new Nodo_Arbol(x, null, null);
                  //  t.nivel = Level;
                  //  t.altura = Altura;
                }

                else
                Level++;
                Altura++;
                t.Derecho = Insertar2(x, t.Derecho, Level, Altura);
            }

            else 
            {
                MessageBox.Show("Dato existente en el arbol", "Error de ingreso");
            }
            return t;
        }

        //Funcion para calcular la altura de un nodo en el Arbol
        public static int Alturas (Nodo_Arbol t)
        {
            return t == null ? -1 : t.altura;
        }

        public int alturaABB (ref Nodo_Arbol t, ref int h)
        {
            if (t != null)
            {
                h = Alturas(t);
                alturaABB(ref t.Izquierdo, ref h); 
                alturaABB(ref t.Derecho, ref h);
            }
            return h;
        }

        public int Suma (ref Nodo_Arbol t, ref int s)
        {
           // int s = 0;
            if (t != null)
            {
                s += t.info;
                Suma(ref t.Izquierdo, ref s);
                Suma(ref t.Derecho, ref s);
            }
            return s;
        }

        public int Multiplox2 (ref Nodo_Arbol t, ref int sx2)
        {
            // int s = 0;
            if (t != null)
            {
                if (t.info % 2 == 0)
                {
                    sx2 += t.info;
                   // dx2 += t.info.ToString() + ", ";

                }

                Multiplox2 (ref t.Izquierdo, ref sx2);
                Multiplox2 (ref t.Derecho, ref sx2);
            }
            return sx2;
        }

        public string Mx2Data(ref Nodo_Arbol t, ref string dx2)
        {
            // int s = 0;
            if (t != null)
            {
                if (t.info % 2 == 0)
                {
                    //sx2 += t.info;
                    dx2 += t.info.ToString() + ", ";

                }

                Mx2Data (ref t.Izquierdo, ref dx2);
                Mx2Data (ref t.Derecho, ref dx2);
            }
            return dx2;
        }

        public int Multiplox3(ref Nodo_Arbol t, ref int sx3)
        {
            // int s = 0;
            if (t != null)
            {
                if (t.info % 3 == 0)
                {
                    sx3 += t.info;
                }

                Multiplox3(ref t.Izquierdo, ref sx3);
                Multiplox3(ref t.Derecho, ref sx3);
            }
            return sx3;
        }

        public int Multiplox5(ref Nodo_Arbol t, ref int sx5)
        {
            // int s = 0;
            if (t != null)
            {
                if (t.info % 5 == 0)
                {
                    sx5 += t.info;
                }

                Multiplox5(ref t.Izquierdo, ref sx5);
                Multiplox5(ref t.Derecho, ref sx5);
            }
            return sx5;
        }

        public string PosOrden(ref Nodo_Arbol t, ref string po)
        {
            //string po = "";
            if (t != null)              
            {
                PosOrden(ref t.Izquierdo, ref po);
                PosOrden(ref t.Derecho, ref po);
               po += t.info.ToString() + ", ";
            }

            return po;
        }

        public string InOrden(ref Nodo_Arbol t, ref string io)
        {
            //string io = "";
            if (t != null)
            {
                PosOrden(ref t.Izquierdo, ref io);
                io += t.info.ToString() + ", ";
                PosOrden(ref t.Derecho, ref io);
            }

            return io;
        }

        public string PreOrden(ref Nodo_Arbol t, ref string pro)
        {
            //string pro = "";
            if (t != null)
            {
                pro += t.info.ToString() + ", ";
                PosOrden(ref t.Izquierdo, ref pro);
                PosOrden(ref t.Derecho, ref pro);
            }

            return pro;
        }

        public int Mayor(ref Nodo_Arbol t, ref int my)
        {
            if (t != null)
            {
                my = t.info;
                Mayor(ref t.Derecho, ref my);
            }
            return my;
        }

        public int Menor(ref Nodo_Arbol t, ref int mn)
        {
            if (t != null)
            {
                mn = t.info;
                Menor(ref t.Izquierdo, ref mn);
            }
            return mn;
        }

        //Funcion para eliminar un nodo del Arbol Binario
        public void Eliminar (int x, ref Nodo_Arbol t)
        {
            if (t!= null) // Si raiz es distinta de null
            {
                if (x<t.info) // Si el valor a eliminar es menor que la raiz
                {
                    Eliminar(x, ref t.Izquierdo);
                }
                else
                {
                    if (x>t.info) // Si el valor a eliminar es mayor que la raiz
                    {
                        Eliminar(x, ref t.Derecho);
                    }
                    else
                    {
                        Nodo_Arbol NodoEliminar = t; // Ya se ubico el nodo que se quiere eliminar
                        if (NodoEliminar.Derecho == null) // Se verifica si tiene hijo derecho
                        {
                            t = NodoEliminar.Izquierdo;
                        }
                        else
                        {
                            if (NodoEliminar.Izquierdo == null) // se verifica si tiene hijo izquierdo
                            {
                                t = NodoEliminar.Derecho;
                            }
                            else
                            {
                                // Para verificar que hijo pasa a ser nueva raiz del subarbol
                                if (Alturas (t.Izquierdo) -Alturas (t.Derecho) > 0)
                                {
                                    Nodo_Arbol AuxiliarNodo = null;
                                    Nodo_Arbol Auxiliar = t.Izquierdo;
                                    bool Bandera = false;

                                    while (Auxiliar.Derecho != null)
                                    {
                                        AuxiliarNodo = Auxiliar;
                                        Auxiliar = Auxiliar.Derecho;
                                        Bandera = true;
                                    }

                                    t.info = Auxiliar.info; // Se crea un nodo temporal
                                    NodoEliminar = Auxiliar;

                                    if (Bandera == true)
                                    {
                                        AuxiliarNodo.Derecho = AuxiliarNodo.Izquierdo;
                                    }

                                    else
                                    {
                                        t.Izquierdo = Auxiliar.Izquierdo;
                                    }
                                }

                                else
                                {
                                    if (Alturas (t.Derecho) - Alturas (t.Izquierdo) > 0)
                                    {
                                        Nodo_Arbol AuxiliarNodo = null;
                                        Nodo_Arbol Auxiliar = t.Derecho;
                                        bool Bandera = false;

                                        while (Auxiliar.Izquierdo != null)
                                        {
                                            AuxiliarNodo = Auxiliar;
                                            Auxiliar = Auxiliar.Izquierdo;
                                            Bandera = true;
                                        }

                                        t.info = Auxiliar.info;
                                        NodoEliminar = Auxiliar;

                                        if (Bandera == true)
                                        {
                                            AuxiliarNodo.Izquierdo = AuxiliarNodo.Derecho;
                                        }

                                        else
                                        {
                                            t.Derecho = Auxiliar.Derecho;
                                        }
                                    }

                                    else
                                    {
                                        if  (Alturas (t.Derecho) - Alturas (t.Izquierdo) == 0)
                                        {
                                            Nodo_Arbol AuxiliarNodo = null;
                                            Nodo_Arbol Auxiliar = t.Izquierdo;
                                            bool Bandera = false;

                                            while (Auxiliar.Derecho != null)
                                            {
                                                AuxiliarNodo = Auxiliar;
                                                Auxiliar = Auxiliar.Derecho;
                                                Bandera = true;
                                            }

                                            t.info = Auxiliar.info;
                                            NodoEliminar = Auxiliar;

                                            if (Bandera == true)
                                            {
                                                AuxiliarNodo.Derecho = AuxiliarNodo.Izquierdo;
                                            }

                                            else
                                            {
                                                t.Izquierdo = Auxiliar.Izquierdo;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            else
            {
                MessageBox.Show("No existe nodo en el arbol");
            }
        } // Final de la funcion eliminar

        //Funcion para recorrer el Arbol Binario (busqueda de un nodo)
        public void buscar (int x, Nodo_Arbol t)
        {
            if (t != null)
            {
                if (x < t.info)
                {
                    buscar(x, t.Izquierdo);
                    MessageBox.Show("Nodo encontrado en el Arbol " + x);

                }

                else
                {
                    if (x > t.info)
                    {
                        buscar(x, t.Derecho);
                        MessageBox.Show("Nodo encontrado en el Arbol " + x);
                    }
                }
            }

            else
                MessageBox.Show("Nodo no encontrado en el Arbol");

        }

        public void buscar2(int x, Nodo_Arbol t)
        {
            if (x < t.info)
            {
                if (t.Izquierdo == null)
                {
                    MessageBox.Show("Nodo no encontrado en el Arbol ");
                }

                else
                    buscar2(x, t.Izquierdo);
                    MessageBox.Show("Nodo encontrado en el Arbol " + x);
            }
            else if (x > t.info)
            {
                if (t.Derecho == null)
                {
                    MessageBox.Show("Nodo no encontrado en el Arbol ");
                }

                else
                    buscar2(x, t.Derecho);
                MessageBox.Show("Nodo encontrado en el Arbol " + x);
            }
        }

        // Funciones para el dibujo de los nodos del Arbol Binario en el formulario

        //Variable que define el tamaño de los circulos que representaran los nodos del arbol
        private const int Radio = 30;
        private const int DistanciaH = 80; //variable para manejar distancia horizontal 
        private const int DistanciaV = 10; //varible para manejar distancia vertical

        private int CoordenadaX; //variable para manejar posicion eje X
        private int CoordenadaY; //variable para manejar posicion eje Y

        // Funcion para encontrar la posicion donde se creara (dibujara) el nodo

        public void PosicionNodo (ref int xmin, int ymin)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 2);

            //Obtiene la posicion de subarbol izquierdo
            if (Izquierdo != null)
            {
                Izquierdo.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if ((Izquierdo != null) && (Derecho != null))
            {
                xmin += DistanciaH;
            }
            // Si existe el nodo derecho y el nodo izquierdo deja un espacio entre ellos
            if (Derecho != null)
            {
                Derecho.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }

            if (Izquierdo != null && Derecho != null)
                CoordenadaX = (int)((Izquierdo.CoordenadaX + Derecho.CoordenadaX) / 2);
            else if (Izquierdo != null)
            {
                aux1 = Izquierdo.CoordenadaX;
                Izquierdo.CoordenadaX = CoordenadaX - 80;
                CoordenadaX = aux1;
            }

            else if (Derecho != null)
            {
                aux2 = Derecho.CoordenadaX;
                //No hay nodo izquierdo, centrar en nodo derecho
                Derecho.CoordenadaX = CoordenadaX + 80;
                CoordenadaX = aux2;
            }
            else
            {
                CoordenadaX = (int)(xmin + Radio / 2);
                xmin += Radio;
            }
        }

        // Funcion para dibujar las ramas de los nodos izquierdo y derecho
        public void DibujarRamas (Graphics grafo, Pen Lapiz)
        {
            if (Izquierdo != null) //Dibuja rama izquierda
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, Izquierdo.CoordenadaX, Izquierdo.CoordenadaY);
                Izquierdo.DibujarRamas(grafo, Lapiz);
            }

            if (Derecho != null) //Dibuja rama derecha
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, Derecho.CoordenadaX, Derecho.CoordenadaY);
                Derecho.DibujarRamas(grafo, Lapiz);
            }
        }

        //Funcion para dibujar el nodo en la posicion especificada
        public void DibujarNodo (Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            // Dibuja en contorno del nodo
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            
            grafo.FillEllipse(encuentro, rect);
            grafo.FillEllipse(Relleno, rect);
            grafo.DrawEllipse(Lapiz, rect);

            //Para dibujar el nombre del nodo, es decir el contenido
            StringFormat formato = new StringFormat();

            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString (info.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY, formato);

            //Dibujar los nodos hijos derecho e izquierdo
            if (Izquierdo != null)
            {
                Izquierdo.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
            }

            if (Derecho != null)
            {
                Derecho.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
            }
        }
    }
}
