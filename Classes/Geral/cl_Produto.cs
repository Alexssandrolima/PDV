
using CasaMendes.Classes.ADL;
using CasaMendes.Classes.Estatica;
using CasaMendes.Propriedades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

/*
 Executing a stored procedure
To execute a stored procedure, you use the CALL statement:
CALL stored_procedure_name(argument_list);
*/

namespace CasaMendes.Classes.Geral
{
    public class cl_Produto : cl_pProduto
    {
        #region Variáveis
        DataSet oDs;

        private decimal dValorDesconto;
        public decimal ValorDeDesconto
        {
            get { return dValorDesconto; }
            set { dValorDesconto = value; }
        }

        #endregion

        #region Manutenção de dados

        private void AdicionarParrametosProduto()
        {

            if (Cl_Dados.Params.Count != 0) Cl_Dados.Params.Clear();
            if (CodigoDoFornecedor <= 0)
            {
                string sSql = "SELECT CodigoDoFornecedor FROM tFornecedores WHERE RazaoSocial = @RazaoSocial";
                Cl_Dados.AdicionarParametro("@RazaoSocial", RazaoSocial);
                CodigoDoFornecedor = Convert.ToDecimal(Classes.ADL.Cl_Dados.RetornoEscalarDeUmRegistro(sSql));
            }

            if (ID_Produto > 0)
            {
                Cl_Dados.AdicionarParametro("@ID_Produto".Trim(), ID_Produto.ToString());
            }

            Cl_Dados.AdicionarParametro("@CodigoDeBarras".Trim(), CodigoDeBarras.ToString());
            Cl_Dados.AdicionarParametro("@CodigoDoFornecedor".Trim(), CodigoDoFornecedor.ToString());
            Cl_Dados.AdicionarParametro("@Produto".Trim(), Produto);
            Cl_Dados.AdicionarParametro("@DataDeValidade".Trim(), DataDeValidade.ToShortDateString());
            Cl_Dados.AdicionarParametro("@ValorCompra".Trim(), ValorCompra.ToString());
            Cl_Dados.AdicionarParametro("@Quantidade".Trim(), Quantidade.ToString());
            Cl_Dados.AdicionarParametro("@Estoque".Trim(), Estoque.ToString());
            Cl_Dados.AdicionarParametro("@PrecoUnitario".Trim(), PrecoUnitario.ToString(""));
            Cl_Dados.AdicionarParametro("@PrecoDeVenda".Trim(), PrecoDeVenda.ToString(""));
            Cl_Dados.AdicionarParametro("@Desconto".Trim(), Desconto.ToString(""));
            Cl_Dados.AdicionarParametro("@ValorDesconto".Trim(), ValorDeDesconto.ToString("0.0000"));
            Cl_Dados.AdicionarParametro("@CodigoDaNotaFiscal".Trim(), CodigoDaNotaFiscal.ToString(""));


        }

