
using CasaMendes.Classes.Estatica;
using System;
using System.Windows.Forms;
using CasaMendes.Classes.Geral;

using oVenda = CasaMendes.Classes.Geral.Cl_PreVenda;

namespace CasaMendes.Formularios
{
    
    public partial class FrmCasaMendes : Form
    {
        public FrmCasaMendes()
        {
            //===================================================================================================
            InitializeComponent();

            //===================================================================================================
 

            this.Left = 50;
            this.Top = 50;

            this.Text = clsGlobal.MontarTitulo("Casa Mendes");

            this.btnSair.Top = this.Height - this.btnSair.Height - 50;
            this.btnClientes.Left = this.btnEstoque.Left = this.btnFornecedores.Left = this.btnFuncionario.Left = this.btnPdv.Left = this.btnReceber.Left = this.BtnDashboard.Left = this.btnSair.Left = 12;

            this.Width = (this.btnSair.Left + this.btnSair.Width + 28);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
            GC.Collect(2, GCCollectionMode.Optimized);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionarios f = new frmCadastrarFuncionarios();
            this.Hide();
            f.ShowDialog();
            if (f != null) { f.Dispose(); }
            this.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            frmFornecedores f = new frmFornecedores();
            this.Hide();
            f.ShowDialog();
            if (f != null) { f.Dispose(); }
            this.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes f = new frmClientes();
            this.Hide();
            f.ShowDialog();
            if (f != null) { f.Dispose(); }
            this.Show();
        }

        private void btnCarregarVendas_Click(object sender, EventArgs e)
        {
            frmCarregarVenda fc = new frmCarregarVenda();
            this.Hide();
            fc.ShowDialog();
            if (fc != null) { fc.Dispose(); }
            this.Show();
        }

        private void btnPdv_Click(object sender, EventArgs e)
        {
            FrmPDV f = new FrmPDV();
            this.Hide();
            f.ShowDialog();
            if (f != null) { f.Dispose(); }
            this.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoque f = new FrmEstoque();

            clsGlobal.TagForm = "FrmCasaMendes";
            this.Hide();
            f.ShowDialog();
            if (f != null) { f.Dispose(); }
            this.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FrmResumoDeVendasAtual f = new FrmResumoDeVendasAtual();
            this.Hide();
            f.ShowDialog();
            if (f != null) { f.Dispose(); }
            this.Show();
        //    FrmPromocao f = new FrmPromocao();
        //    this.Hide();
        //    f.ShowDialog();
        //    if (f != null) { f.Dispose(); }
        //    this.Show();
        }

        private void FrmCasaMendes_Load(object sender, EventArgs e)
        {
            //    try
            //    {
            //        oVenda.FazerResumoDeVendas(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString());
            //    }
            //    catch
            //    {

            //    }
        }

        private void FrmCasaMendes_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {
                oVenda.FazerResumoDeVendas(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString());
            }
            catch
            {

            }
        }
    }
}
