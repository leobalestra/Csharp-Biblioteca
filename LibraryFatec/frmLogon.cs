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
    public partial class frmLogon : Form
    {
        public static string _loginAtual;
        public static string _senhaAtual;
        public static string _nomeAtual;
        public static int _idUserAtual;
        DateTime _dataCadastro;

        public frmLogon()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (ValidarLogin(txtUsuario.Text, txtSenha.Text)) {
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                btnConectar.Enabled = false;
                frmTelaPrincipal novafrm = new frmTelaPrincipal();
                novafrm.ShowDialog();
                }
            else
                MessageBox.Show("Usuário/senha inválidos");
        }

        public bool ValidarLogin(string usuario, string senha)
        {
            List<string> dados = DataTXT.ReadFileUser();
            for (int i = 0; i < dados.Count; i++)
            {
                string linha = dados[i];
                var array = linha.Split('|');
                _idUserAtual = Convert.ToInt32(array[0]);
                _loginAtual = array[1];
                _senhaAtual = array[2];
                _nomeAtual = array[3];
                _dataCadastro = Convert.ToDateTime(array[4]);
                if(_loginAtual == usuario)
                    if(_senhaAtual == senha)
                        return true;
            }
            return false;            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmLogon.ActiveForm.Close();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
                btnConectar.PerformClick();
        }
    }
}
