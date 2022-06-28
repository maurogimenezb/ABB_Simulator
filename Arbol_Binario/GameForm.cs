﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


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
        Nodo_Arbol Raiz = new Nodo_Arbol(); // creacion del objeto arbol

        //Nodo_Arbol mi_Arbol2 = new Nodo_Arbol(null); // creacion del objeto arbol

        Graphics g; //definicion del objeto grafico

        private void Form1_Paint(object sender, PaintEventArgs en)
        {
            en.Graphics.Clear(this.BackColor);
            en.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = en.Graphics;

            mi_Arbol.DibujarArbol(g, this.Font, Brushes.SeaGreen, Brushes.White, Pens.SeaGreen, Brushes.White);
        }



        private void BtnEliminar_Click(object sender, EventArgs e)
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
                    mi_Arbol.Eliminar(Dato);
                    SoundPlayer sonido = new SoundPlayer(@"C:/Users/mauro/source/repos/Arbol_Binario/Arbol_Binario/bin/Debug/Sonidos/sound_eliminar.wav");
                    sonido.Play();
                    TxtDato.Clear();
                    TxtDato.Focus();

                    cont++;

                    Refresh();
                    Refresh();
                }
            }
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
                    SoundPlayer sonido = new SoundPlayer(@"C:/Users/mauro/source/repos/Arbol_Binario/Arbol_Binario/bin/Debug/Sonidos/sound_insertar.wav");
                    sonido.Play();
                    TxtDato.Clear();
                    TxtDato.Focus();

                    cont++;

                    Refresh();
                    Refresh();
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtDato.Text == "")
            {
                MessageBox.Show("Debe ingresar un dato");
            }
            else
            {
                Dato = int.Parse(TxtDato.Text);
                mi_Arbol.Buscar(Dato);
                TxtDato.Clear();
                TxtDato.Focus();
            }
        }

        private void BtnAltura_Click(object sender, EventArgs e)
        {

           // int h = 0;
           // MessageBox.Show("La altura es: " + Raiz.alturaABB(ref Raiz, ref h));
            mi_Arbol.Altura();
            //Refresh();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            mi_Arbol.Suma();
            // Refresh();
        }

        private void BtnMultiplos_Click(object sender, EventArgs e)
        {
            mi_Arbol.Multiplos();
           // Refresh();
        }

        private void BtnRecorrido_Click(object sender, EventArgs e)
        {
            mi_Arbol.Recorrido();

        }

        private void BtnMayor_Click(object sender, EventArgs e)
        {
            mi_Arbol.Mayor();

        }

        private void BtnMenor_Click(object sender, EventArgs e)
        {
            mi_Arbol.Menor();

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MenuForm MenuForm = new MenuForm();
            MenuForm.Show();
            this.Hide();
        }
    }
}
