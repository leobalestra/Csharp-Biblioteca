using System;
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
    public partial class frmDevolver : Form
    {
        public int _codTitulo1;
        public int _codCliente1;
        public int _codTitulo2;
        public int _codCliente2;
        public frmDevolver()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == "") 
            {
                frmReservar.ActiveForm.Close();
            }
            else if (MessageBox.Show("Deseja fechar?", "Devolver", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                frmReservar.ActiveForm.Close();
            }
        }

        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            int achou = 0;
            int livro = 0;
            List<string> dados = DataTXT.ReadFileLivrosAlugados();
            for (int i = 0; i < dados.Count; i++)
            {
                string linha = dados[i];
                var array = linha.Split('|');
                if(array[6] == "")
                {
                    int codLivro = Convert.ToInt32(array[0]);
                    int codCliente = Convert.ToInt32(array[2]);
                    if (rdbCliente.Checked)
                    {
                        if (codCliente == Convert.ToInt32(txtCodigo.Value))
                        {
                            txtNomeCliente.Text = DataTXT.NomeCliente(Convert.ToInt32(array[2]));
                            txtQtdLivrosCliente.Text = (DataTXT.QtdLivrosAlugadosCliente(Convert.ToInt32(array[2]))).ToString();
                            livro++;
                            if (livro > 1)
                            {
                                _codCliente2 = Convert.ToInt32(array[2]);
                                _codTitulo2 = Convert.ToInt32(array[1]);
                                txtCodLivro2.Visible = true;
                                txtNomeLivro2.Visible = true;
                                txtDataAluguel2.Visible = true;
                                txtDataDevolucao2.Visible = true;
                                groupBox2.Visible = true;
                                lblCodLivro2.Visible = true;
                                lblNomeLivro2.Visible = true;
                                lblDiaDoAluguel2.Visible = true;
                                lblDataParaDevolucao2.Visible = true;

                                txtCodLivro2.Text = codLivro.ToString();
                                txtNomeLivro2.Text = DataTXT.NomeLivro(codLivro);
                                txtDataAluguel2.Text = array[4];
                                txtDataDevolucao2.Text = (Convert.ToDateTime(array[4]).AddDays(Convert.ToInt32(array[5]))).ToString("dd/MM/yyyy");
                                btnDevolver2.Visible = true;
                                btnDevolver2.Enabled = true;
                            }
                            else
                            {
                                _codCliente1 = Convert.ToInt32(array[2]);
                                _codTitulo1 = Convert.ToInt32(array[1]);
                                txtCodLivro1.Text = codLivro.ToString();
                                txtNomeLivro1.Text = DataTXT.NomeLivro(codLivro);
                                txtDataAluguel1.Text = array[4];
                                txtDataDevolucao1.Text = (Convert.ToDateTime(array[4]).AddDays(Convert.ToInt32(array[5]))).ToString("dd/MM/yyyy");
                                btnDevolver1.Enabled = true;

                                txtCodLivro2.Visible = false;
                                txtNomeLivro2.Visible = false;
                                txtDataAluguel2.Visible = false;
                                txtDataDevolucao2.Visible = false;
                                groupBox2.Visible = false;
                                lblCodLivro2.Visible = false;
                                lblNomeLivro2.Visible = false;
                                lblDiaDoAluguel2.Visible = false;
                                lblDataParaDevolucao2.Visible = false;
                            }
                            achou = 1;
                        }
                    }
                    else
                    {
                        if (codLivro == Convert.ToInt32(txtCodigo.Value))
                        {
                            _codCliente1 = Convert.ToInt32(array[2]);
                            _codTitulo1 = Convert.ToInt32(array[1]);
                            txtNomeCliente.Text = DataTXT.NomeCliente(Convert.ToInt32(array[2]));
                            txtQtdLivrosCliente.Text = (DataTXT.QtdLivrosAlugadosCliente(Convert.ToInt32(array[2]))).ToString();
                            txtCodLivro1.Text = codLivro.ToString();
                            txtNomeLivro1.Text = DataTXT.NomeLivro(codLivro);
                            txtDataAluguel1.Text = array[4];
                            txtDataDevolucao1.Text = (Convert.ToDateTime(array[4]).AddDays(Convert.ToInt32(array[5]))).ToString("dd/MM/yyyy");
                            btnDevolver1.Enabled = true;
                            achou = 1;
                            txtCodLivro2.Visible = false;
                            txtNomeLivro2.Visible = false;
                            txtDataAluguel2.Visible = false;
                            txtDataDevolucao2.Visible = false;
                            groupBox2.Visible = false;
                            lblCodLivro2.Visible = false;
                            lblNomeLivro2.Visible = false;
                            lblDiaDoAluguel2.Visible = false;
                            lblDataParaDevolucao2.Visible = false;
                            btnDevolver2.Visible = false;
                            break;
                        }
                    }
                }
            }
            if (achou == 0)
            {
                MessageBox.Show("Reserva não encontrada");
                txtCodLivro2.Visible = false;
                txtNomeLivro2.Visible = false;
                txtDataAluguel2.Visible = false;
                txtDataDevolucao2.Visible = false;
                groupBox2.Visible = false;
                lblCodLivro2.Visible = false;
                lblNomeLivro2.Visible = false;
                lblDiaDoAluguel2.Visible = false;
                lblDataParaDevolucao2.Visible = false;
                btnDevolver2.Visible = false;
                txtNomeCliente.Text = "";
                txtQtdLivrosCliente.Text = "";
                txtCodLivro1.Text = "";
                txtNomeLivro1.Text = "";
                txtDataAluguel1.Text = "";
                txtDataDevolucao1.Text = "";
                _codCliente1 = 0;
                _codTitulo1 = 0;
                _codCliente2 = 0;
                _codTitulo2 = 0;
                btnDevolver1.Enabled = false;
            }
        }

        public void btnDevolver1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja devolver livro?", "Devolver", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string linhaAtual = MontarLinhaDevolver(1);
                string linhaNova = linhaAtual + DateTime.Now.ToString("dd/MM/yyyy");
                if (DataTXT.InserirLinhaDevolucao(linhaAtual, linhaNova))
                {
                    MessageBox.Show("Livro Devolvido");
                    btnPesquisar.PerformClick();
                }
            }            
        }

        private void btnDevolver2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja devolver livro?", "Devolver", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string linhaAtual = MontarLinhaDevolver(2);
                string linhaNova = linhaAtual + DateTime.Now.ToString("dd/MM/yyyy");
                if (DataTXT.InserirLinhaDevolucao(linhaAtual, linhaNova))
                {
                    MessageBox.Show("Livro Devolvido");
                    btnPesquisar.PerformClick();
                }
            }
        }

        public string MontarLinhaDevolver(int numero)
        {
            string linha;
            if (numero == 1)
            {
                linha = txtCodLivro1.Text + "|" +
               _codTitulo1 + "|" +
               _codCliente1 + "|" +
               frmLogon._loginAtual + "|" +
               txtDataAluguel1.Text + "|" +
               (Convert.ToDateTime(txtDataDevolucao1.Text) - Convert.ToDateTime(txtDataAluguel1.Text)).Days + "|";
            }
            else
            {
                linha = txtCodLivro2.Text + "|" +
                _codTitulo2 + "|" +
                _codCliente2 + "|" +
                frmLogon._loginAtual + "|" +
                txtDataAluguel2 + "|" +
                (Convert.ToDateTime(txtDataDevolucao2) - Convert.ToDateTime(txtDataAluguel2)).Days + "|";
            }
            return linha;
        }
    }
}
