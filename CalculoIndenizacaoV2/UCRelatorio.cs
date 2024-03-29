﻿using System;
using System.Windows.Forms;

namespace CalculoIndenizacao;

public partial class UCRelatorio : MetroFramework.Controls.MetroUserControl
{
    public UCRelatorio()
    {
        InitializeComponent();
    }
    bool abrir = true;
    private void MtTlListarDemons_Click(object sender, EventArgs e)
    {
        FrmListaRelatorio listaRelatorio = new();
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
}
