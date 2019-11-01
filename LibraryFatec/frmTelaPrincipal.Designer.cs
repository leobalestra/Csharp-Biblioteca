namespace LibraryFatec
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDevolverLivro = new System.Windows.Forms.Button();
            this.btnEditarLivro = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnCadastrarProfissional = new System.Windows.Forms.Button();
            this.lblUsuarioConectado = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnReservarLivro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDevolverLivro
            // 
            this.btnDevolverLivro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDevolverLivro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDevolverLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolverLivro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDevolverLivro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnDevolverLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolverLivro.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverLivro.Image = global::LibraryFatec.Properties.Resources.icons8_devolver_o_livro_512__1_;
            this.btnDevolverLivro.Location = new System.Drawing.Point(223, 3);
            this.btnDevolverLivro.Name = "btnDevolverLivro";
            this.btnDevolverLivro.Size = new System.Drawing.Size(214, 123);
            this.btnDevolverLivro.TabIndex = 1;
            this.btnDevolverLivro.Text = "Devolver Livro";
            this.btnDevolverLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDevolverLivro.UseVisualStyleBackColor = false;
            this.btnDevolverLivro.Click += new System.EventHandler(this.btnDevolverLivro_Click);
            // 
            // btnEditarLivro
            // 
            this.btnEditarLivro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnEditarLivro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarLivro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditarLivro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnEditarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLivro.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarLivro.Image = global::LibraryFatec.Properties.Resources.icons8_livro_100__1_;
            this.btnEditarLivro.Location = new System.Drawing.Point(223, 132);
            this.btnEditarLivro.Name = "btnEditarLivro";
            this.btnEditarLivro.Size = new System.Drawing.Size(214, 126);
            this.btnEditarLivro.TabIndex = 3;
            this.btnEditarLivro.Text = "Editar Livro";
            this.btnEditarLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarLivro.UseVisualStyleBackColor = false;
            this.btnEditarLivro.Click += new System.EventHandler(this.btnEditarLivro_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCadastrarCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCadastrarCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Image = global::LibraryFatec.Properties.Resources.icons8_leitura_80;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(3, 132);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(214, 126);
            this.btnCadastrarCliente.TabIndex = 2;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRelatorios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRelatorios.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Image = global::LibraryFatec.Properties.Resources.icons8_apresentação_96__1_;
            this.btnRelatorios.Location = new System.Drawing.Point(223, 264);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(214, 123);
            this.btnRelatorios.TabIndex = 5;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnCadastrarProfissional
            // 
            this.btnCadastrarProfissional.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCadastrarProfissional.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarProfissional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarProfissional.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCadastrarProfissional.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnCadastrarProfissional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProfissional.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProfissional.Image = global::LibraryFatec.Properties.Resources.icons8_leitura_80__1_;
            this.btnCadastrarProfissional.Location = new System.Drawing.Point(3, 264);
            this.btnCadastrarProfissional.Name = "btnCadastrarProfissional";
            this.btnCadastrarProfissional.Size = new System.Drawing.Size(214, 123);
            this.btnCadastrarProfissional.TabIndex = 4;
            this.btnCadastrarProfissional.Text = "Cadastrar Profissional";
            this.btnCadastrarProfissional.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarProfissional.UseVisualStyleBackColor = false;
            this.btnCadastrarProfissional.Click += new System.EventHandler(this.btnCadastrarProfissional_Click);
            // 
            // lblUsuarioConectado
            // 
            this.lblUsuarioConectado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioConectado.AutoSize = true;
            this.lblUsuarioConectado.Location = new System.Drawing.Point(223, 404);
            this.lblUsuarioConectado.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblUsuarioConectado.Name = "lblUsuarioConectado";
            this.lblUsuarioConectado.Size = new System.Drawing.Size(61, 13);
            this.lblUsuarioConectado.TabIndex = 7;
            this.lblUsuarioConectado.Text = "alaolaoalao";
            this.lblUsuarioConectado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // btnReservarLivro
            // 
            this.btnReservarLivro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnReservarLivro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReservarLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservarLivro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReservarLivro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnReservarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservarLivro.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservarLivro.Image = global::LibraryFatec.Properties.Resources.icons8_adicionar_bilhete_80;
            this.btnReservarLivro.Location = new System.Drawing.Point(3, 3);
            this.btnReservarLivro.Name = "btnReservarLivro";
            this.btnReservarLivro.Size = new System.Drawing.Size(214, 123);
            this.btnReservarLivro.TabIndex = 0;
            this.btnReservarLivro.Text = "Reservar Livro";
            this.btnReservarLivro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReservarLivro.UseVisualStyleBackColor = false;
            this.btnReservarLivro.Click += new System.EventHandler(this.btnReservarLivro_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 432);
            this.Controls.Add(this.lblUsuarioConectado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnCadastrarProfissional);
            this.Controls.Add(this.btnEditarLivro);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnDevolverLivro);
            this.Controls.Add(this.btnReservarLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReservarLivro;
        private System.Windows.Forms.Button btnDevolverLivro;
        private System.Windows.Forms.Button btnEditarLivro;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnCadastrarProfissional;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblUsuarioConectado;
    }
}

