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
    public partial class frmEditarLivro : Form
    {
        public frmEditarLivro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmEditarLivro.ActiveForm.Close();
        }
    }
}
