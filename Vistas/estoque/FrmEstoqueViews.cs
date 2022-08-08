using CasaMendes.Classes;
using CasaMendes.Classes.Geral;
using CasaMendes.Classes.Estatica;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class FrmEstoqueViews : Form
    {
        //ArrayList arr = new ArrayList();
        //frmCadProdViews fc;

        //static string sFiltro { get; set; }

        #region Construtor

        //public string cod;
        public FrmEstoqueViews()
        {
            InitializeComponent();

            //this.Text = clsGlobal.MontarTitulo("Estoque");

            //this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);

            ////=============================================================================================
            //ProdutoControls.CarregarDoEstoque(this.dgv, "*");
           
            //clsGlobal.SetUpDataGridView(this.dgv);

            //try
            //{
            //    RedimencionarGradeProdutos();
            //}
            //catch { }
        }

        #endregion

        //private void RedimencionarGradeProdutos()
        //{
        //try
        //{

        //    //=============================================================================================
        //    clsGlobal.RedimencionarGrade(this, dgv);

        //    this.btnFechar.Left = (int)(this.Width - (btnFechar.Width + 22));
        //    this.btnFechar.Top = (int)(this.Height - (btnFechar.Height + 50));

        //    //=============================================================================================
        //    dgv.Columns[0].Visible = false;//ocultar 0
        //    dgv.Columns[5].Visible = false;//ocultar 5
        //    dgv.Columns[6].Visible = false;//ocultar 6

        //    clsGlobal.AlinharElementosNoGridView(dgv, 1, "right");
        //    clsGlobal.AlinharElementosNoGridView(dgv, 2, "left");
        //    clsGlobal.AlinharElementosNoGridView(dgv, 3, "center");
        //    clsGlobal.AlinharElementosNoGridView(dgv, 4, "center");
        //    clsGlobal.AlinharElementosNoGridView(dgv, 7, "right");
        //    clsGlobal.AlinharElementosNoGridView(dgv, 8, "right");
        //    clsGlobal.AlinharElementosNoGridView(dgv, 9, "right");
        //    clsGlobal.AlinharElementosNoGridView(dgv, 10, "right");

        //    //s===================================================================================================
        //    dgv.Columns[1].DefaultCellStyle.Format = "0000000000000";
        //    dgv.Columns[4].DefaultCellStyle.Format = "0000000000";
        //    dgv.Columns[7].DefaultCellStyle.Format = "R$ 0.00";
        //    dgv.Columns[8].DefaultCellStyle.Format = "0000000000";
        //    dgv.Columns[9].DefaultCellStyle.Format = "R$ 0.00";
        //    dgv.Columns[10].DefaultCellStyle.Format = "0000000000";

        //CodigoDeBarras    ]";//1
        //Produto]";        //2
        //DataDeValidade]";//3
        //Quantidade]";//4
        //PrecoDeVenda]";//7
        //Estoque]";//8
        //Desconto]";//9
        //ValorDesconto]";//10

        //===================================================================================================
        //    dgv.Columns[1].Width = clsGlobal.DimencionarColuna(13, dgv.Width);
        //    dgv.Columns[2].Width = clsGlobal.DimencionarColuna(29, dgv.Width);
        //    dgv.Columns[3].Width = clsGlobal.DimencionarColuna(12, dgv.Width);
        //    dgv.Columns[4].Width = clsGlobal.DimencionarColuna(8, dgv.Width);
        //    dgv.Columns[7].Width = clsGlobal.DimencionarColuna(8, dgv.Width);
        //    dgv.Columns[8].Width = clsGlobal.DimencionarColuna(10, dgv.Width);
        //    dgv.Columns[9].Width = clsGlobal.DimencionarColuna(10, dgv.Width);
        //    dgv.Columns[10].Width = clsGlobal.DimencionarColuna(10, dgv.Width);

        //    gbBusca.Width = dgv.Width;
        //    gbBusca.Left = dgv.Left;

        //    //===================================================================================================
        //    dgv.Top = (gbBusca.Height + 10);

        //    //===================================================================================================
        //    this.btnNovo.Left = 8;//;
        //    this.btnNovo.Top = btnFechar.Top;

        //    //=============================================================================================
        //    this.btnEditar.Left = 120;//
        //    this.btnEditar.Top = btnFechar.Top;

        //    //=============================================================================================
        //    this.btnExcluir.Left = 241;//
        //    this.btnExcluir.Top = btnFechar.Top;

        //    //=============================================================================================
        //    this.btnAbrirListaDeesconto.Left = 369;//
        //    this.btnAbrirListaDeesconto.Top = btnFechar.Top;

        //    this.dgv.Top = (gbBusca.Height + 10);
        //    this.dgv.Height = btnFechar.Top - (dgv.Top + 10);
        //}
        //catch
        //{
        //}

        //}

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            //    if (e.KeyCode == Keys.Escape)
            //    {
            //        sFiltro = "-1";
            //        cod = "-1";
            //        this.Close();
            //    }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //    this.Close();
            //    this.Dispose();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //    try
            //    {
            //        if (dgv.Rows.Count > 0)
            //        {
            //            cod = Convert.ToString(dgv.Rows[e.RowIndex].Cells[1].Value);
            //            sFiltro = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            //            btnEditar.Enabled = true; btnExcluir.Enabled = true;
            //            btnNovo.Enabled = true;
            //            btnEditar.Enabled = true;
            //            arr.Clear();

            //            arr.Add(sFiltro);
            //         }
            //        else
            //        {
            //            sFiltro = "-1";
            //            btnEditar.Enabled = false;
            //            btnExcluir.Enabled = false;
            //            btnNovo.Enabled = false;
            //        }
            //    }
            //    catch { }
        }

        private void frmBuscarProduto_Resize(object sender, EventArgs e)
        {
            //    try
            //    {
            //        //RedimencionarGradeProdutos();
            //    }
            //    catch { }
        }

        private void frmBuscarProduto_Move(object sender, EventArgs e)
        {
            //    //RedimencionarGradeProdutos();
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            //    if (e.KeyCode == Keys.Enter)
            //    {
            //        this.Close();
            //    }
            //    else if (e.KeyCode == Keys.Escape)
            //    {
            //        sFiltro = "-1";
            //        cod = "-1";
            //        this.Close();
            //    }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        fc = new frmCadProdViews();
            //        clsGlobal.TagForm = "editar";
            //        fc.txtCodigoDeBarras.Text = this.cod;//this.arr[1].ToString();
            //        fc.Text = clsGlobal.MontarTitulo("Cadastro de produtos", "Atualizar");

            //        fc.ShowDialog();
            //        fc.Dispose();
            //        //=============================================================================================
            //        if (txtBusca.Text != "") { ProdutoControls.CarregarDoEstoque(this.dgv, txtBusca.Text); }
            //        else if (txtCodigoDeBarras.Text != "") { ProdutoControls.CarregarDoEstoque(this.dgv, "-1", txtCodigoDeBarras.Text); }
            //        else ProdutoControls.CarregarDoEstoque(this.dgv, "*");
            //        //RedimencionarGradeProdutos();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message,Application.ProductName);
            //    }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //    fc = new frmCadProdViews();
            //    clsGlobal.TagForm = "Novo";
            //    fc.Text = clsGlobal.MontarTitulo("Cadastar produto", "Cadastrar");
            //    fc.ShowDialog();
            //    fc.Dispose();
            //    //=============================================================================================
            //    if (txtBusca.Text != "") { ProdutoControls.CarregarDoEstoque(this.dgv, txtBusca.Text); }
            //    else if (txtCodigoDeBarras.Text != "") { ProdutoControls.CarregarDoEstoque(this.dgv, "-1", txtCodigoDeBarras.Text); }
            //    else ProdutoControls.CarregarDoEstoque(this.dgv, "*");

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        if (this.dgv.Rows.Count > 0)
            //        {
            //            Classes.ADL.Cl_Dados.Excluir("tProdutos", "ID_Produto", sFiltro);
            //            ProdutoControls.CarregarDoEstoque(this.dgv, "*");
            //        }
            //    }
            //    catch
            //    {

            //    }
        }

        private void txtCodigoDeBarras_TextChanged(object sender, EventArgs e)
        {
            //    try
            //    {
            //        if (this.txtBusca.Text.Length > 0) {
            //            string s = this.txtCodigoDeBarras.Text;
            //            txtBusca.Clear();
            //            this.txtCodigoDeBarras.Text = s;
            //            txtCodigoDeBarras.SelectionStart = txtCodigoDeBarras.TextLength;
            //        }
            //        if (this.txtCodigoDeBarras.TextLength > 4) {
            //            ProdutoControls.CarregarDoEstoque(dgv, "-1", txtCodigoDeBarras.Text);
            //        }
            //        else { return; }
            //    }
            //    catch
            //    {
            //    }
        }

        private void txtCodigoDeBarras_KeyDown(object sender, KeyEventArgs e)
        {
            //    if (e.KeyCode == Keys.Enter)
            //    {
            //        this.Close();
            //    }
            //    else if (e.KeyCode == Keys.Escape)
            //    {
            //        sFiltro = "-1";
            //        cod = "-1";
            //        this.Close();
            //    }
        }

        private void frmBuscarProduto_Shown(object sender, EventArgs e)
        {
            //    try
            //    {
            //        if (clsGlobal.TagForm == "frmMenu")
            //        {
            //            this.txtCodigoDeBarras.Focus();
            //            this.txtCodigoDeBarras.SelectAll();
            //        }
            //        else
            //        {
            //            this.txtBusca.Focus();
            //            this.txtBusca.SelectAll();
            //        }
            //    }
            //    catch
            //    { }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            //    try
            //    {
            //        if (this.txtCodigoDeBarras.Text.Length > 0) { string s = this.txtBusca.Text; txtCodigoDeBarras.Clear(); this.txtBusca.Text = s; txtBusca.SelectionStart = txtBusca.TextLength; }

            //        if (this.txtBusca.TextLength > 0) { ProdutoControls.CarregarDoEstoque(dgv, txtBusca.Text, "-1"); }
            //        else { ProdutoControls.CarregarDoEstoque(dgv, "*", "-1"); }
            //    }
            //    catch
            //    {

            //    }
        }

        private void btnAbrirListaDeesconto_Click(object sender, EventArgs e)
        {
            //    FrmPromocao fp = new FrmPromocao();
            //    fp.ShowDialog();
            //    fp.Dispose();
            //    GC.Collect();
        }

    }
}

//mendes.josesilva@hotmail.com