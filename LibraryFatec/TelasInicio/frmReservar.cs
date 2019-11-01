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
    public partial class frmReservar : Form
    {
        public frmReservar()
        {
            InitializeComponent();
        }

        private void btnPesquisarLivro_Click(object sender, EventArgs e)
        {
            int achou = 0;
            List<string> dados = DataTXT.ReadFileLivros();
            for (int i = 0; i < dados.Count; i++)
            {
                string linha = dados[i];
                var array = linha.Split('|');
                int codLivro = Convert.ToInt32(array[0]);
                int codTituloLivro = Convert.ToInt32(array[1]);
                if (rdbCodLivro.Checked)
                {
                    if (codLivro == Convert.ToInt32(txtCodigo.Value))
                    {
                        txtCodigoTitulo.Text = array[1];
                        txtNome.Text = array[2];
                        txtAutor.Text = array[3];
                        txtEditora.Text = array[4];
                        txtQtd.Text = DataTXT.QtdLivrosTotalCodigo(Convert.ToInt32(txtCodigoTitulo.Text)).ToString();
                        lblQtdDisponivel.Text = (Convert.ToInt32(txtQtd.Text) - DataTXT.QtdLivrosAlugadosCodigo(Convert.ToInt32(txtCodigoTitulo.Text))).ToString();
                        if (Convert.ToInt32(lblQtdDisponivel.Text) > 0)
                        {
                            if (DataTXT.VerificarLivroEmAluguel(Convert.ToInt32(txtCodigo.Text)))
                            {
                                lblLivroEmAluguel.Text = "Livro em aluguel";
                                lblLivroEmAluguel.ForeColor = Color.Red;
                                lblLivroEmAluguel.Enabled = true;
                                txtCodigoCliente.Enabled = false;
                                btnPesquisarCliente.Enabled = false;
                            }
                            else
                            {
                                lblLivroEmAluguel.Text = "";
                                txtCodigoCliente.Enabled = true;
                                btnPesquisarCliente.Enabled = true;
                            }
                            lblQtdDisponivel.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblQtdDisponivel.ForeColor = Color.Red;
                            txtCodigoCliente.Text = "";
                            txtNomeCliente.Text = "";
                            lblQtdLivrosAlugados.Text = "";
                            txtCodigoCliente.Enabled = false;
                            btnPesquisarCliente.Enabled = false;
                            lblDiasAluguel.Visible = false;
                            comDiasAluguel.Visible = false;
                            btnAlugar.Visible = false;
                        }
                        achou = 1;
                        break;
                    }
                }
                else
                {
                    if (codTituloLivro == Convert.ToInt32(txtCodigoTitulo.Value))
                    {
                        txtCodigo.Text = array[0];
                        txtNome.Text = array[2];
                        txtAutor.Text = array[3];
                        txtEditora.Text = array[4];
                        txtQtd.Text = DataTXT.QtdLivrosTotalCodigo(Convert.ToInt32(txtCodigoTitulo.Text)).ToString();
                        lblQtdDisponivel.Text = (Convert.ToInt32(txtQtd.Text) - DataTXT.QtdLivrosAlugadosCodigo(Convert.ToInt32(txtCodigoTitulo.Text))).ToString();
                        if (Convert.ToInt32(lblQtdDisponivel.Text) > 0)
                        {
                            if (DataTXT.VerificarLivroEmAluguel(Convert.ToInt32(txtCodigo.Text)))
                            {
                                lblLivroEmAluguel.Text = "Livro em aluguel";
                                lblLivroEmAluguel.ForeColor = Color.Red;
                                lblLivroEmAluguel.Enabled = true;
                                txtCodigoCliente.Enabled = false;
                                btnPesquisarCliente.Enabled = false;
                            }
                            else
                            {
                                lblLivroEmAluguel.Text = "";
                                txtCodigoCliente.Enabled = true;
                                btnPesquisarCliente.Enabled = true;
                            }
                            lblQtdDisponivel.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblQtdDisponivel.ForeColor = Color.Red;
                            txtCodigoCliente.Text = "";
                            txtNomeCliente.Text = "";
                            lblQtdLivrosAlugados.Text = "";
                            txtCodigoCliente.Enabled = false;
                            btnPesquisarCliente.Enabled = false;
                            lblDiasAluguel.Visible = false;
                            comDiasAluguel.Visible = false;
                            btnAlugar.Visible = false;
                        }
                        achou = 1;
                        break;
                    }
                }
            }
            if (achou == 0)
            {
                txtNome.Text = "";
                txtAutor.Text = "";
                txtEditora.Text = "";
                txtQtd.Text = "";
                lblQtdDisponivel.Text = "";
                txtCodigoCliente.Text = "";
                txtNomeCliente.Text = "";
                btnAlugar.Visible = false;
                lblDiasAluguel.Visible = false;
                comDiasAluguel.Visible = false;
                txtCodigoCliente.Enabled = false;
                txtNomeCliente.Enabled = false;
                btnPesquisarCliente.Enabled = false;
                MessageBox.Show("Livro não localizado!");
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            int achou = 0;
            List<string> dados = DataTXT.ReadFileClientes();
            for (int i = 0; i < dados.Count; i++)
            {
                string linha = dados[i];
                var array = linha.Split('|');
                int codUsuario = Convert.ToInt32(array[0]);

                if (codUsuario == Convert.ToInt32(txtCodigoCliente.Value))
                {
                    txtNomeCliente.Text = array[1];
                    lblQtdLivrosAlugados.Text = (DataTXT.QtdLivrosAlugadosCliente(Convert.ToInt32(txtCodigoCliente.Value))).ToString();
                    if (Convert.ToInt32(lblQtdLivrosAlugados.Text) < 2)
                    {
                        btnAlugar.Visible = true;
                        lblDiasAluguel.Visible = true;
                        comDiasAluguel.Visible = true;
                        lblQtdLivrosAlugados.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblQtdLivrosAlugados.ForeColor = Color.Red;
                        btnAlugar.Visible = false;
                        lblDiasAluguel.Visible = false;
                        comDiasAluguel.Visible = false;
                    }
                    achou = 1;
                    break;
                }
            }
            if (achou == 0)
            {
                txtNomeCliente.Text = "";
                lblQtdLivrosAlugados.Text = "";
                MessageBox.Show("Cliente não localizado!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                frmReservar.ActiveForm.Close();
            }
            else if (MessageBox.Show("Deseja fechar?", "Reservar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                frmReservar.ActiveForm.Close();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
                btnPesquisarLivro.PerformClick();
        }

        private void rdbCodLivro_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigoTitulo.Enabled = false;
            txtCodigo.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtCodigoTitulo.Enabled = true;
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            string linhaAluguel = MontarLinhaAluguel();
            if (MessageBox.Show("Deseja alugar livro?\n\nLivro: "+txtNome.Text+"\nCliente: "+txtNomeCliente.Text+"\nDias de aluguel: "+comDiasAluguel.Text, "LibraryFatec", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (DataTXT.InserirLinhaAluguel(linhaAluguel))
                {
                    MessageBox.Show("Livro alugado");
                    btnPesquisarCliente.PerformClick();
                    btnPesquisarLivro.PerformClick();                    
                }
            }
        }

        public string MontarLinhaAluguel()
        {
            string linha;
            linha = txtCodigo.Value.ToString() + "|"
                  + txtCodigoTitulo.Text + "|"
                  + txtCodigoCliente.Value.ToString() + "|"
                  + frmLogon._loginAtual + "|"
                  + DateTime.Now.ToString("dd/MM/yyyy") + "|"
                  + comDiasAluguel.Text + "|";
            return linha;
        }


    }
}