        private void AdicionarParrametosEstoque(string JaExiste = null)
        {

            if (Cl_Dados.Params.Count != 0) Cl_Dados.Params.Clear();
            if (!JaExiste.Equals(CodigoDeBarras.ToString())) // Se o usuário já estiver cadastrado imforma e sai,caso coontrário procegue com o cadastro.
            {
            Cl_Dados.AdicionarParametro("@CodigoDeBarras"   .Trim(), CodigoDeBarras.ToString());
            Cl_Dados.AdicionarParametro("@Produto"          .Trim(), Produto);
            Cl_Dados.AdicionarParametro("@DataDeValidade"   .Trim(), DataDeValidade.ToShortDateString());
            Cl_Dados.AdicionarParametro("@DataDaCompra"     .Trim(), DateTime.Now.ToShortTimeString());
            Cl_Dados.AdicionarParametro("@DataAtualizacao"  .Trim(), DateTime.Now.ToShortTimeString());
            Cl_Dados.AdicionarParametro("@Quantidade"       .Trim(), Quantidade.ToString());
            Cl_Dados.AdicionarParametro("@ValorCompra"      .Trim(), ValorCompra.ToString());
            Cl_Dados.AdicionarParametro("@PrecoUnitario"    .Trim(), PrecoUnitario.ToString(""));
            Cl_Dados.AdicionarParametro("@PrecoDeVenda"     .Trim(), PrecoDeVenda.ToString(""));
            Cl_Dados.AdicionarParametro("@Estoque"          .Trim(), Estoque.ToString());
            Cl_Dados.AdicionarParametro("@Desconto"         .Trim(), Desconto.ToString());
            Cl_Dados.AdicionarParametro("@ValorDesconto"    .Trim(), ValorDeDesconto.ToString());
            }
            else
            {
                Cl_Dados.AdicionarParametro("@CodigoDeBarras".Trim(), CodigoDeBarras.ToString());
                Cl_Dados.AdicionarParametro("@DataDeValidade".Trim(), DataDeValidade.ToShortDateString());
                Cl_Dados.AdicionarParametro("@DataAtualizacao".Trim(), DateTime.Now.ToShortTimeString());
                Cl_Dados.AdicionarParametro("@Quantidade".Trim(), Quantidade.ToString());
                Cl_Dados.AdicionarParametro("@ValorCompra".Trim(), ValorCompra.ToString());
                Cl_Dados.AdicionarParametro("@PrecoUnitario".Trim(), PrecoUnitario.ToString(""));
                Cl_Dados.AdicionarParametro("@PrecoDeVenda".Trim(), PrecoDeVenda.ToString(""));
                Cl_Dados.AdicionarParametro("@Estoque".Trim(), Estoque.ToString());
                Cl_Dados.AdicionarParametro("@Desconto".Trim(), Desconto.ToString());
                Cl_Dados.AdicionarParametro("@ValorDesconto".Trim(), ValorDeDesconto.ToString());

            }
        }

        private List<string> ListarCamposProduto()
        {
            List<string> Campos = new List<string>();
            Campos.Add("tProdutos");
            Campos.Add("CodigoDeBarras");
            Campos.Add("CodigoDoFornecedor");
            Campos.Add("Produto");
            Campos.Add("DataDeValidade");
            Campos.Add("ValorCompra");
            Campos.Add("Quantidade");
            Campos.Add("Estoque");
            Campos.Add("PrecoUnitario");
            Campos.Add("PrecoDeVenda");
            Campos.Add("Desconto");
            Campos.Add("ValorDesconto");
            Campos.Add("CodigoDaNotaFiscal");
            return Campos;
        }

        private List<string> ListarCampoEstoque(string JaExiste = null)
        {
            List<string> Campos = new List<string>();
            if (!JaExiste.Equals(CodigoDeBarras.ToString())) // Se o usuário já estiver cadastrado imforma e sai,caso coontrário procegue com o cadastro.
            {
                Campos.Add("tEstoque");
                Campos.Add("CodigoDeBarras");
                Campos.Add("Produto");
                Campos.Add("DataDeValidade");
                Campos.Add("DataDaCompra");
                Campos.Add("DataAtualizacao");
                Campos.Add("Quantidade");
                Campos.Add("ValorCompra");
                Campos.Add("PrecoUnitario");
                Campos.Add("PrecoDeVenda");
                Campos.Add("Estoque");
                Campos.Add("Desconto");
                Campos.Add("ValorDesconto");
            }
            else
            {
                Campos.Add("tEstoque");
                Campos.Add("CodigoDeBarras");
                Campos.Add("Produto");
                Campos.Add("DataDeValidade");
                Campos.Add("DataAtualizacao");
                Campos.Add("Quantidade");
                Campos.Add("ValorCompra");
                Campos.Add("PrecoUnitario");
                Campos.Add("PrecoDeVenda");
                Campos.Add("Estoque");
                Campos.Add("Desconto");
                Campos.Add("ValorDesconto");
            }
            return Campos;
        }

