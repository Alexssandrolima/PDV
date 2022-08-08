namespace CasaMendes.Vistas
{
    partial class frmCad_ClienteViews
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
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.mkbCep = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Blue;
            this.lblBairro.Location = new System.Drawing.Point(12, 117);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBairro.Size = new System.Drawing.Size(43, 15);
            this.lblBairro.TabIndex = 283;
            this.lblBairro.Text = "Bairro:";
            this.lblBairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNome
            // 
            this.txtNome.AcceptsReturn = true;
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNome.Location = new System.Drawing.Point(138, 26);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.Size = new System.Drawing.Size(357, 27);
            this.txtNome.TabIndex = 291;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 290;
            this.label5.Text = "Código::";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.Blue;
            this.lblEndereco.Location = new System.Drawing.Point(12, 60);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndereco.Size = new System.Drawing.Size(63, 15);
            this.lblEndereco.TabIndex = 278;
            this.lblEndereco.Text = "Endereco:";
            this.lblEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEndereco
            // 
            this.txtEndereco.AcceptsReturn = true;
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEndereco.Location = new System.Drawing.Point(15, 77);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEndereco.Size = new System.Drawing.Size(198, 27);
            this.txtEndereco.TabIndex = 256;
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cbEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbEstado.Location = new System.Drawing.Point(227, 134);
            this.cbEstado.MaxLength = 30;
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbEstado.Size = new System.Drawing.Size(45, 28);
            this.cbEstado.TabIndex = 262;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Blue;
            this.lblEstado.Location = new System.Drawing.Point(224, 116);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstado.Size = new System.Drawing.Size(48, 15);
            this.lblEstado.TabIndex = 281;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Blue;
            this.lblNome.Location = new System.Drawing.Point(136, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 275;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mkbCep
            // 
            this.mkbCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbCep.Location = new System.Drawing.Point(230, 76);
            this.mkbCep.Mask = "#####-###";
            this.mkbCep.Name = "mkbCep";
            this.mkbCep.Size = new System.Drawing.Size(88, 27);
            this.mkbCep.TabIndex = 258;
            this.mkbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // txtCidade
            // 
            this.txtCidade.AcceptsReturn = true;
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCidade.Location = new System.Drawing.Point(332, 76);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCidade.Size = new System.Drawing.Size(163, 27);
            this.txtCidade.TabIndex = 259;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.Blue;
            this.lblCidade.Location = new System.Drawing.Point(329, 58);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCidade.Size = new System.Drawing.Size(49, 15);
            this.lblCidade.TabIndex = 280;
            this.lblCidade.Text = "Cidade:";
            this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBairro
            // 
            this.txtBairro.AcceptsReturn = true;
            this.txtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBairro.Location = new System.Drawing.Point(15, 135);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBairro.Size = new System.Drawing.Size(198, 27);
            this.txtBairro.TabIndex = 261;
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.CustomFormat = "##/##/####";
            this.dtpDataDeNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(391, 135);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(104, 27);
            this.dtpDataDeNascimento.TabIndex = 265;
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.ForeColor = System.Drawing.Color.Blue;
            this.lblDataCadastro.Location = new System.Drawing.Point(389, 117);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDataCadastro.Size = new System.Drawing.Size(106, 15);
            this.lblDataCadastro.TabIndex = 272;
            this.lblDataCadastro.Text = "D. de nascimento:";
            this.lblDataCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 305;
            this.label1.Text = "Cliente:";
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAtualizar.FlatAppearance.BorderSize = 0;
            this.BtnAtualizar.ForeColor = System.Drawing.Color.Blue;
            this.BtnAtualizar.Location = new System.Drawing.Point(114, 384);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(76, 46);
            this.BtnAtualizar.TabIndex = 309;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblEndereco);
            this.panel1.Controls.Add(this.txtEndereco);
            this.panel1.Controls.Add(this.mkbCep);
            this.panel1.Controls.Add(this.lblCep);
            this.panel1.Controls.Add(this.txtCidade);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.cbPais);
            this.panel1.Controls.Add(this.lblCidade);
            this.panel1.Controls.Add(this.lblPais);
            this.panel1.Controls.Add(this.lblBairro);
            this.panel1.Controls.Add(this.txtBairro);
            this.panel1.Controls.Add(this.dtpDataDeNascimento);
            this.panel1.Controls.Add(this.lblDataCadastro);
            this.panel1.Location = new System.Drawing.Point(9, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 179);
            this.panel1.TabIndex = 310;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.Color.Transparent;
            this.lblCep.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.ForeColor = System.Drawing.Color.Blue;
            this.lblCep.Location = new System.Drawing.Point(227, 58);
            this.lblCep.Name = "lblCep";
            this.lblCep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCep.Size = new System.Drawing.Size(40, 15);
            this.lblCep.TabIndex = 279;
            this.lblCep.Text = "C.E.P:";
            this.lblCep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.AcceptsReturn = true;
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodigo.Location = new System.Drawing.Point(15, 26);
            this.txtCodigo.MaxLength = 0;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigo.Size = new System.Drawing.Size(105, 27);
            this.txtCodigo.TabIndex = 270;
            this.txtCodigo.Text = "3";
            // 
            // cbPais
            // 
            this.cbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(289, 134);
            this.cbPais.MaxLength = 30;
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(88, 28);
            this.cbPais.TabIndex = 289;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.BackColor = System.Drawing.Color.Transparent;
            this.lblPais.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.Color.Blue;
            this.lblPais.Location = new System.Drawing.Point(286, 116);
            this.lblPais.Name = "lblPais";
            this.lblPais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPais.Size = new System.Drawing.Size(34, 15);
            this.lblPais.TabIndex = 282;
            this.lblPais.Text = "País:";
            this.lblPais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.ForeColor = System.Drawing.Color.Blue;
            this.btnFechar.Location = new System.Drawing.Point(440, 386);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(76, 46);
            this.btnFechar.TabIndex = 307;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.ForeColor = System.Drawing.Color.Blue;
            this.BtnCancelar.Location = new System.Drawing.Point(9, 386);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(76, 46);
            this.BtnCancelar.TabIndex = 308;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.ForeColor = System.Drawing.Color.Blue;
            this.BtnExcluir.Location = new System.Drawing.Point(220, 386);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(76, 46);
            this.BtnExcluir.TabIndex = 311;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNovo.FlatAppearance.BorderSize = 0;
            this.BtnNovo.ForeColor = System.Drawing.Color.Blue;
            this.BtnNovo.Location = new System.Drawing.Point(9, 386);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(76, 46);
            this.BtnNovo.TabIndex = 313;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.ForeColor = System.Drawing.Color.Blue;
            this.BtnSalvar.Location = new System.Drawing.Point(114, 384);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(76, 46);
            this.BtnSalvar.TabIndex = 314;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // DgvClientes
            // 
            this.DgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(9, 202);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(507, 176);
            this.DgvClientes.TabIndex = 315;
            // 
            // frmCad_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 442);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCad_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCad_Cliente";
            this.Load += new System.EventHandler(this.frmCad_Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblEndereco;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.ComboBox cbEstado;
        public System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.Label lblNome;
        internal System.Windows.Forms.MaskedTextBox mkbCep;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.Label lblCidade;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
        public System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblCep;
        public System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.ComboBox cbPais;
        public System.Windows.Forms.Label lblPais;
        internal System.Windows.Forms.Button btnFechar;
        internal System.Windows.Forms.Button BtnCancelar;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnNovo;
        internal System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.DataGridView DgvClientes;
    }
}