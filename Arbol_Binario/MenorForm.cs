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
    public partial class MenorForm : Form
    {
        public MenorForm()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GBSuma_Enter(object sender, EventArgs e)
        {
            int menor = ExtrasData.menor;

            LblSuma.Text = menor.ToString();
        }
    }
}