        public void Novo()
        {
            try
            {
                ID_Produto = 0;
                AdicionarParrametosProduto();
                Cl_Dados.Cadastrar(ListarCamposProduto(),false);//Chama o método cadastrar da classe Dados.

                string JaExiste = Cl_Dados.LerUmRegistro("SELECT CodigoDeBarras FROM tEstoque WHERE CodigoDeBarras = '" + CodigoDeBarras + "'");//  Verif(ica se o usuário não está cadastrado no controle de acesso.
                AdicionarParrametosEstoque(JaExiste);
                Cl_Dados.Cadastrar(ListarCampoEstoque(CodigoDeBarras.ToString()),true);//Chama o método cadastrar da classe Dados.
            }
            catch (Exception ex)
            {
                Classes.Estatica.clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00003 + ": " + ex.Message);
            }
        }

        public void Atualizar()
        {
            try
            {
                AdicionarParrametosProduto();
                Cl_Dados.Atualizar(ListarCamposProduto(),false);//Chama o método atualizar da classe Dados.

                AdicionarParrametosEstoque(CodigoDeBarras.ToString());
                Cl_Dados.Atualizar(ListarCampoEstoque(CodigoDeBarras.ToString()),true);//Chama o método atualizar da classe Dados.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
                clsGlobal.RegistrarLogDeErros(0, clsMensagens.M00003 + ": " + ex.Message);
            }
        }

        public void Excluir(string sTabele, string sId, string sFiltro)
        {
            Cl_Dados.Excluir(sTabele, sId, sFiltro);
        }

        #endregion

        #region Baixar dados

        public static List<cl_pProduto> CarregarProduto(string Filtro = "-1")
        {
            string sSql = "";
            try
            {
                if (Filtro == "*")
                {
                    sSql = "SELECT";
                    sSql += "  ID_Produto";
                    sSql += ", CodigoDeBarras";
                    sSql += ", tFornecedores.CodigoDoFornecedor";
                    sSql += ", tFornecedores.RazaoSocial AS Fornecedor";
                    sSql += ", Produto";
                    sSql += ", DataDeValidade AS [D. validade]";
                    sSql += ", ValorCompra AS [V. compra]";
                    sSql += ", Quantidade";
                    sSql += ", Estoque";
                    sSql += ", PrecoUnitario AS [P. Unitário]";
                    sSql += ", PrecoDeVenda AS [P. venda]";
                    sSql += ", Desconto";
                    sSql += ", ValorDesconto AS [V. desconto]";
                    sSql += " FROM [tProdutos] inner join tFornecedores on tProdutos.CodigoDoFornecedor = tFornecedores.CodigoDoFornecedor";
                }
                else
                {
                    if (Filtro != "-1")
                    {
                        sSql = @"SELECT";
                        sSql += "  idProduto";
                        sSql += ", CodigoDeBarras";
                        sSql += ", tFornecedores.CodigoDoFornecedor";
                        sSql += ", tFornecedores.RazaoSocial AS Fornecedor";
                        sSql += ", Produto";
                        sSql += ", DataDeValidade AS [D. validade]";
                        sSql += ", ValorCompra AS [V. compra]";
                        sSql += ", Quantidade";
                        sSql += ", Estoque";
                        sSql += ", PrecoUnitario AS [Unitário]";
                        sSql += ", PrecoDeVenda AS [P. venda]";
                        sSql += ", Desconto";
                        sSql += ", ValorDesconto AS [V. desconto]";
                        sSql += " FROM [tProdutos] inner join tFornecedores on tProdutos.CodigoDoFornecedor = tFornecedores.CodigoDoFornecedor WHERE tProdutos.CodigoDeBarras = @CodigoDeBarras";

                        //sSql = "SELECT  tProdutos.ID_Produto, tProdutos.CodigoDeBarras, tFornecedores.CodigoDoFornecedor, tFornecedores.RazaoSocial AS Fornecedor, tProdutos.Produto, DataDeValidade AS [D. validade], ValorCompra AS [V. compra], Quantidade, Estoque, PrecoUnitario AS [Unitário], PrecoDeVenda AS [P. venda], Desconto, ValorDesconto AS [V. desconto] FROM [tProdutos] inner join tFornecedores on tProdutos.CodigoDoFornecedor = tFornecedores.CodigoDoFornecedor WHERE tProdutos.ID_Produto  = @ID_Produto";
                    }
                }

                ArrayList arr = new ArrayList();
                arr = Cl_Dados.ListarDados(sSql, "CodigoDeBarras", Filtro);
                if (arr != null)
                {
                    List<cl_pProduto> pL = new List<cl_pProduto>();
                    cl_pProduto p = new cl_pProduto();
                    p.ID_Produto = clsGlobal.DeStringParadecimal(arr[0].ToString());
                    p.CodigoDeBarras = string.Format(arr[1].ToString(), "00000000000000");
                    p.CodigoDoFornecedor = clsGlobal.DeStringParadecimal(arr[2].ToString());
                    p.RazaoSocial = arr[3].ToString();
                    p.Produto = arr[4].ToString();
                    p.DataDeValidade = DateTime.Parse(arr[5].ToString());
                    p.ValorCompra = clsGlobal.DeStringParadecimal(arr[6].ToString());
                    p.Quantidade = clsGlobal.DeStringParadecimal(arr[7].ToString());
                    p.Estoque = clsGlobal.DeStringParadecimal(arr[8].ToString());
                    p.PrecoUnitario = clsGlobal.DeStringParadecimal(arr[9].ToString());
                    p.PrecoDeVenda = clsGlobal.DeStringParadecimal(arr[10].ToString());
                    p.Desconto = int.Parse(arr[11].ToString());
                    p.ValorDesconto = clsGlobal.DeStringParadecimal(arr[12].ToString());

                    pL.Add(p);

                    return pL;
                }
                else {return null;}
            }
            catch {
                return null;
            }
        }

