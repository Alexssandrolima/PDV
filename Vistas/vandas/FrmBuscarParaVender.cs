
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using CasaMendes.Classes;
using CasaMendes.Classes.Geral;
using CasaMendes.Classes.Estatica;

namespace CasaMendes.Formularios
{
    public partial class FrmBuscarParaVender : Form
    {

        ArrayList arr = new ArrayList();

        static string Filtro { get; set; }

        #region Construtor

        public string cod;
        public FrmBuscarParaVender()
        {
            InitializeComponent();

            //this.Text = clsGlobal.MontarTitulo("Estoque");

            //this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);

            //=============================================================================================
            //ProdutoControls.CarregarParaVender(this.dgv, "*");
            //this.dgv.RowHeadersVisible = false;
            //dgv.BackgroundColor = Color.DarkRed;
            //dgv.GridColor = dgv.BackgroundColor;
            //dgv.AllowUserToAddRows = false;

            //=============================================================================================
            //dgv.Columns[0].Visible = false;
            //dgv.Columns[1].Visible = false;

            //=============================================================================================
            //dgv.MultiSelect = false;
            //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //RedimencionarGradeProdutos();
        }

        #endregion

        private void RedimencionarGradeProdutos()
        {
            //try
            //{
            //    //=============================================================================================
            //    clsGlobal.RedimencionarGrade(this, dgv);
            //    this.BtnCancelar.Left = (int)(this.Width - (BtnCancelar.Width + 22));
            //    this.BtnCancelar.Top = (int)(this.Height - (BtnCancelar.Height + 50));
            //    //=============================================================================================
            //    dgv.Columns["Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //    //s===================================================================================================
            //    dgv.Columns["Produto"].Width = clsGlobal.DimencionarColuna(100, dgv.Width);

            //    gbBusca.Width = dgv.Width;
            //    gbBusca.Left = dgv.Left;

            //    //=============================================================================================
            //    //dgv.Height = btnFechar.Top - (dgv.Top + 10);

            //    //===================================================================================================
            //    dgv.Top = (gbBusca.Height + 10);

            //    //===================================================================================================
            //    this.BtnAceitar.Left = 8;//;
            //    this.BtnAceitar.Top = BtnCancelar.Top;

            //    this.dgv.Top = (gbBusca.Height + 10);
            //    this.dgv.Height = BtnCancelar.Top - (dgv.Top + 10);
            //}
            //catch
            //{
            //}

        }

        private void CancelarProduto()
        {
            //Filtro = "-1";
            //cod = "-1";
            //this.Close();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (dgv.Rows.Count > 0)
            //    {
            //        cod = Convert.ToString(dgv.Rows[e.RowIndex].Cells[1].Value);
            //        Filtro = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();

            //        arr.Clear();
            //        arr.Add(this.dgv.Rows[e.RowIndex].Cells[0].Value);
            //        arr.Add(this.dgv.Rows[e.RowIndex].Cells[1].Value);
            //        arr.Add(this.dgv.Rows[e.RowIndex].Cells[2].Value);
            //    }
            //    else
            //    {
            //        Filtro = "-1";
            //    }
            //}
            //catch { }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    BtnAceitar_Click(sender, null);
            //}
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    CancelarProduto();
            //}
        }

        private void FrmBuscarParaVender_KeyDown(object sender, KeyEventArgs e)
        {
            //txtBusca_KeyDown(sender, (KeyEventArgs)e);
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    this.Close();
            //}
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    Filtro = "-1";
            //    cod = "-1";
            //    this.Close();
            //}
        }

        private void txtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txtBusca.Text.Length > 0) { string s = this.txtCodigoDeBarras.Text; txtBusca.Clear(); this.txtCodigoDeBarras.Text = s; txtCodigoDeBarras.SelectionStart = txtCodigoDeBarras.TextLength; }
            //    if (this.txtCodigoDeBarras.TextLength > 0) { ProdutoControls.CarregarParaVender(dgv, "-1", txtCodigoDeBarras.Text); }
            //    else {ProdutoControls.CarregarParaVender(dgv, "*", "-1"); }
            //}
            //catch
            //{
            //}
        }

        private void txtCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    this.Close();
            //}
            //else if (e.KeyCode == Keys.Escape)
            //{
            //    Filtro = "-1";
            //    cod = "-1";
            //    this.Close();
            //}
        }

        private void FrmBuscarParaVender_Shown(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Classes.Estatica.clsGlobal.TagForm == "frmMenu")
            //    {
            //        this.txtCodigoDeBarras.Focus();
            //        this.txtCodigoDeBarras.SelectAll();
            //    }
            //    else
            //    {
            //        this.txtBusca.Focus();
            //        this.txtBusca.SelectAll();
            //    }
            //}
            //catch
            //{ }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txtCodigoDeBarras.Text.Length > 0) { string s = this.txtBusca.Text; txtCodigoDeBarras.Clear(); this.txtBusca.Text = s; txtBusca.SelectionStart = txtBusca.TextLength; }

            //    if (this.txtBusca.TextLength > 0) { ProdutoControls.CarregarParaVender(dgv, txtBusca.Text, "-1"); }
            //    else {ProdutoControls.CarregarParaVender(dgv, "*", "-1"); }
            //}
            //catch
            //{

            //}
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //CancelarProduto();
        }

        private void BtnAceitar_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

    }
}
