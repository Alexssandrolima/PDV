
using CasaMendes.Classes.Geral;
using CasaMendes.Classes.Estatica;
using System;
using System.Windows.Forms;

namespace CasaMendes.Formularios
{
    public partial class FrmResumoDeVendasAtual : Form
    {

        string Intervalo = DateTime.Now.ToString();
        string Inicio = DateTime.Now.ToString();

        public FrmResumoDeVendasAtual()
        {
            InitializeComponent();

            //===================================================================================================
             this.Text = clsGlobal.MontarTitulo("Resumo e Vendas atual (Diário).");

            //=============================================================================================
           clsGlobal.SetUpDataGridView(dgv);

            //=============================================================================================
            gbBusca.Top = 2;

        }

        private void RedimencionarGrade()
        {
            try
            {
                //=============================================================================================
                this.dgv.Columns[0].Width = clsGlobal.DimencionarColuna(35, this.Width);
                this.dgv.Columns[1].Width = clsGlobal.DimencionarColuna(16, this.Width);
                this.dgv.Columns[2].Width = clsGlobal.DimencionarColuna(9, this.Width);
                this.dgv.Columns[3].Width = clsGlobal.DimencionarColuna(12, this.Width);
                this.dgv.Columns[4].Width = clsGlobal.DimencionarColuna(12, this.Width);
                this.dgv.Columns[5].Width = clsGlobal.DimencionarColuna(11, this.Width);

                clsGlobal.AlinharElementosNoGridView(dgv, 0, "left");
                clsGlobal.AlinharElementosNoGridView(dgv, 1, "center");
                clsGlobal.AlinharElementosNoGridView(dgv, 2, "center");
                clsGlobal.AlinharElementosNoGridView(dgv, 3, "right");
                clsGlobal.AlinharElementosNoGridView(dgv, 4, "right");
                clsGlobal.AlinharElementosNoGridView(dgv, 5, "right");

                //--------------------------------
                this.dgv.Columns[2].DefaultCellStyle.Format = "000000";
                this.dgv.Columns[3].DefaultCellStyle.Format = "C2";
                this.dgv.Columns[4].DefaultCellStyle.Format = "C2";
                this.dgv.Columns[5].DefaultCellStyle.Format = "C2";
            }
            catch
            {

            }
        }
        
        private void FazerResumoDoDia(string Inicio, string Intervao)
        {
            try
            {
                Cl_PreVenda.FazerResumoDeVendas(Inicio, Intervalo);
            }
            catch { }
        }

        private void CarregarResumoDeVendas(string Inicio, string Intervao)
        {
            try
            {
                Cl_PreVenda.CarregarResumoDeVendasAtual(this.dgv, Inicio, Intervalo);
            }
            catch { }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmDashboardVendas_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarResumoDeVendas(Inicio, Intervalo);

                clsGlobal.RedimencionarGrade(this, dgv);

                this.RedimencionarGrade();

                this.btnFechar.Left = (int)(this.Width - (btnFechar.Width + 22));
                this.btnFechar.Top = (int)(this.Height - (btnFechar.Height + 50));
                ////=============================================================================================

                gbBusca.Width = dgv.Width;
                gbBusca.Left = dgv.Left;

                //=============================================================================================
                dgv.Top = (gbBusca.Height + 10);
                dgv.Height = btnFechar.Top - (dgv.Top + 10); //this.Height - 150;

                decimal vendas = clsGlobal.Calcular(this.dgv, 3);
                decimal custos = clsGlobal.Calcular(this.dgv, 4);
                decimal lucro = clsGlobal.Calcular(this.dgv, 5);

                this.TxtCusto.Text = custos.ToString("C2");
                this.TxtUnitario.Text = vendas.ToString("C2");//
                this.TxtLucro.Text = lucro.ToString("C2"); //(vendas - custos).ToString();
            }
            catch
            {

            }
        }

        private void McInicio_DateSelected(object sender, DateRangeEventArgs e)
        {
            Inicio = e.Start.ToShortDateString();
            CarregarResumoDeVendas(Inicio, Intervalo);

            this.RedimencionarGrade();
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (this.dgv.SelectedRows.Count > 0)
                    {
                        DialogResult retorno = (MessageBox.Show("Você confirma a exclusão da venda selecionada?",Application.ProductName, MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation));
                        if (retorno.Equals(DialogResult.Yes))
                        {
                            Cl_PreVenda.ExcluirVendaRessumo(dgv.Rows[this.dgv.SelectedRows[0].Index].Cells[0].Value.ToString());
                            dgv.Rows.RemoveAt(this.dgv.SelectedRows[0].Index);
                            e.Handled = false;
                        }
                        else {
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
            catch { }
            finally
            {
                this.CarregarResumoDeVendas(Inicio, Intervalo);
            }
        }

        private void FrmResumoDeVendasAtual_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FazerResumoDoDia(Inicio, Intervalo);
            }
            catch { }
        }

        private void McIntervalo_DateChanged(object sender, DateRangeEventArgs e)
        {
            Intervalo = e.Start.ToShortDateString();
            CarregarResumoDeVendas(Inicio, Intervalo);
        }

    }
}

