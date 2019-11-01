using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFatec
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
            lblUsuarioConectado.Text = frmLogon._nomeAtual;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o sistema?", "LibraryFatec", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void btnReservarLivro_Click(object sender, EventArgs e)
        {
            frmReservar reservar = new frmReservar();
            reservar.ShowDialog();
        }

        private void btnDevolverLivro_Click(object sender, EventArgs e)
        {
            frmDevolver devolverLivro = new frmDevolver();
            devolverLivro.ShowDialog();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmCriarCliente cadastrarCliente = new frmCriarCliente();
            cadastrarCliente.ShowDialog();
        }

        private void btnEditarLivro_Click(object sender, EventArgs e)
        {
            frmEditarLivro editarLivro = new frmEditarLivro();
            editarLivro.ShowDialog();
        }

        private void btnCadastrarProfissional_Click(object sender, EventArgs e)
        {
            frmCriarProfissional criarProfissional = new frmCriarProfissional();
            criarProfissional.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            frmRelatorios relatorios = new frmRelatorios();
            relatorios.ShowDialog();
        }
    }
}
