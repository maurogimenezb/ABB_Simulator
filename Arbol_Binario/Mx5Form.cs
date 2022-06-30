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
    public partial class Mx5Form : Form
    {
        public Mx5Form()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btnx2_Click(object sender, EventArgs e)
        {
            Mx2Form Mx2Form = new Mx2Form();
            Mx2Form.Show();
            this.Hide();
        }

        private void Btnx3_Click(object sender, EventArgs e)
        {
            Mx3Form Mx3Form = new Mx3Form();
            Mx3Form.Show();
            this.Hide();
        }

        private void GBSuma_Enter(object sender, EventArgs e)
        {
            int suma = MultiplosData.sumax5;

            LblData.Text = MultiplosData.datax5;

            LblSuma.Text = suma.ToString();
        }
    }
}
