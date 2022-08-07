
using CasaMendes.Classes.Geral;
using CasaMendes.Classes.Estatica;
using CasaMendes.Propriedades;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class frmCadastrarProdutos : Form
    {

        #region Variáveis.

        cl_Produto oProduto;
        private bool _Editar;
        private bool EstaCarregando = false;
        private Color CorDaPena = Color.Red;

        #endregion

        #region Construtor.

        public frmCadastrarProdutos()
        {
            InitializeComponent();
            oProduto = new cl_Produto();

            oProduto.CarregarCaixaCombo(this.cbFornecedores, "RazaoSocial", "tFornecedores");

        }

        #endregion

        #region Manutenção.

        private void PrepararParaUmNovoRegistro()
        {
            try
            {
                this.txtCodigoDeBarras.Enabled = true;
                this.txtCodigoDoFornecedor.Enabled = false;
                this.cbFornecedores.Enabled = false;

                this.TxtValorDesconto.Enabled = false;
                this.txtDesconto.Enabled = false;
                this.txtEstoque.Enabled = false;
                this.txtPrecoDeVendaVista.Enabled = false;
                this.txtPrecoUnitario.Enabled = false;
                this.txtProduto.Enabled = false;
                this.txtQuantidade.Enabled = false;
                this.txtValorCompra.Enabled = false;
                this.dtpDataDeValidade.Enabled = false;

                string Img = Classes.Estatica.clsGlobal.ValidarDiretorio(Classes.Estatica.clsGlobal.sCaminho, @"imagens\apagar.png");
                this.PicFoto.Image = Image.FromFile(Img);
            }
            catch {; }
        }

        private void AtribuirValores()
        {
            if (!this.txtCodigoDeBarras.Text.Equals(""))
            {
                this.oProduto.CodigoDeBarras = string.Format(this.txtCodigoDeBarras.Text, "00000000000000");
            }

            if (this.txtCodigoDoFornecedor.Text != "")
            {
                this.oProduto.CodigoDoFornecedor = Convert.ToDecimal(this.txtCodigoDoFornecedor.Text.ToString());
            }

            if (this.txtID_Produto.Text != "")
            {
                this.oProduto.ID_Produto = Convert.ToDecimal(this.txtID_Produto.Text);
            }


            this.oProduto.RazaoSocial = this.cbFornecedores.Text;
            this.oProduto.Produto = this.txtProduto.Text;
            this.oProduto.DataDeValidade = this.dtpDataDeValidade.Value;
            this.oProduto.ValorCompra = Convert.ToDecimal(this.txtValorCompra.Text.Replace("R$ ", "").ToString());
            this.oProduto.Quantidade = Convert.ToDecimal(this.txtQuantidade.Text.ToString());
            this.oProduto.Estoque = Convert.ToDecimal(this.txtEstoque.Text.ToString());
            this.oProduto.PrecoUnitario = Convert.ToDecimal(this.txtPrecoUnitario.Text.Replace("R$ ", "").ToString());
            this.oProduto.PrecoDeVenda = Convert.ToDecimal(this.txtPrecoDeVendaVista.Text.Replace("R$ ", "").ToString());
            this.oProduto.CodigoDaNotaFiscal = Convert.ToInt32(this.TxtCodigoDaNotaFiscal.Text.ToString());

            if (this.txtDesconto.Text != "" && this.TxtValorDesconto.Text != "")
            {
                this.oProduto.Desconto = Convert.ToInt16(this.txtDesconto.ToString());             
                this.oProduto.ValorDeDesconto = Convert.ToDecimal(this.TxtValorDesconto.Text.Replace("R$ ", "").ToString());
            }
            else
            {
                this.oProduto.Desconto = 0;
                this.oProduto.ValorDeDesconto = 0;
            }

        }

        void CalcularPrecos()
        {
            string sTemp;
            decimal Cem = 100;
            decimal Porcentagem = 1;

            decimal MargemDeLucro = 14;
            decimal Imposto = 8;
            decimal CustoFixo = 1;
            decimal Frete = 1;
            decimal OutrosEncargos = 1;

            sTemp = txtPrecoUnitario.Text.Replace("R$ ", "").ToString();
            decimal PrecoUnitario = Convert.ToDecimal(sTemp);

            Porcentagem = (Cem - ((MargemDeLucro + Imposto + CustoFixo + Frete + OutrosEncargos))) / Cem;

            decimal PrecoDeVendaVista = PrecoUnitario / Porcentagem;

            txtPrecoDeVendaVista.Text = PrecoDeVendaVista.ToString("C2");

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                this.AtribuirValores();

                switch (_Editar)
                {
                    case false:
                        oProduto.Novo();
                        break;
                    case true:
                        oProduto.Atualizar();
                        this.Close();
                        break;
                }
            }
            catch
            {

            }
        }

        private void lblPicFoto_Click(object sender, EventArgs e)
        {
            clsGlobal.Abririmagens(this.PicFoto);
        }

        #endregion

        #region Fechar formulário

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            GC.Collect();
        }

        #endregion

        #region KeyDown

        private void TxtCodigoDaNotaFiscal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.TxtCodigoDaNotaFiscal.Text.Length > 0)
                {
                    this.txtCodigoDeBarras.Enabled = true;
                    this.txtCodigoDeBarras.Focus();
                    this.txtCodigoDeBarras.SelectAll();
                }
                else
                {
                    this.TxtCodigoDaNotaFiscal.Focus();
                }
            }

        }

        private void txtCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtCodigoDeBarras.Text.Length > 0)
                {
                    this.txtProduto.Enabled = true;
                    this.txtProduto.Focus();
                    this.txtProduto.SelectAll();
                }
                else
                {
                    this.txtCodigoDeBarras.Focus();
                }
            }

        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtProduto.Text.Length > 0)
                {
                    this.cbFornecedores.Enabled = true;
                    this.cbFornecedores.Focus();
                    this.cbFornecedores.SelectAll();
                }
                else
                {
                    this.cbFornecedores.Focus();
                }
            }
        }

        private void dtpDataDeValidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    if (this.dtpDataDeValidade.Text.Length > 0)
                    {
                        this.txtValorCompra.Enabled = true;
                        this.txtValorCompra.Focus();
                        this.txtValorCompra.SelectAll();
                    }
                    else
                    {
                        this.dtpDataDeValidade.Focus();
                    }
                }
        }

        private void txtValorCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtValorCompra.Text.Length > 0)
                {
                    this.txtQuantidade.Enabled = true;
                    this.txtQuantidade.Focus();
                    this.txtQuantidade.SelectAll();
                }
                else
                {
                    this.txtValorCompra.Focus();
                }
            }

        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (this.txtQuantidade.Text.Length > 0)
                    {
                        this.txtPrecoUnitario.Enabled = true;
                        this.txtPrecoUnitario.Focus();
                        this.txtPrecoUnitario.SelectAll();
                    }
                    else
                    {
                        this.txtQuantidade.Focus();
                    }
                }
                else
                {
                    decimal q = Convert.ToDecimal(txtQuantidade.Text.Replace("R$ ", ""));
                    decimal v = Convert.ToDecimal(txtValorCompra.Text.Replace("R$ ", ""));
                    if (q > 0 && v > 0)
                    {
                        this.txtPrecoUnitario.Text = (v / q).ToString("C");
                        CalcularPrecos();
                    }
                }
            }
            catch {; }
        }

        private void txtPrecoUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtPrecoUnitario.Text.Length > 0)
                {
                    this.txtEstoque.Enabled = true;
                    this.txtEstoque.Focus();
                    this.txtEstoque.SelectAll();
                }
                else
                {
                    this.txtPrecoUnitario.Focus();
                }
            }
        }

        private void txtEstoque_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtEstoque.Text.Length > 0)
                {
                    this.txtPrecoDeVendaVista.Enabled = true;
                    this.txtPrecoDeVendaVista.Focus();
                    this.txtPrecoDeVendaVista.SelectAll();
                }
                else
                {
                    this.txtEstoque.Focus();
                }
            }
        }

        private void txtPrecoDeVendaVista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtPrecoDeVendaVista.Text.Length > 0)
                {
                    this.txtDesconto.Enabled = true;
                    this.txtDesconto.Focus();
                    this.txtDesconto.SelectAll();
                }
                else
                {
                    this.txtPrecoDeVendaVista.Focus();
                }
            }
        }

        private void cbFornecedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.cbFornecedores.Text.Length > 0)
                {
                    this.dtpDataDeValidade.Enabled = true;
                    this.dtpDataDeValidade.Focus();
                    this.cbFornecedores.SelectAll();
                }
                else
                {
                    this.cbFornecedores.Focus();
                }
            }
        }

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (this.txtDesconto.Text.Length <= 0)
                {
                    this.txtDesconto.Text = "0";
                }

                this.TxtValorDesconto.Enabled = true;
                this.TxtValorDesconto.Focus();
                this.TxtValorDesconto.SelectAll();

            }
        }

        private void TxtValorDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGravar.Focus();
            }
        }

        #endregion

        #region Efeito visual de BackColor e formatação.

        #region Enter.

        private void txtCodigoDeBarras_Enter(object sender, EventArgs e)
        {
            this.txtCodigoDeBarras.BackColor = Color.Gold;
        }

        private void txtProduto_Enter(object sender, EventArgs e)
        {
            this.txtProduto.BackColor = Color.Gold;
        }

        private void cbFornecedores_Enter(object sender, EventArgs e)
        {
            this.cbFornecedores.BackColor = Color.Gold;
        }

        private void dtpDataDeValidade_Enter(object sender, EventArgs e)
        {
            this.dtpDataDeValidade.BackColor = Color.Gold;
        }

        private void txtValorCompra_Enter(object sender, EventArgs e)
        {
            this.txtValorCompra.BackColor = Color.Gold;
        }

        private void TxtQuantidade_Enter(object sender, EventArgs e)
        {
            this.txtQuantidade.BackColor = Color.Gold;
        }

        private void txtPrecoUnitario_Enter(object sender, EventArgs e)
        {
            this.txtPrecoUnitario.BackColor = Color.Gold;
        }

        private void txtEstoque_Enter(object sender, EventArgs e)
        {
            this.txtEstoque.BackColor = Color.Gold;
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            this.txtDesconto.BackColor = Color.Gold;
        }

        private void txtPrecoDeVendaVista_Enter(object sender, EventArgs e)
        {
            this.txtPrecoDeVendaVista.BackColor = Color.Gold;
        }

        #endregion

        #region Leave.

        private void txtCodigoDeBarras_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtCodigoDeBarras.BackColor = Color.GreenYellow;
                decimal dCodigo = Convert.ToDecimal(this.txtCodigoDeBarras.Text);
                this.txtCodigoDeBarras.Text = dCodigo.ToString("0000000000000");
            }
            catch {; }
        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            this.txtProduto.BackColor = Color.GreenYellow;
        }

        private void cbFornecedores_Leave(object sender, EventArgs e)
        {
            this.cbFornecedores.BackColor = Color.GreenYellow;
        }

        private void dtpDataDeValidade_Leave(object sender, EventArgs e)
        {
            this.dtpDataDeValidade.BackColor = Color.GreenYellow;
        }

        private void txtValorCompra_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal dValor = Convert.ToDecimal(this.txtValorCompra.Text);
                this.txtValorCompra.Text = dValor.ToString("C2");
                this.txtValorCompra.BackColor = Color.GreenYellow;
            }
            catch {; }
        }

        private void TxtQuantidade_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtQuantidade.BackColor = Color.GreenYellow;
                decimal dValor = Convert.ToDecimal(this.txtQuantidade.Text);
                this.txtQuantidade.Text = dValor.ToString("00,00");
            }
            catch {; }
        }

        private void txtPrecoUnitario_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtPrecoUnitario.BackColor = Color.GreenYellow;
                decimal dValor = Convert.ToDecimal(this.txtPrecoUnitario.Text);
                this.txtPrecoUnitario.Text = dValor.ToString("C2");
            }
            catch {; }
        }

        private void txtEstoque_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtEstoque.BackColor = Color.GreenYellow;
                decimal dValor = Convert.ToDecimal(this.txtEstoque.Text);
                this.txtEstoque.Text = dValor.ToString("00,00");
            }
            catch {; }
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtDesconto.BackColor = Color.GreenYellow;
                decimal dValor = Convert.ToDecimal(this.txtDesconto.Text);
                this.txtDesconto.Text = dValor.ToString("C2");
            }
            catch {; }
        }

        private void txtPrecoDeVendaVista_Leave(object sender, EventArgs e)
        {
            try
            {
                this.txtPrecoDeVendaVista.BackColor = Color.GreenYellow;
                decimal dValor = Convert.ToDecimal(this.txtPrecoDeVendaVista.Text);
                this.txtPrecoDeVendaVista.Text = dValor.ToString("C2");
            }
            catch {; }
        }

        #endregion

        #endregion

        #region Formulário.
        
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (EstaCarregando.Equals(true)) return;
            try
            {
                decimal q = Convert.ToDecimal(txtQuantidade.Text.Replace("R$ ", ""));
                decimal v = Convert.ToDecimal(txtValorCompra.Text.Replace("R$ ", ""));
                if (q > 0 && v > 0)
                {
                    this.txtPrecoUnitario.Text = (v / q).ToString("C");
                    CalcularPrecos();
                }
            }
            catch { }
        }

        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {
            if (EstaCarregando.Equals(true)) return;
            try
            {
                decimal q = Convert.ToDecimal(txtQuantidade.Text.Replace("R$ ", ""));
                decimal v = Convert.ToDecimal(txtValorCompra.Text.Replace("R$ ", ""));
                if (q > 0 && v > 0)
                {
                    CalcularPrecos();
                }
            }
            catch { }
        }

        private void frmCadastrarProdutos_Shown(object sender, EventArgs e)
        {
            try
            {
                if (clsGlobal.TagForm.ToString() == "Novo")
                {
                    _Editar = false;
                    clsGlobal.LimparControles((ControlCollection)this.Controls);
                    PrepararParaUmNovoRegistro();
                }
                else
                {
                    EstaCarregando = true;
                   _Editar = true;

                    List<cl_pProduto> pL = cl_Produto.CarregarProduto(this.txtCodigoDeBarras.Text);

                    if(pL != null)
                    {
                        this.txtID_Produto.Text          = pL[0].ID_Produto.ToString();
                        this.txtCodigoDoFornecedor.Text  = pL[0].CodigoDoFornecedor.ToString();
                        this.txtCodigoDeBarras.Text      = pL[0].CodigoDeBarras.ToString();
                        this.txtProduto.Text             = pL[0].Produto.ToString();
                        this.cbFornecedores.SelectedItem = pL[0].RazaoSocial.ToString();
                        this.txtValorCompra.Text         = pL[0].ValorCompra.ToString();
                        this.txtQuantidade.Text          = pL[0].Quantidade.ToString();
                        this.txtPrecoUnitario.Text       = pL[0].PrecoUnitario.ToString();
                        this.txtEstoque.Text             = pL[0].Estoque.ToString();
                        this.txtPrecoDeVendaVista.Text   = pL[0].PrecoDeVenda.ToString();
                        this.txtDesconto.Text            = pL[0].Desconto.ToString();
                        this.TxtValorDesconto.Text = pL[0].ValorDesconto.ToString();
                        this.dtpDataDeValidade.Text      = pL[0].DataDeValidade.ToShortDateString();
                        this.TxtCodigoDaNotaFiscal.Text = pL[0].CodigoDaNotaFiscal.ToString();
                    }
                }

                this.btnExcluir.Enabled = _Editar;
                clsGlobal.CorDaPenaDosControles((ControlCollection)this.Controls);
                EstaCarregando = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        #endregion

    }
}
