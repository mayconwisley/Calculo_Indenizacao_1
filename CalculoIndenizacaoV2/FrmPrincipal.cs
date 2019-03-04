using System;
using System.Windows.Forms;

namespace CalculoIndenizacao
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        FrmCadastroEmpragado cadastroEmpragado;
        FrmCadastroComplemento cadastroComplemento;
        FrmCalculoEstabilidade calculoEstabilidade;
        FrmListaRelatorio listaRelatorio;
        FrmListaCalculo listaCalculo;
        bool abrir = true;

        private void menuCadastroEmpregado_Click(object sender, EventArgs e)
        {
            cadastroEmpragado = new FrmCadastroEmpragado();
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

        private void menuCadastroComplemento_Click(object sender, EventArgs e)
        {
            cadastroComplemento = new FrmCadastroComplemento();
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

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculoEstabilidade = new FrmCalculoEstabilidade();
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

        private void menuRelatorioListarDemonstrativo_Click(object sender, EventArgs e)
        {
            listaRelatorio = new FrmListaRelatorio();
            foreach (Form item in Application.OpenForms)
            {
                if (item is FrmListaRelatorio)
                {
                    item.Focus();
                    abrir = false;
                }
            }
            if (abrir)
            {
                listaRelatorio.Show();
            }
        }

        private void listaDeCalculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaCalculo = new FrmListaCalculo();
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

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
