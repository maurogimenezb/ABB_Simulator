using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        // Declaracion de variables a utilizar
        int Dato = 0;
        int cont = 0;

        Arbol_Binario mi_Arbol = new Arbol_Binario(null); // creacion del objeto arbol
        Graphics g; //definicion del objeto grafico

        private void Form1_Paint(object sender, PaintEventArgs en)
        {
            en.Graphics.Clear(this.BackColor);
            en.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = en.Graphics;

            mi_Arbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, Brushes.White);
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (TxtDato.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato");
            }
            else
            {
                Dato = int.Parse(TxtDato.Text);
                if (Dato <= 0 || Dato >= 100)
                {
                    MessageBox.Show("Solo recibimos valores de 1 al 99");
                }

                else
                {
                    mi_Arbol.Insertar(Dato);
                    TxtDato.Clear();
                    TxtDato.Focus();

                    cont++;

                    Refresh();
                    Refresh();
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtDato2.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato");
            }
            else
            {
                Dato = int.Parse(TxtDato2.Text);
                if (Dato <= 0 || Dato >= 100)
                {
                    MessageBox.Show("Solo recibimos valores de 1 al 99");
                }

                else
                {
                    mi_Arbol.Eliminar(Dato);
                    TxtDato.Clear();
                    TxtDato.Focus();

                    cont++;

                    Refresh();
                    Refresh();
                }
            }
        }

        private void TxtAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
