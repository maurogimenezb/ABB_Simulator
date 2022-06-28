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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            SoundPlayer sonido = new SoundPlayer(@"C:/Users/mauro/source/repos/Arbol_Binario/Arbol_Binario/bin/Debug/Sonidos/sound_menu.wav");
            sonido.Play();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnGame_Click(object sender, EventArgs e)
        {
            PersForm PersForm = new PersForm();
            PersForm.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm AuthorForm = new AuthorForm();
            AuthorForm.Show();
            this.Hide();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            HelpForm HelpForm = new HelpForm();
            HelpForm.Show();
            this.Hide();
        }
    }
}
