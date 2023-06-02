using System;
using System.Windows.Forms;

namespace CalculoIndenizacao
{
    public partial class UcCalculo : MetroFramework.Controls.MetroUserControl
    {
        public UcCalculo()
        {
            InitializeComponent();
        }

        bool abrir = true;
        private void MtTlCalCalcular_Click(object sender, EventArgs e)
        {
            FrmCalculoEstabilidade calculoEstabilidade = new FrmCalculoEstabilidade();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmCalculoEstabilidade)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                calculoEstabilidade.Show();
            }
        }

        private void MtTlCalListCalculo_Click(object sender, EventArgs e)
        {
            FrmListaCalculo listaCalculo = new FrmListaCalculo();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmListaCalculo)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                listaCalculo.Show();
            }
        }
    }
}
