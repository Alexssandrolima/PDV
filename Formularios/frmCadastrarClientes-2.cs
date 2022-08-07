
using CasaMendes.Classes.Estatica;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class frmCadastrarClientes : Form
    {

        #region Variáveis
        Enumeradores.eAcao Acao = Enumeradores.eAcao.None;
        Classes.cl_Cliente oCliente = new Classes.cl_Cliente();
        #endregion

        #region Construtor

        public frmCadastrarClientes(ArrayList arrCliente = null)
        {
            InitializeComponent();
            try
            {

                this.Text = Classes.Estatica.clsGlobal.MontarTitulo("Cadastrar Cliente");
                pnlPessoaJuridica.Width = pnlPessoaFisica.Width;
                pnlPessoaJuridica.Height = pnlPessoaFisica.Height;

                lblPessoaJuridica.Width = lblPessoaFisica.Width;
                lblPessoaJuridica.Height = lblPessoaFisica.Height;

                pnlPessoaJuridica.Location = new Point(308, 237);
                pnlPessoaFisica.Location = new Point(308, 237);
                lblPessoaFisica.Location = new Point(317, 222);
                lblPessoaJuridica.Location = new Point(317, 222);

                clsGlobal.CarregarPaises(this.cbPais);
                clsGlobal.CarregarEstados(this.cbEstado);

                if ((Convert.ToInt16(arrCliente[0].ToString())) != -1)
                {
                    Acao = Enumeradores.eAcao.Atualizar;
                    string nullo = "null".ToUpper();
                    //==================================================================================
                    this.txtCodigo.Text = arrCliente[0].ToString();            //[Codigo 
                                                                               //==================================================================================
                    if ((arrCliente[1].ToString() != "") || (arrCliente[1].ToString() != nullo)) { this.txtNome.Text = arrCliente[1].ToString(); } else { this.txtNome.Clear(); }
                    //==================================================================================
                    if ((arrCliente[2].ToString() != "") || (arrCliente[2].ToString() != nullo)) { this.txtEndereco.Text = arrCliente[2].ToString(); } else { this.txtEndereco.Clear(); }
                    //==================================================================================
                    if ((arrCliente[3].ToString() != "0") || (arrCliente[3].ToString() != nullo)) { this.mkbCep.Text = arrCliente[3].ToString(); } else { this.mkbCep.Clear(); }
                    //==================================================================================
                    if ((arrCliente[4].ToString() != "") || (arrCliente[4].ToString() != nullo)) { this.txtCidade.Text = arrCliente[4].ToString(); } else { this.txtCidade.Clear(); }
                    //==================================================================================
                    if ((arrCliente[5].ToString() != "") || (arrCliente[5].ToString() != nullo)) { this.txtBairro.Text = arrCliente[5].ToString(); } else { this.txtBairro.Clear(); }
                    //==================================================================================
                    if ((arrCliente[6].ToString() != "") || (arrCliente[6].ToString() != nullo)) { this.cbEstado.Text = arrCliente[6].ToString(); } else { this.cbEstado.Items.Clear(); }
                    //==================================================================================
                    if ((arrCliente[7].ToString() != "") || (arrCliente[7].ToString() != nullo)) { this.cbPais.Text = arrCliente[7].ToString(); } else { this.cbPais.Items.Clear(); }
                    //==================================================================================
                    this.dtpDataDeNascimento.Text = arrCliente[8].ToString();  //[DataCadastro
                                                                               //==================================================================================
                    if ((arrCliente[9].ToString() != "0") || (arrCliente[9].ToString() != nullo)) { this.mkbRg.Text = arrCliente[9].ToString(); } else { this.mkbRg.Clear(); }
                    //==================================================================================
                    if ((arrCliente[10].ToString() != "0") || (arrCliente[10].ToString() != nullo)) { this.mkbCpf.Text = arrCliente[10].ToString(); } else { this.mkbCpf.Clear(); }
                    //==================================================================================
                    if ((arrCliente[11].ToString() != "0") || (arrCliente[11].ToString() != nullo)) { this.mkbInscricaoEstadual.Text = arrCliente[11].ToString(); } else { this.mkbInscricaoEstadual.Clear(); }
                    //==================================================================================
                    if ((arrCliente[12].ToString() != "0") || (arrCliente[12].ToString() != nullo)) { this.mkbCnpj.Text = arrCliente[12].ToString(); } else { this.mkbCnpj.Clear(); }
                    //==================================================================================
                    if ((arrCliente[13].ToString() != "0") || (arrCliente[13].ToString() != nullo)) { this.mkbTelefone.Text = arrCliente[4].ToString(); } else { this.mkbTelefone.Clear(); }
                    //==================================================================================
                    if ((arrCliente[14].ToString() != "0") || (arrCliente[14].ToString() != nullo)) { this.mkbCelular.Text = arrCliente[14].ToString(); } else { this.mkbCelular.Clear(); }
                    //==================================================================================
                    if ((arrCliente[16].ToString() != "") || (arrCliente[15].ToString() != nullo.ToLower())) { this.txtEmail.Text = arrCliente[15].ToString(); } else { this.txtEmail.Clear(); }
                    //==================================================================================
                    if ((arrCliente[16].ToString() != "") || (arrCliente[16].ToString() != nullo.ToLower())) { this.txtSite.Text = arrCliente[16].ToString(); } else { this.txtSite.Clear(); }
                    //==================================================================================
                    this.cbStatus.Checked = Convert.ToBoolean(arrCliente[17].ToString());
                    //==================================================================================
                }
                else
                {
                    this.txtCodigo.Text = arrCliente[0].ToString();
                    Acao = Enumeradores.eAcao.Cadastrar;
                }

                //=================================================================================
                if (this.txtNome.Text.Length > 0) this.btnGravar.Enabled = true; else this.btnGravar.Enabled = false;

            }
            catch { }

        }

        #endregion

        #region Manutenção

        private void rbPF_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnlPessoaJuridica.Visible = false;
                lblPessoaFisica.Visible = true;
                lblPessoaJuridica.Visible = false;
                pnlPessoaFisica.Visible = true;
                lblPessoaJuridica.Width = lblPessoaFisica.Width;
                lblPessoaJuridica.Height = lblPessoaFisica.Height;
                pnlPessoaJuridica.Location = new Point(308, 237);
                pnlPessoaFisica.Location = new Point(308, 237);
                lblPessoaFisica.Location = new Point(317, 222);
                lblPessoaJuridica.Location = new Point(317, 222);
            }
            catch
            { }
        }

        private void rbPJ_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnlPessoaJuridica.Visible = false;
                lblPessoaJuridica.Visible = true;
                lblPessoaFisica.Visible = false;
                pnlPessoaFisica.Visible = false;
                pnlPessoaJuridica.Visible = true;
                lblPessoaJuridica.Width = lblPessoaFisica.Width;
                lblPessoaJuridica.Height = lblPessoaFisica.Height;
                pnlPessoaJuridica.Location = new Point(308, 237);
                pnlPessoaFisica.Location = new Point(308, 237);
                lblPessoaFisica.Location = new Point(317, 222);
                lblPessoaJuridica.Location = new Point(317, 222);
            }
            catch
            { }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList arrCliente = new ArrayList();
                string tmp = "";
                if (this.txtCodigo.Text != "") { arrCliente.Add(this.txtCodigo.Text); } else { arrCliente.Add("1"); }
                if (this.txtNome.Text != "") { arrCliente.Add(this.txtNome.Text); } else { MessageBox.Show("O nome é obrigatório, por favor informe - o!", Application.ProductName); txtNome.Focus(); txtNome.SelectAll(); return; }
                if (this.txtEndereco.Text != "") { arrCliente.Add(this.txtEndereco.Text); } else { arrCliente.Add("null"); }

                tmp = this.mkbCep.Text.Replace("_", "").Replace("-", "");
                if (tmp != "") { arrCliente.Add(tmp); } else { arrCliente.Add(0); }

                if (this.txtCidade.Text != "") { arrCliente.Add(this.txtCidade.Text); } else { arrCliente.Add("null"); }
                if (this.txtBairro.Text != "") { arrCliente.Add(this.txtBairro.Text); } else { arrCliente.Add("null"); }
                if (this.cbEstado.Text != "") { arrCliente.Add(this.cbEstado.Text); } else { arrCliente.Add("null"); }
                if (this.cbPais.Text != "") { arrCliente.Add(this.cbPais.Text); } else { arrCliente.Add("null"); }

                arrCliente.Add(this.dtpDataDeNascimento.Value.ToString("yyyy-MM-dd"));

                tmp = this.mkbRg.Text.Replace("_", "").Replace("-", "").Replace(",", "").Trim();
                if (tmp != "") { arrCliente.Add(tmp); } else { arrCliente.Add(0); }

                tmp = this.mkbCpf.Text.Replace("_", "").Replace("-", "").Replace(",", "").Trim();
                if (tmp != "") { arrCliente.Add(tmp); } else { arrCliente.Add(0); }

                tmp = this.mkbInscricaoEstadual.Text.Replace("_", "").Replace("-", "").Replace(",", "").Trim();
                if (tmp != "") { arrCliente.Add(tmp); } else { arrCliente.Add(0); }

                tmp = this.mkbCnpj.Text.Replace("_", "").Replace("-", "").Replace(",", "").Trim();
                if (tmp != "") { arrCliente.Add(tmp); } else { arrCliente.Add(0); }

                tmp = this.mkbTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();
                if (tmp != "") { arrCliente.Add(tmp); } else { arrCliente.Add(0); }

                tmp = this.mkbCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();
                if (tmp != "") { arrCliente.Add(tmp); } else { arrCliente.Add(0); }

                if (this.txtEmail.Text != "") { arrCliente.Add(txtEmail.Text); } else { arrCliente.Add("null"); }
                if (this.txtSite.Text != "") { arrCliente.Add(txtSite.Text); } else { arrCliente.Add("null"); }

                oCliente.Gravar(arrCliente, Acao);

                Classes.Estatica.clsGlobal.LimparControles((Control.ControlCollection)this.Controls);
                if (Acao == Enumeradores.eAcao.Atualizar)
                {
                    this.Close();
                }
            }
            catch { }
        }

        #endregion

        #region Enter

        //private void txtNome_Enter(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if ((this.txtEndereco.Text.Length != 0) && (this.txtEndereco.Text != ""))
        //        {
        //            this.btnGravar.Enabled = true;
        //        }
        //        else { this.btnGravar.Enabled = false; }
        //    }
        //    catch { }
        //}

        #endregion

        #region Leave

        //private void txtNome_Leave(object sender, EventArgs e)
        //{
        //    try
        //    { txtNome_Enter(sender, e); }
        //    catch { }
        //}

        #endregion

        #region KeyDown

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtNome.Text.Length != 0)
                {
                    this.txtEndereco.Focus();
                }
                else
                {
                    this.txtNome.Focus();
                    this.txtNome.SelectAll();
                }
            }
        }

        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbCep.Focus();
                this.mkbCep.SelectAll();
            }
        }

        private void mkbCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtCidade.Focus();
                this.txtCidade.SelectAll();
            }
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtBairro.Focus();
                this.txtBairro.SelectAll();
            }
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.cbEstado.Focus();
                this.cbEstado.SelectAll();
            }
        }

        private void cbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.cbPais.Focus();
                this.cbPais.SelectAll();
            }
        }

        private void cbPais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (pnlPessoaJuridica.Visible == true)
                {
                    this.mkbInscricaoEstadual.Focus();
                    this.mkbInscricaoEstadual.SelectAll();
                }
                else
                {
                    this.mkbRg.Focus();
                    this.mkbRg.SelectAll();
                }
            }
        }

        private void mkbInscricaoEstadual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbCnpj.Focus();
                this.mkbCnpj.SelectAll();
            }
        }

        private void mkbCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbTelefone.Focus();
                this.mkbTelefone.SelectAll();
            }
        }

        private void mkbRg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbCpf.Focus();
                this.mkbCpf.SelectAll();
            }
        }

        private void mkbCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbTelefone.Focus();
                this.mkbTelefone.SelectAll();
            }
        }

        private void mkbTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.mkbCelular.Focus();
                this.mkbCelular.SelectAll();
            }
        }

        private void mkbCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtEmail.Focus();
                this.txtEmail.SelectAll();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtSite.Focus();
                this.txtSite.SelectAll();
            }

        }

        private void txtSite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGravar.Focus();
            }
        }

        #endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarClientes_Activated(object sender, EventArgs e)
        {
            this.txtNome.Focus();
            this.txtNome.SelectAll();
        }

        private void cbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStatus.Checked == true) { cbStatus.Text = "ATIVO"; }
            else { cbStatus.Text = "INATIVO"; }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNome.Text.Length != 0)
                {
                    this.btnGravar.Enabled = true;
                }
                else
                {
                    this.btnGravar.Enabled = false;
                }
            }
            catch
            {

            }
        }

    }
}
