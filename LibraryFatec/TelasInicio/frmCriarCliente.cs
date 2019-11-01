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
    public partial class frmCriarCliente : Form
    {
        public frmCriarCliente()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmCriarCliente.ActiveForm.Close();
        }

        private void frmCriarCliente_Load(object sender, EventArgs e)
        {
            List<string> dados = DataTXT.ReadFileClientes();
            List<Cliente> lista = new List<Cliente>();

            for (int i = 0; i < dados.Count; i++)
            {
                string linha = dados[i];
                var array = linha.Split('|');
                string nome = array[1].ToString();
                int id = Convert.ToInt32(array[0]);
                lista.Add(new Cliente() { Nome = nome, Id = id });
            }            
            dgvClientes.DataSource = lista;
            foreach (DataGridViewColumn column in dgvClientes.Columns)
            {
                column.ReadOnly = false;
                if (column.DataPropertyName == "Id")
                    column.Width = 30;
                else
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
        }

        public class Cliente
        {
            public int Id { get; set; }
            public string Nome { get; set; }          
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == Convert.ToInt32(txtCodigo.Value))
                {
                    dgvClientes.ClearSelection();
                    dgvClientes.FirstDisplayedScrollingRowIndex = row.Index;
                    dgvClientes.Rows[row.Index].Selected = true;
                }
            }
        }

        private void SelecionarLinha()
        {
            dgvClientes.Rows[dgvClientes.CurrentCell.RowIndex].Selected = true;
            //dgvClientes. = 0; preciso da celula do codgio selecionado
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarLinha();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //dgvClientes.
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

        }
    }
}
