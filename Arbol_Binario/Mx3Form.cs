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
    public partial class Mx3Form : Form
    {
        public Mx3Form()
        {
            InitializeComponent();
        }

        private void Btnx2_Click(object sender, EventArgs e)
        {
            Mx2Form Mx2Form = new Mx2Form();
            Mx2Form.Show();
            this.Hide();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GBSuma_Enter(object sender, EventArgs e)
        {
            int suma = MultiplosData.sumax3;

            LblData.Text = MultiplosData.datax3;

            LblSuma.Text = suma.ToString();
        }

        private void Btnx5_Click(object sender, EventArgs e)
        {
            Mx5Form Mx5Form = new Mx5Form();
            Mx5Form.Show();
            this.Hide();
        }
    }
}
