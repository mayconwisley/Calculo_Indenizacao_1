using System;
using System.Windows.Forms;

namespace CalculoIndenizacao
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        static FrmPrincipal _instance;

        public static FrmPrincipal Instance

        {
            get
            {
                _instance ??= new FrmPrincipal();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return MtPnlPrincipal; }
            set { MtPnlPrincipal = value; }
        }

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

        private void MenuCadastroEmpregado_Click(object sender, EventArgs e)
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

        private void MenuCadastroComplemento_Click(object sender, EventArgs e)
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

        private void CalcularToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void MenuRelatorioListarDemonstrativo_Click(object sender, EventArgs e)
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

        private void ListaDeCalculosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MtTlCadastro_Click(object sender, EventArgs e)
        {
            if (!FrmPrincipal.Instance.MetroContainer.Controls.ContainsKey("UCCadastro"))
            {
                UCCadastro uCCadastro = new()
                {
                    Dock = DockStyle.Fill
                };
                FrmPrincipal.Instance.MetroContainer.Controls.Add(uCCadastro);
            }
            FrmPrincipal.Instance.MetroContainer.Controls["UCCadastro"].BringToFront();
        }

        private void MtTlCalculo_Click(object sender, EventArgs e)
        {
            if (!FrmPrincipal.Instance.MetroContainer.Controls.ContainsKey("UcCalculo"))
            {
                UcCalculo ucCalculo = new()
                {
                    Dock = DockStyle.Fill
                };
                FrmPrincipal.Instance.MetroContainer.Controls.Add(ucCalculo);
            }
            FrmPrincipal.Instance.MetroContainer.Controls["UcCalculo"].BringToFront();
        }

        private void MtTlRelatorio_Click(object sender, EventArgs e)
        {
            if (!FrmPrincipal.Instance.MetroContainer.Controls.ContainsKey("UCRelatorio"))
            {
                UCRelatorio uCRelatorio = new()
                {
                    Dock = DockStyle.Fill
                };
                FrmPrincipal.Instance.MetroContainer.Controls.Add(uCRelatorio);
            }
            FrmPrincipal.Instance.MetroContainer.Controls["UCRelatorio"].BringToFront();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            _instance = this;
        }

        private void MtTlSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
