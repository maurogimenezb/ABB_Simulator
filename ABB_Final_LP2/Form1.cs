using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABB_Final_LP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaracion de variables a utilizar
        int Dato = 0;
        int Nodo = 0;
        
        Arbol_Binario mi_Arbol = new Arbol_Binario(null); //Creacion del objeto Arbol
        Graphics g;                                       //Definicion del objeto grafico

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;

            mi_Arbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, Brushes.White);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Dato = int.Parse(txtNumero.Text);
            mi_Arbol.Insertar(Dato);
            txtNumero.Clear();
            txtNumero.Focus();
            Nodo++;

            Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Dato = int.Parse(txtNumero.Text);
            mi_Arbol.Eliminar(Dato);
            txtNumero.Clear();
            txtNumero.Focus();
            Nodo--;

            Refresh();
        }

        private void btnInorden_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Refresh();
            txtNumero.Clear();
            g = this.CreateGraphics();
            mi_Arbol.colorear(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, mi_Arbol.Raiz, false, true, false);
            this.Cursor = Cursors.Default;
        }

        private void btnPreorden_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Refresh();
            txtNumero.Clear();
            g = this.CreateGraphics();
            mi_Arbol.colorear(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, mi_Arbol.Raiz, false, false, true);
            this.Cursor = Cursors.Default;
        }

        private void btnPosorden_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Refresh();
            txtNumero.Clear();
            g = this.CreateGraphics();
            mi_Arbol.colorear(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, mi_Arbol.Raiz, true, false, false);
            this.Cursor = Cursors.Default;
        }

        private void btnNodos_Click(object sender, EventArgs e)
        {
            string numString = Nodo.ToString();
            MessageBox.Show(numString, "La cantidad de nodos es de: ");
        }
    }
}
