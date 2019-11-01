namespace LibraryFatec
{
    partial class frmDevolver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.NumericUpDown();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbLivro = new System.Windows.Forms.RadioButton();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdLivrosCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDevolver1 = new System.Windows.Forms.Button();
            this.txtDataDevolucao1 = new System.Windows.Forms.TextBox();
            this.lblDataParaDevolucao1 = new System.Windows.Forms.Label();
            this.txtDataAluguel1 = new System.Windows.Forms.TextBox();
            this.txtNomeLivro1 = new System.Windows.Forms.TextBox();
            this.lblDiaDoAluguel1 = new System.Windows.Forms.Label();
            this.txtCodLivro1 = new System.Windows.Forms.TextBox();
            this.lblCodLivro1 = new System.Windows.Forms.Label();
            this.lblNomeLivro1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDevolver2 = new System.Windows.Forms.Button();
            this.txtDataDevolucao2 = new System.Windows.Forms.TextBox();
            this.lblDataParaDevolucao2 = new System.Windows.Forms.Label();
            this.txtDataAluguel2 = new System.Windows.Forms.TextBox();
            this.txtNomeLivro2 = new System.Windows.Forms.TextBox();
            this.lblDiaDoAluguel2 = new System.Windows.Forms.Label();
            this.txtCodLivro2 = new System.Windows.Forms.TextBox();
            this.lblCodLivro2 = new System.Windows.Forms.Label();
            this.lblNomeLivro2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdbLivro);
            this.panel1.Controls.Add(this.rdbCliente);
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 40);
            this.panel1.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(285, 9);
            this.txtCodigo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(77, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPesquisar.ForeColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Image = global::LibraryFatec.Properties.Resources.loupe;
            this.btnPesquisar.Location = new System.Drawing.Point(368, 6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(28, 25);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar por:";
            // 
            // rdbLivro
            // 
            this.rdbLivro.AutoSize = true;
            this.rdbLivro.Checked = true;
            this.rdbLivro.Location = new System.Drawing.Point(193, 9);
            this.rdbLivro.Name = "rdbLivro";
            this.rdbLivro.Size = new System.Drawing.Size(69, 17);
            this.rdbLivro.TabIndex = 1;
            this.rdbLivro.TabStop = true;
            this.rdbLivro.Text = "Cód. livro";
            this.rdbLivro.UseVisualStyleBackColor = true;
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Location = new System.Drawing.Point(106, 9);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(81, 17);
            this.rdbCliente.TabIndex = 0;
            this.rdbCliente.Text = "Cód. cliente";
            this.rdbCliente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Qtd. livros com cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome do cliente:";
            // 
            // txtQtdLivrosCliente
            // 
            this.txtQtdLivrosCliente.Enabled = false;
            this.txtQtdLivrosCliente.Location = new System.Drawing.Point(132, 133);
            this.txtQtdLivrosCliente.Name = "txtQtdLivrosCliente";
            this.txtQtdLivrosCliente.Size = new System.Drawing.Size(65, 20);
            this.txtQtdLivrosCliente.TabIndex = 10;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(132, 107);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(288, 20);
            this.txtNomeCliente.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDevolver1);
            this.groupBox1.Controls.Add(this.txtDataDevolucao1);
            this.groupBox1.Controls.Add(this.lblDataParaDevolucao1);
            this.groupBox1.Controls.Add(this.txtDataAluguel1);
            this.groupBox1.Controls.Add(this.txtNomeLivro1);
            this.groupBox1.Controls.Add(this.lblDiaDoAluguel1);
            this.groupBox1.Controls.Add(this.txtCodLivro1);
            this.groupBox1.Controls.Add(this.lblCodLivro1);
            this.groupBox1.Controls.Add(this.lblNomeLivro1);
            this.groupBox1.Location = new System.Drawing.Point(13, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 99);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnDevolver1
            // 
            this.btnDevolver1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDevolver1.Enabled = false;
            this.btnDevolver1.Location = new System.Drawing.Point(320, 16);
            this.btnDevolver1.Name = "btnDevolver1";
            this.btnDevolver1.Size = new System.Drawing.Size(87, 20);
            this.btnDevolver1.TabIndex = 8;
            this.btnDevolver1.Text = "Devolver";
            this.btnDevolver1.UseVisualStyleBackColor = false;
            this.btnDevolver1.Click += new System.EventHandler(this.btnDevolver1_Click);
            // 
            // txtDataDevolucao1
            // 
            this.txtDataDevolucao1.Enabled = false;
            this.txtDataDevolucao1.Location = new System.Drawing.Point(320, 69);
            this.txtDataDevolucao1.Name = "txtDataDevolucao1";
            this.txtDataDevolucao1.Size = new System.Drawing.Size(87, 20);
            this.txtDataDevolucao1.TabIndex = 7;
            // 
            // lblDataParaDevolucao1
            // 
            this.lblDataParaDevolucao1.AutoSize = true;
            this.lblDataParaDevolucao1.Location = new System.Drawing.Point(204, 72);
            this.lblDataParaDevolucao1.Name = "lblDataParaDevolucao1";
            this.lblDataParaDevolucao1.Size = new System.Drawing.Size(110, 13);
            this.lblDataParaDevolucao1.TabIndex = 3;
            this.lblDataParaDevolucao1.Text = "Data para devolução:";
            // 
            // txtDataAluguel1
            // 
            this.txtDataAluguel1.Enabled = false;
            this.txtDataAluguel1.Location = new System.Drawing.Point(92, 69);
            this.txtDataAluguel1.Name = "txtDataAluguel1";
            this.txtDataAluguel1.Size = new System.Drawing.Size(92, 20);
            this.txtDataAluguel1.TabIndex = 6;
            // 
            // txtNomeLivro1
            // 
            this.txtNomeLivro1.Enabled = false;
            this.txtNomeLivro1.Location = new System.Drawing.Point(92, 43);
            this.txtNomeLivro1.Name = "txtNomeLivro1";
            this.txtNomeLivro1.Size = new System.Drawing.Size(315, 20);
            this.txtNomeLivro1.TabIndex = 5;
            // 
            // lblDiaDoAluguel1
            // 
            this.lblDiaDoAluguel1.AutoSize = true;
            this.lblDiaDoAluguel1.Location = new System.Drawing.Point(8, 72);
            this.lblDiaDoAluguel1.Name = "lblDiaDoAluguel1";
            this.lblDiaDoAluguel1.Size = new System.Drawing.Size(78, 13);
            this.lblDiaDoAluguel1.TabIndex = 2;
            this.lblDiaDoAluguel1.Text = "Dia do aluguel:";
            // 
            // txtCodLivro1
            // 
            this.txtCodLivro1.Enabled = false;
            this.txtCodLivro1.Location = new System.Drawing.Point(92, 17);
            this.txtCodLivro1.Name = "txtCodLivro1";
            this.txtCodLivro1.Size = new System.Drawing.Size(92, 20);
            this.txtCodLivro1.TabIndex = 4;
            // 
            // lblCodLivro1
            // 
            this.lblCodLivro1.AutoSize = true;
            this.lblCodLivro1.Location = new System.Drawing.Point(17, 20);
            this.lblCodLivro1.Name = "lblCodLivro1";
            this.lblCodLivro1.Size = new System.Drawing.Size(69, 13);
            this.lblCodLivro1.TabIndex = 0;
            this.lblCodLivro1.Text = "Cód. do livro:";
            // 
            // lblNomeLivro1
            // 
            this.lblNomeLivro1.AutoSize = true;
            this.lblNomeLivro1.Location = new System.Drawing.Point(11, 46);
            this.lblNomeLivro1.Name = "lblNomeLivro1";
            this.lblNomeLivro1.Size = new System.Drawing.Size(75, 13);
            this.lblNomeLivro1.TabIndex = 1;
            this.lblNomeLivro1.Text = "Nome do livro:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDevolver2);
            this.groupBox2.Controls.Add(this.txtDataDevolucao2);
            this.groupBox2.Controls.Add(this.lblDataParaDevolucao2);
            this.groupBox2.Controls.Add(this.txtDataAluguel2);
            this.groupBox2.Controls.Add(this.txtNomeLivro2);
            this.groupBox2.Controls.Add(this.lblDiaDoAluguel2);
            this.groupBox2.Controls.Add(this.txtCodLivro2);
            this.groupBox2.Controls.Add(this.lblCodLivro2);
            this.groupBox2.Controls.Add(this.lblNomeLivro2);
            this.groupBox2.Location = new System.Drawing.Point(15, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 103);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // btnDevolver2
            // 
            this.btnDevolver2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDevolver2.Enabled = false;
            this.btnDevolver2.Location = new System.Drawing.Point(318, 16);
            this.btnDevolver2.Name = "btnDevolver2";
            this.btnDevolver2.Size = new System.Drawing.Size(87, 20);
            this.btnDevolver2.TabIndex = 9;
            this.btnDevolver2.Text = "Devolver";
            this.btnDevolver2.UseVisualStyleBackColor = false;
            this.btnDevolver2.Click += new System.EventHandler(this.btnDevolver2_Click);
            // 
            // txtDataDevolucao2
            // 
            this.txtDataDevolucao2.Enabled = false;
            this.txtDataDevolucao2.Location = new System.Drawing.Point(318, 72);
            this.txtDataDevolucao2.Name = "txtDataDevolucao2";
            this.txtDataDevolucao2.Size = new System.Drawing.Size(87, 20);
            this.txtDataDevolucao2.TabIndex = 7;
            this.txtDataDevolucao2.Visible = false;
            // 
            // lblDataParaDevolucao2
            // 
            this.lblDataParaDevolucao2.AutoSize = true;
            this.lblDataParaDevolucao2.Location = new System.Drawing.Point(202, 75);
            this.lblDataParaDevolucao2.Name = "lblDataParaDevolucao2";
            this.lblDataParaDevolucao2.Size = new System.Drawing.Size(110, 13);
            this.lblDataParaDevolucao2.TabIndex = 3;
            this.lblDataParaDevolucao2.Text = "Data para devolução:";
            this.lblDataParaDevolucao2.Visible = false;
            // 
            // txtDataAluguel2
            // 
            this.txtDataAluguel2.Enabled = false;
            this.txtDataAluguel2.Location = new System.Drawing.Point(90, 69);
            this.txtDataAluguel2.Name = "txtDataAluguel2";
            this.txtDataAluguel2.Size = new System.Drawing.Size(92, 20);
            this.txtDataAluguel2.TabIndex = 6;
            this.txtDataAluguel2.Visible = false;
            // 
            // txtNomeLivro2
            // 
            this.txtNomeLivro2.Enabled = false;
            this.txtNomeLivro2.Location = new System.Drawing.Point(90, 43);
            this.txtNomeLivro2.Name = "txtNomeLivro2";
            this.txtNomeLivro2.Size = new System.Drawing.Size(315, 20);
            this.txtNomeLivro2.TabIndex = 5;
            this.txtNomeLivro2.Visible = false;
            // 
            // lblDiaDoAluguel2
            // 
            this.lblDiaDoAluguel2.AutoSize = true;
            this.lblDiaDoAluguel2.Location = new System.Drawing.Point(6, 72);
            this.lblDiaDoAluguel2.Name = "lblDiaDoAluguel2";
            this.lblDiaDoAluguel2.Size = new System.Drawing.Size(78, 13);
            this.lblDiaDoAluguel2.TabIndex = 2;
            this.lblDiaDoAluguel2.Text = "Dia do aluguel:";
            this.lblDiaDoAluguel2.Visible = false;
            // 
            // txtCodLivro2
            // 
            this.txtCodLivro2.Enabled = false;
            this.txtCodLivro2.Location = new System.Drawing.Point(90, 17);
            this.txtCodLivro2.Name = "txtCodLivro2";
            this.txtCodLivro2.Size = new System.Drawing.Size(92, 20);
            this.txtCodLivro2.TabIndex = 4;
            this.txtCodLivro2.Visible = false;
            // 
            // lblCodLivro2
            // 
            this.lblCodLivro2.AutoSize = true;
            this.lblCodLivro2.Location = new System.Drawing.Point(15, 20);
            this.lblCodLivro2.Name = "lblCodLivro2";
            this.lblCodLivro2.Size = new System.Drawing.Size(69, 13);
            this.lblCodLivro2.TabIndex = 0;
            this.lblCodLivro2.Text = "Cód. do livro:";
            this.lblCodLivro2.Visible = false;
            // 
            // lblNomeLivro2
            // 
            this.lblNomeLivro2.AutoSize = true;
            this.lblNomeLivro2.Location = new System.Drawing.Point(9, 46);
            this.lblNomeLivro2.Name = "lblNomeLivro2";
            this.lblNomeLivro2.Size = new System.Drawing.Size(75, 13);
            this.lblNomeLivro2.TabIndex = 1;
            this.lblNomeLivro2.Text = "Nome do livro:";
            this.lblNomeLivro2.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Maroon;
            this.btnSair.Image = global::LibraryFatec.Properties.Resources.log_out;
            this.btnSair.Location = new System.Drawing.Point(3, 390);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 38);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(136, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 29);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Devolver Livro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dados do Livro";
            // 
            // frmDevolver
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 432);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtQtdLivrosCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDevolver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolver";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbLivro;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdLivrosCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtCodigo;
        private System.Windows.Forms.TextBox txtDataDevolucao1;
        private System.Windows.Forms.Label lblDataParaDevolucao1;
        private System.Windows.Forms.TextBox txtDataAluguel1;
        private System.Windows.Forms.TextBox txtNomeLivro1;
        private System.Windows.Forms.Label lblDiaDoAluguel1;
        private System.Windows.Forms.TextBox txtCodLivro1;
        private System.Windows.Forms.Label lblCodLivro1;
        private System.Windows.Forms.Label lblNomeLivro1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDataDevolucao2;
        private System.Windows.Forms.Label lblDataParaDevolucao2;
        private System.Windows.Forms.TextBox txtDataAluguel2;
        private System.Windows.Forms.TextBox txtNomeLivro2;
        private System.Windows.Forms.Label lblDiaDoAluguel2;
        private System.Windows.Forms.TextBox txtCodLivro2;
        private System.Windows.Forms.Label lblCodLivro2;
        private System.Windows.Forms.Label lblNomeLivro2;
        private System.Windows.Forms.Button btnDevolver1;
        private System.Windows.Forms.Button btnDevolver2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label4;
    }
}