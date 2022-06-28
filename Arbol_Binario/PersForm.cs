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
    public partial class PersForm : Form
    {
        public PersForm()
        {
            InitializeComponent();
        }

        private void BtnOp1_Click(object sender, EventArgs e)
        {
            int op = 1;
            OpPers.opcion = op;
            GameForm GameForm = new GameForm();
            GameForm.Show();
            this.Hide();
        }

        private void BtnOp2_Click(object sender, EventArgs e)
        {
            int op = 2;
            OpPers.opcion = op;
            GameForm GameForm = new GameForm();
            GameForm.Show();
            this.Hide();
        }

        private void BtnOp3_Click(object sender, EventArgs e)
        {
            int op = 3;
            OpPers.opcion = op;
            GameForm GameForm = new GameForm();
            GameForm.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            MenuForm MenuForm = new MenuForm();
            MenuForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
