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
    public partial class Mx2Form : Form
    {
        public Mx2Form()
        {
            InitializeComponent();
        }
        Arbol_Binario mi_Arbol = new Arbol_Binario(null); // creacion del objeto arbol


        private void GBSuma_Enter(object sender, EventArgs e)
        {
           int suma = MultiplosData.sumax2;

            LblData.Text = MultiplosData.datax2;

            LblSuma.Text = suma.ToString();

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Btnx3_Click(object sender, EventArgs e)
        {
            Mx3Form Mx3Form = new Mx3Form();
            Mx3Form.Show();
            this.Hide();
        }

        private void Btnx5_Click(object sender, EventArgs e)
        {
            Mx5Form Mx5Form = new Mx5Form();
            Mx5Form.Show();
            this.Hide();
        }
    }
}
