using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // Libreria para reproducir los sonidos


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
        Arbol_Binario mi_Arbol = new Arbol_Binario(null); // creacion del objeto arbol
        Graphics g; //definicion del objeto grafico

        private void Form1_Paint(object sender, PaintEventArgs en)
        {

            if (OpPers.opcion == 1)
            {
                en.Graphics.Clear(this.BackColor);
                en.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g = en.Graphics;

                mi_Arbol.DibujarArbol(g, this.Font, Brushes.SeaGreen, Brushes.White, Pens.SeaGreen, Brushes.White);
            }

            else if (OpPers.opcion == 2)
            {
                en.Graphics.Clear(this.BackColor);
                en.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g = en.Graphics;

                mi_Arbol.DibujarArbol(g, this.Font, Brushes.Red, Brushes.White, Pens.Red, Brushes.White);
            }

            else if (OpPers.opcion == 3)
            {
                en.Graphics.Clear(this.BackColor);
                en.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g = en.Graphics;

                mi_Arbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Blue, Brushes.White);
            }

        }




        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtDato.Text == "")
            {
                DatoForm DatoForm = new DatoForm();
                DatoForm.Show();
            }
            else
            {
                Dato = int.Parse(TxtDato.Text);

                mi_Arbol.Eliminar(Dato);
                    SoundPlayer sonido = new SoundPlayer(@"C:/Users/mauro/source/repos/Arbol_Binario/Arbol_Binario/bin/Debug/Sonidos/sound_eliminar.wav");
                    sonido.Play();
                    TxtDato.Clear();
                    //TxtDato.Focus();
                    Refresh();
            }
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (TxtDato.Text == "")
            {
                DatoForm DatoForm = new DatoForm();
                DatoForm.Show();
            }

            else
            {
                Dato = int.Parse(TxtDato.Text);

                    mi_Arbol.Insertar(Dato);
                    SoundPlayer sonido = new SoundPlayer(@"C:/Users/mauro/source/repos/Arbol_Binario/Arbol_Binario/bin/Debug/Sonidos/sound_insertar.wav");
                    sonido.Play();
                    TxtDato.Clear();
                   // TxtDato.Focus();
                    Refresh();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtDato.Text == "")
            {
                DatoForm DatoForm = new DatoForm();
                DatoForm.Show();
            }
            else
            {
                Dato = int.Parse(TxtDato.Text);
                mi_Arbol.Buscar(Dato);
                TxtDato.Clear();
                //TxtDato.Focus();
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

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            PersForm PersForm = new PersForm();
            PersForm.Show();
            this.Hide();

            SoundPlayer sonido = new SoundPlayer(@"C:/Users/mauro/source/repos/Arbol_Binario/Arbol_Binario/bin/Debug/Sonidos/sound_menu.wav");
            sonido.Play();
        }
    }
}