        public static void CarregarParaVender(DataGridView dgv, string Filtro = "-1", string FiltrarPorCodigoDeBarras = "-1")
        {
            string sSql = "";
            try
            {
                if (Filtro == "*")
                {
                    sSql = "SELECT";
                    sSql += "  ID_Produto";
                    sSql += ", CodigoDeBarras";
                    sSql += ", Produto";
                    sSql += ", PrecoDeVenda AS [Preco de venda]";
                    sSql += " FROM [tProdutos] inner join tFornecedores on tProdutos.CodigoDoFornecedor = tFornecedores.CodigoDoFornecedor ORDER BY tProdutos.Produto";
                }
                else
                {
                    if (FiltrarPorCodigoDeBarras == "-1")
                    {
                        sSql = "SELECT";
                        sSql += "  ID_Produto";
                        sSql += ", CodigoDeBarras";
                        sSql += ", Produto";
                        sSql += " FROM [tProdutos] inner join tFornecedores on tProdutos.CodigoDoFornecedor = tFornecedores.CodigoDoFornecedor WHERE Produto LIKE '%" + Filtro + "%' ORDER BY tProdutos.Produto";
                    }
                    else
                    {
                        sSql = "SELECT";
                        sSql += "  ID_Produto";
                        sSql += ", CodigoDeBarras";
                        sSql += ", Produto";
                        sSql += " FROM [tProdutos] inner join tFornecedores on tProdutos.CodigoDoFornecedor = tFornecedores.CodigoDoFornecedor WHERE CodigoDeBarras = " + FiltrarPorCodigoDeBarras + " ORDER BY tProdutos.Produto";
                    }
                }
                dgv.DataSource = Cl_Dados.PegarDados(sSql);
                clsGlobal.SetUpDataGridView(dgv);

            }
            catch { }
        }

