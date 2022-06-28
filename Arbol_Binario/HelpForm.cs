using System;
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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            SoundPlayer sonido = new SoundPlayer(@"C:/Users/mauro/source/repos/Arbol_Binario/Arbol_Binario/bin/Debug/Sonidos/sound_menu.wav");
            sonido.Play();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encarga de ir creando el arbol dependiendo del valor que agregues, no se puede repetir los valores ni tampoco agregar un numero mayor a 99", "Boton Insertar");

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encarga de decir si existe o no el nodo con el dato introducido", "Boton Buscar");

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encarga de eliminar el nodo con el dato introducido", "Boton Eliminar");

        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encarga de sumar los datos de todos los nodos que existen en el arbol", "Boton Suma");

        }

        private void BtnMultiplos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encarga de mostrar la suma de los que son multiplos de 2, 3 y 5", "Boton Multiplos");

        }

        private void BtnMayor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encarga de mostrar el nodo mayor del arbol", "Boton Mayor");

        }

        private void BtnMenor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encarga de mostrar el nodo menor del arbol", "Boton Menor");

        }

        private void BtnAltura_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encarga de mostrar la altura del arbol", "Boton Altura");

        }

        private void BtnRecorrido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se encarga de mostrar el recorrido en PosOrden, Inorden y PreOrden del arbol", "Boton Recorrido");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MenuForm MenuForm = new MenuForm();
            MenuForm.Show();
            this.Hide();
        }
    }
}
