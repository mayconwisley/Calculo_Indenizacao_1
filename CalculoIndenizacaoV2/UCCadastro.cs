using System;
using System.Windows.Forms;

namespace CalculoIndenizacao
{
    public partial class UCCadastro : MetroFramework.Controls.MetroUserControl
    {
        public UCCadastro()
        {
            InitializeComponent();
        }

        bool abrir = true;
        private void MtTlCadEmpregado_Click(object sender, EventArgs e)
        {
            FrmCadastroEmpragado cadastroEmpragado = new FrmCadastroEmpragado();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmCadastroEmpragado)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                cadastroEmpragado.Show();
            }
        }

        private void MtTlCadComplemento_Click(object sender, EventArgs e)
        {
            FrmCadastroComplemento cadastroComplemento = new FrmCadastroComplemento();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmCadastroComplemento)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                cadastroComplemento.Show();
            }
        }
    }
}
