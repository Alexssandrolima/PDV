using CasaMendes.Classes;
using CasaMendes.Classes.Estatica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class frmCadastrarFuncionarios : Form//, IDisposable
    {
        //private FuncionarioControls oFuncionario;

        //string TestoDoBtnNovo = clsMensagens.M00039;  //"Novo";

        public frmCadastrarFuncionarios()
        {
            InitializeComponent();
            //    //this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmCadastrarFuncionarios_Paint);
            //    //this.Move += new System.EventHandler(this.frmCadastrarFuncionarios_Move);
            //    //this.Resize += new System.EventHandler(this.frmCadastrarFuncionarios_Resize);
            //    //this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);

            //    this.Text = clsGlobal.MontarTitulo(clsMensagens.M00041);
            //    oFuncionario = new FuncionarioControls();
            //    this.btnCancelar.Visible = false;
            //    this.btnNovo.Text = TestoDoBtnNovo;
            //    this.PicFoto.Image = Properties.Resources.CasaMendes1Jpg;
        }

        //private void AtribuirValores()
        //{
        //    if (!this.txtCodigo.Text.Equals(""))
        //    {
        //        this.oFuncionario.Codigo = Convert.ToInt16(this.txtCodigo.Text);
        //    }
        //    //string s;
        //    if (this.mkbCep.Text.Equals("_____-___")) { this.oFuncionario.Cep = 0; } else { this.oFuncionario.Cep = Convert.ToDecimal(this.mkbCep.Text.Replace("_", "").Replace("-", "").Replace(" ", "")); }
        //    if (this.mkbCelular.Text.Equals("(  )     -")) { this.oFuncionario.Celular = 0; } else { this.oFuncionario.Celular = Convert.ToDecimal(this.mkbCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")); }
        //    if (this.mkbTelefone.Text.Equals("(  )    -")) { this.oFuncionario.Telefone = 0; } else { this.oFuncionario.Telefone = Convert.ToDecimal(this.mkbTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")); }
        //    if (this.mkbCelularContato.Text.Equals("(  )     -")) { this.oFuncionario.CelularContato = 0; } else { this.oFuncionario.CelularContato = Convert.ToDecimal(this.mkbCelularContato.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")); }
        //    if (this.mkbRg.Text.Equals("__,___,___-_")) { this.oFuncionario.Rg = 0; } else { this.oFuncionario.Rg = Convert.ToDecimal(this.mkbRg.Text.Replace("_", "").Replace("-", "").Replace(",", "").Replace(" ", "")); }
        //    if (this.mkbCpf.Text.Equals("   ,   ,   -")) { this.oFuncionario.Cpf = 0; } else { this.oFuncionario.Cpf = Convert.ToDecimal(mkbCpf.Text.Replace("-", "").Replace(",", "").Replace(" ", "")); }

        //    this.oFuncionario.Nome = this.txtNome.Text.ToUpper();
        //    this.oFuncionario.Endereco = this.txtEndereco.Text.ToUpper();
        //    this.oFuncionario.Cidade = this.txtCidade.Text.ToUpper();
        //    this.oFuncionario.Bairro = this.txtBairro.Text.ToUpper();
        //    this.oFuncionario.Estado = this.cbEstado.Text.ToUpper();
        //    this.oFuncionario.Pais = this.cbPais.Text.ToUpper();
        //    this.oFuncionario.EstadoCivil = this.cbEstadoCivil.Text.ToUpper();

        //    if (TestoDoBtnNovo == clsMensagens.M00028) { this.oFuncionario.DataCadastro = DateTime.Now; }

        //    this.oFuncionario.DataDeNascimento = this.dtpDataDeNascimento.Value;

        //    this.oFuncionario.Observacao = this.txtObservacao.Text.ToUpper();
        //    this.oFuncionario.Foto = null;

        //    if (this.PicFoto.Image == null)
        //    {
        //        this.PicFoto.Image = Properties.Resources.CasaMendes1Jpg;
        //    }

        //    this.oFuncionario.Foto = this.PicFoto.Image;
        //}

        //private void AtualizarControles(bool status)
        //{
        //    this.btnCancelar.Visible = !status;
        //    this.btnExcluir.Enabled = status;
        //    btnFechar.Enabled = status;
        //}

        //[STAThread]
        private void btnBusca_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        string sNome = this.txtNome.Text;
            //        clsGlobal.LimparControles((ControlCollection)this.Controls);
            //        this.oFuncionario.Buscar((string)sNome);
            //        if (this.oFuncionario.Codigo > 0)
            //        {
            //            this.ExibirDados();
            //        }
            //    }
            //    catch { }
        }

        private void frmCadastroDeFuncionarios_Load(object sender, EventArgs e)
        {
            //    try
            //    {
            //        oFuncionario.CarregarDataGridFuncionarios(dgvNomes);
            //        dgvNomes.ColumnHeadersVisible = false;
            //        dgvNomes.RowHeadersVisible = false;
            //        int tamanho = dgvNomes.Width - 24;
            //        dgvNomes.Columns[0].Width = tamanho;
            //        dgvNomes.BackgroundColor = Color.White;
            //        dgvNomes.AllowUserToAddRows = false;

            //        clsGlobal.CarregarPaises(this.cbPais);
            //        clsGlobal.CarregarEstados(this.cbEstado);
            //        this.txtNome.Focus();
            //    }
            //    catch
            //    {

            //    }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //    if (this.TestoDoBtnNovo == clsMensagens.M00026)//"Novo"
            //    {
            //        Image img = Properties.Resources.CasaMendes1Jpg;
            //        this.oFuncionario.Foto = img;
            //        this.PicFoto.Image = img;
            //        this.TestoDoBtnNovo = clsMensagens.M00028;// "Gravar";
            //        this.btnNovo.Text = this.TestoDoBtnNovo;
            //        this.AtualizarControles(false);

            //        clsGlobal.LimparControles((ControlCollection)this.Controls);
            //        clsGlobal.CarregarEstados(this.cbEstado);
            //        this.PicFoto.Visible = false;
            //        this.txtNome.Focus();
            //    }
            //    else
            //    {

            //        this.AtribuirValores();
            //        oFuncionario.Novo();
            //        this.TestoDoBtnNovo = clsMensagens.M00026;// "Novo";
            //        this.btnNovo.Text = this.TestoDoBtnNovo;
            //        this.AtualizarControles(true);
            //        clsGlobal.LimparControles((ControlCollection)this.Controls);
            //        clsGlobal.CarregarEstados(this.cbEstado);
            //        this.PicFoto.Visible = true;
            //        oFuncionario.CarregarDataGridFuncionarios(dgvNomes);
            //    }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //    TestoDoBtnNovo = clsMensagens.M00026;// "Novo";
            //    this.btnNovo.Text = TestoDoBtnNovo;
            //    clsGlobal.LimparControles((ControlCollection)this.Controls);
            //    this.AtualizarControles(true);

            //    this.PicFoto.Visible = true;

            //    oFuncionario.CarregarDataGridFuncionarios(dgvNomes);

            //    if (oFuncionario.Codigo > 0) { ExibirDados(); }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //    this.AtribuirValores();
            //    oFuncionario.Atualizar();
            //    oFuncionario.CarregarDataGridFuncionarios(dgvNomes);
            //    if (oFuncionario.Codigo > 0) { ExibirDados(); }
        }

        //private void ExibirDados()
        //{
        //    try
        //    {
        //                                      this.txtCodigo.Text = oFuncionario.Codigo.ToString() != "0" ? oFuncionario.Codigo.ToString() : "";
        //                                this.txtNome.Text = oFuncionario.Nome.ToString().ToUpper() != "NULL" ? oFuncionario.Nome.ToString() : "";
        //                        this.txtEndereco.Text = oFuncionario.Endereco.ToString().ToUpper() != "NULL" ? oFuncionario.Endereco.ToString() : "";
        //                                            this.mkbCep.Text = oFuncionario.Cep.ToString() != "0" ? oFuncionario.Cep.ToString() : "";
        //                            this.txtCidade.Text = oFuncionario.Cidade.ToString().ToUpper() != "NULL" ? oFuncionario.Cidade.ToString() : "";
        //                            this.txtBairro.Text = oFuncionario.Bairro.ToString().ToUpper() != "NULL" ? oFuncionario.Bairro.ToString() : "";
        //                             this.cbEstado.Text = oFuncionario.Estado.ToString().ToUpper() != "NULL" ? oFuncionario.Estado.ToString() : "";
        //                                 this.cbPais.Text = oFuncionario.Pais.ToString().ToUpper() != "NULL" ? oFuncionario.Pais.ToString() : "";
        //                                            this.mkbCpf.Text = oFuncionario.Cpf.ToString() != "0" ? oFuncionario.Cpf.ToString() : "";
        //                                              this.mkbRg.Text = oFuncionario.Rg.ToString() != "0" ? oFuncionario.Rg.ToString() : "";
        //                   this.cbEstadoCivil.Text = oFuncionario.EstadoCivil.ToString().ToUpper() != "NULL" ? oFuncionario.EstadoCivil.ToString() : "";
        //        this.dtpDataDeNascimento.Text = oFuncionario.DataDeNascimento.ToString().ToUpper() != "NULL" ? oFuncionario.DataDeNascimento.ToString() : "";
        //                                    this.mkbCelular.Text = oFuncionario.Celular.ToString() != "0" ? oFuncionario.Celular.ToString() : "";
        //                      this.mkbCelularContato.Text = oFuncionario.CelularContato.ToString() != "0" ? oFuncionario.CelularContato.ToString() : "";
        //                                  this.mkbTelefone.Text = oFuncionario.Telefone.ToString() != "0" ? oFuncionario.Telefone.ToString() : "";
        //                    this.txtObservacao.Text = oFuncionario.Observacao.ToString().ToUpper() != "NULL" ? oFuncionario.Observacao.ToString() : "";
        //                         this.PicFoto.Image = oFuncionario.Foto;
        //    }
        //    catch { }
        //}

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //    if (this.txtCodigo.Text != null)
            //    {
            //        string nome = this.txtNome.Text;
            //        oFuncionario.Excluir(txtCodigo.Text);
            //        clsGlobal.LimparControles((ControlCollection)this.Controls);
            //        oFuncionario.CarregarDataGridFuncionarios(dgvNomes);
            //        if (oFuncionario.Codigo > 0) { ExibirDados(); }
            //    }
        }

        private void dgvNomes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //    try
            //    {
            //        int contar = dgvNomes.Rows.Count - 1;
            //        if (contar > 0)
            //        {
            //            clsGlobal.LimparControles((ControlCollection)this.Controls);
            //            oFuncionario.Buscar(dgvNomes.Rows[e.RowIndex].Cells[0].Value.ToString());
            //            if (oFuncionario.Codigo > 0) { ExibirDados(); }
            //            PicFoto.Visible = true;
            //        }
            //    }
            //    catch { }
        }

        private void lblPicFoto_Click(object sender, EventArgs e)
            {
                //    clsGlobal.Abririmagens(this.PicFoto);
            }

        }
}