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
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            InitializeComponent();
            SoundPlayer sonido = new SoundPlayer(@"C:/Users/mauro/source/repos/Arbol_Binario/Arbol_Binario/bin/Debug/Sonidos/sound_menu.wav");
            sonido.Play();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MenuForm MenuForm = new MenuForm();
            MenuForm.Show();
            this.Hide();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
