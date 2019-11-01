namespace LibraryFatec
{
    partial class frmReservar
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
            this.btnSair = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLivroEmAluguel = new System.Windows.Forms.Label();
            this.lblQtdDisponivel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbCodTituloLivro = new System.Windows.Forms.RadioButton();
            this.rdbCodLivro = new System.Windows.Forms.RadioButton();
            this.txtCodigoTitulo = new System.Windows.Forms.NumericUpDown();
            this.lblQtdD = new System.Windows.Forms.Label();
            this.btnPesquisarLivro = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.NumericUpDown();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblQtdLivrosAlugados = new System.Windows.Forms.Label();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.NumericUpDown();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDiasAluguel = new System.Windows.Forms.Label();
            this.comDiasAluguel = new System.Windows.Forms.ComboBox();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(14, 104);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 9;
            this.lblAutor.Text = "Autor:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(6, 130);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(43, 13);
            this.lblEditora.TabIndex = 10;
            this.lblEditora.Text = "Editora:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLivroEmAluguel);
            this.groupBox1.Controls.Add(this.lblQtdDisponivel);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtCodigoTitulo);
            this.groupBox1.Controls.Add(this.lblQtdD);
            this.groupBox1.Controls.Add(this.btnPesquisarLivro);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtQtd);
            this.groupBox1.Controls.Add(this.txtEditora);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblQtd);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblEditora);
            this.groupBox1.Controls.Add(this.lblAutor);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 190);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livro";
            // 
            // lblLivroEmAluguel
            // 
            this.lblLivroEmAluguel.AutoSize = true;
            this.lblLivroEmAluguel.Location = new System.Drawing.Point(229, 31);
            this.lblLivroEmAluguel.Name = "lblLivroEmAluguel";
            this.lblLivroEmAluguel.Size = new System.Drawing.Size(0, 13);
            this.lblLivroEmAluguel.TabIndex = 26;
            // 
            // lblQtdDisponivel
            // 
            this.lblQtdDisponivel.AutoSize = true;
            this.lblQtdDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdDisponivel.Location = new System.Drawing.Point(347, 153);
            this.lblQtdDisponivel.Name = "lblQtdDisponivel";
            this.lblQtdDisponivel.Size = new System.Drawing.Size(0, 18);
            this.lblQtdDisponivel.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbCodTituloLivro);
            this.panel1.Controls.Add(this.rdbCodLivro);
            this.panel1.Location = new System.Drawing.Point(54, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 50);
            this.panel1.TabIndex = 19;
            // 
            // rdbCodTituloLivro
            // 
            this.rdbCodTituloLivro.AutoSize = true;
            this.rdbCodTituloLivro.Location = new System.Drawing.Point(3, 29);
            this.rdbCodTituloLivro.Name = "rdbCodTituloLivro";
            this.rdbCodTituloLivro.Size = new System.Drawing.Size(74, 17);
            this.rdbCodTituloLivro.TabIndex = 1;
            this.rdbCodTituloLivro.Text = "Cód. título";
            this.rdbCodTituloLivro.UseVisualStyleBackColor = true;
            this.rdbCodTituloLivro.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbCodLivro
            // 
            this.rdbCodLivro.AutoSize = true;
            this.rdbCodLivro.Checked = true;
            this.rdbCodLivro.Location = new System.Drawing.Point(3, 6);
            this.rdbCodLivro.Name = "rdbCodLivro";
            this.rdbCodLivro.Size = new System.Drawing.Size(69, 17);
            this.rdbCodLivro.TabIndex = 0;
            this.rdbCodLivro.TabStop = true;
            this.rdbCodLivro.Text = "Cód. livro";
            this.rdbCodLivro.UseVisualStyleBackColor = true;
            this.rdbCodLivro.CheckedChanged += new System.EventHandler(this.rdbCodLivro_CheckedChanged);
            // 
            // txtCodigoTitulo
            // 
            this.txtCodigoTitulo.Enabled = false;
            this.txtCodigoTitulo.Location = new System.Drawing.Point(137, 48);
            this.txtCodigoTitulo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtCodigoTitulo.Name = "txtCodigoTitulo";
            this.txtCodigoTitulo.Size = new System.Drawing.Size(85, 20);
            this.txtCodigoTitulo.TabIndex = 24;
            // 
            // lblQtdD
            // 
            this.lblQtdD.AutoSize = true;
            this.lblQtdD.Location = new System.Drawing.Point(259, 156);
            this.lblQtdD.Name = "lblQtdD";
            this.lblQtdD.Size = new System.Drawing.Size(82, 13);
            this.lblQtdD.TabIndex = 19;
            this.lblQtdD.Text = "Qtd. disponível:";
            // 
            // btnPesquisarLivro
            // 
            this.btnPesquisarLivro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarLivro.Location = new System.Drawing.Point(323, 25);
            this.btnPesquisarLivro.Name = "btnPesquisarLivro";
            this.btnPesquisarLivro.Size = new System.Drawing.Size(75, 44);
            this.btnPesquisarLivro.TabIndex = 18;
            this.btnPesquisarLivro.Text = "Pesquisar";
            this.btnPesquisarLivro.UseVisualStyleBackColor = false;
            this.btnPesquisarLivro.Click += new System.EventHandler(this.btnPesquisarLivro_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(137, 25);
            this.txtCodigo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(85, 20);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtQtd
            // 
            this.txtQtd.Enabled = false;
            this.txtQtd.Location = new System.Drawing.Point(54, 153);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(73, 20);
            this.txtQtd.TabIndex = 16;
            // 
            // txtEditora
            // 
            this.txtEditora.Enabled = false;
            this.txtEditora.Location = new System.Drawing.Point(54, 127);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(344, 20);
            this.txtEditora.TabIndex = 15;
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Location = new System.Drawing.Point(54, 101);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(344, 20);
            this.txtAutor.TabIndex = 14;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(19, 156);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(30, 13);
            this.lblQtd.TabIndex = 11;
            this.lblQtd.Text = "Qtd.:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(54, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(344, 20);
            this.txtNome.TabIndex = 13;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(119, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(194, 29);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Reserva de Livro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblQtdLivrosAlugados);
            this.groupBox2.Controls.Add(this.btnPesquisarCliente);
            this.groupBox2.Controls.Add(this.txtCodigoCliente);
            this.groupBox2.Controls.Add(this.txtNomeCliente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 111);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // lblQtdLivrosAlugados
            // 
            this.lblQtdLivrosAlugados.AutoSize = true;
            this.lblQtdLivrosAlugados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdLivrosAlugados.Location = new System.Drawing.Point(127, 77);
            this.lblQtdLivrosAlugados.Name = "lblQtdLivrosAlugados";
            this.lblQtdLivrosAlugados.Size = new System.Drawing.Size(0, 18);
            this.lblQtdLivrosAlugados.TabIndex = 26;
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarCliente.Enabled = false;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(323, 22);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarCliente.TabIndex = 18;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Enabled = false;
            this.txtCodigoCliente.Location = new System.Drawing.Point(122, 25);
            this.txtCodigoCliente.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(90, 20);
            this.txtCodigoCliente.TabIndex = 17;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(122, 51);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(276, 20);
            this.txtNomeCliente.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Qtd. livros em aluguel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Código:";
            // 
            // lblDiasAluguel
            // 
            this.lblDiasAluguel.AutoSize = true;
            this.lblDiasAluguel.Location = new System.Drawing.Point(193, 367);
            this.lblDiasAluguel.Name = "lblDiasAluguel";
            this.lblDiasAluguel.Size = new System.Drawing.Size(92, 13);
            this.lblDiasAluguel.TabIndex = 14;
            this.lblDiasAluguel.Text = "Qtd.: dias aluguel:";
            this.lblDiasAluguel.Visible = false;
            // 
            // comDiasAluguel
            // 
            this.comDiasAluguel.FormattingEnabled = true;
            this.comDiasAluguel.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.comDiasAluguel.Location = new System.Drawing.Point(291, 364);
            this.comDiasAluguel.Name = "comDiasAluguel";
            this.comDiasAluguel.Size = new System.Drawing.Size(57, 21);
            this.comDiasAluguel.TabIndex = 15;
            this.comDiasAluguel.Visible = false;
            // 
            // btnAlugar
            // 
            this.btnAlugar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlugar.Location = new System.Drawing.Point(354, 362);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(75, 23);
            this.btnAlugar.TabIndex = 16;
            this.btnAlugar.Text = "Alugar";
            this.btnAlugar.UseVisualStyleBackColor = false;
            this.btnAlugar.Visible = false;
            this.btnAlugar.Click += new System.EventHandler(this.btnAlugar_Click);
            // 
            // frmReservar
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 432);
            this.Controls.Add(this.btnAlugar);
            this.Controls.Add(this.comDiasAluguel);
            this.Controls.Add(this.lblDiasAluguel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.NumericUpDown txtCodigo;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnPesquisarLivro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblQtdD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.NumericUpDown txtCodigoCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbCodTituloLivro;
        private System.Windows.Forms.RadioButton rdbCodLivro;
        private System.Windows.Forms.NumericUpDown txtCodigoTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQtdDisponivel;
        private System.Windows.Forms.Label lblQtdLivrosAlugados;
        private System.Windows.Forms.Label lblDiasAluguel;
        private System.Windows.Forms.ComboBox comDiasAluguel;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.Label lblLivroEmAluguel;
    }
}