        public static void CarregarDoEstoque(DataGridView dgv, string Filtro = "-1", string FiltrarPorCodigoDeBarras = "-1")
        {
            string sSql = "";
            try
            {
                if (Filtro == "*")
                {
                    sSql = " SELECT";
                    sSql += " [idEstoque]";//ocultar 0
                    sSql += ",[CodigoDeBarras] as [Código de barras]";//1
                    sSql += ",[Produto] as Produtos";//2
                    sSql += ",[DataDeValidade] as [D. validade]";//3
                    sSql += ",[Quantidade]";//4
                    sSql += ",[ValorCompra] as [V. compra]";//ocultar 5
                    sSql += ",[PrecoUnitario] as [Custo]";//ocultar 6
                    sSql += ",[PrecoDeVenda] as [V. venda]";//7
                    sSql += ",[Estoque]";//8
                    sSql += ",[Desconto]";//9
                    sSql += ",[ValorDesconto] as [V. desconto]";//10
                    sSql += " FROM [tEstoque] ORDER BY tEstoque.Produto";
                }
                else
                {
                    if (FiltrarPorCodigoDeBarras == "-1")
                    {
                        sSql = " SELECT";
                        sSql += " [idEstoque]";
                        sSql += ",[CodigoDeBarras]";
                        sSql += ",[Produto]";
                        sSql += ",[DataDeValidade]";
                        sSql += ",[Quantidade]";
                        sSql += ",[ValorCompra]";
                        sSql += ",[PrecoUnitario]";
                        sSql += ",[PrecoDeVenda]";
                        sSql += ",[Estoque]";
                        sSql += ",[Desconto]";
                        sSql += ",[ValorDesconto]";
                        sSql += " FROM [tEstoque] WHERE Produto LIKE '%" + Filtro + "%' ORDER BY tEstoque.Produto";
                    }
                    else
                    {
                        sSql = " SELECT";
                        sSql += " [idEstoque]";
                        sSql += ",[CodigoDeBarras]";
                        sSql += ",[Produto]";
                        sSql += ",[DataDeValidade]";
                        sSql += ",[Quantidade]";
                        sSql += ",[ValorCompra]";
                        sSql += ",[PrecoUnitario]";
                        sSql += ",[PrecoDeVenda]";
                        sSql += ",[Estoque]";
                        sSql += ",[Desconto]";
                        sSql += ",[ValorDesconto]";
                        sSql += " FROM [tEstoque] WHERE CodigoDeBarras = '" + FiltrarPorCodigoDeBarras + "'";
                    }
                }
                dgv.DataSource = Cl_Dados.PegarDados(sSql);

            }
            catch { }
        }

        public void CarregarCaixaCombo(ComboBox cb, string sItem, string sTabela)
        {
            try
            {
                cb.Items.Clear();
                cb.DataSource = Cl_Dados.PegarArrayListDados("SELECT " + sItem + " FROM " + sTabela);
            }
            catch
            {
            }
        }

        public void Buscar(string Filtro)
        {
            try
            {
                string sSql = String.Concat("SELECT * FROM tProdutos WHERE (CodigoDeBarras = '", Filtro, "')");
                oDs = Cl_Dados.CarregarDataset(sSql, "tProdutos");

                if (Cl_Dados.MaximaPosicao > 0)
                {
                    BaixarDados();
                }
            }
            catch
            {
            }
        }

        public void BuscarFoto(string Filtro)
        {
            try
            {
                string sSql = "SELECT tProdutos.Foto FROM tProdutos WHERE CodigoDeBarras = " + Filtro;
                oDs = Cl_Dados.CarregarDataset(sSql, "tProdutos");

                if (Cl_Dados.MaximaPosicao > 0)
                {
                    BaixarDados();
                }
            }
            catch
            {
            }
        }

        private void BaixarDados()
        {
            foreach (DataRow Linha in oDs.Tables["tProdutos"].Rows)
            {
                //Foto = null;
                //if (Linha["Foto"] != System.DBNull.Value)
                //{
                 //   Foto = Cl_Dados.MontarImage((byte[])Linha["Foto"]);
                //}
            }
        }

        #endregion

    }

}
