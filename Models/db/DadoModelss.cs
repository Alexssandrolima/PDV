
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Data.Common;
using System.Linq;
using DocumentFormat.OpenXml.Wordprocessing;
//using CasaMendes.Properties;

namespace CasaMendes.Modelo
{
    //Esta classe recebeu o modificador static, portanto, não pode se instãnciada.
    public abstract class ClsDados
    {
        ////======================================================================================================
        //#region Variáveis

        //private Settings settings = new Settings();
        //private readonly string sConn = "";
        ////======================================================================================================
        //private SqlConnection oConexao;
        //private SqlCommand oComando;
        //private SqlDataAdapter oDa;
        //private SqlDataReader oDr;
        //private SqlTransaction oTransacao;

        //private string path = Application.StartupPath;
        //[System.ComponentModel.SettingsBindable(true)]
        //public string ConnectionString => @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "\\Models\\db\\Pdv.mdf;Integrated Security=True";
        //// "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="F:\Projects\PDV Casa Mendes - novo\Modelo\db\CasaMDBase.mdf";Integrated Security=True";
        ////======================================================================================================

        //#endregion Fim da região das vriáveis

        ////======================================================================================================
        //#region CRUD
        ////C - inserir
        ////R - selecionar
        ////U - atualizar
        ////D - deletar

        ////======================================================================================================
        //public void Novo(string sSql)
        //{
        //    try
        //    {
        //        oConexao = new SqlConnection();
        //        oConexao.ConnectionString = sConn;
        //        oConexao.Open();
        //        oComando = new SqlCommand(sSql, oConexao);
        //        oTransacao = oConexao.BeginTransaction();
        //        oComando.Transaction = oTransacao;

        //        oComando.ExecuteNonQuery();
        //        oTransacao.Commit();
        //        oComando.Dispose();
        //        oTransacao.Dispose();
        //        oConexao.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        oTransacao.Rollback();
        //        oComando.Dispose();
        //        oTransacao.Dispose();
        //        oConexao.Dispose();
        //        throw new Exception(ex.Message);
        //    }
        //}

        ////======================================================================================================
        //public void Atualizar(string sSql)
        //{
        //    try
        //    {
        //        oConexao = new SqlConnection();
        //        oConexao.ConnectionString = sConn;
        //        oConexao.Open();
        //        oComando = new SqlCommand(sSql, oConexao);
        //        oTransacao = oConexao.BeginTransaction();
        //        oComando.Transaction = oTransacao;

        //        oComando.ExecuteNonQuery();
        //        oTransacao.Commit();
        //        oComando.Dispose();
        //        oTransacao.Dispose();
        //        oConexao.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        oTransacao.Rollback();
        //        oComando.Dispose();
        //        oTransacao.Dispose();
        //        oConexao.Dispose();
        //        throw new Exception(ex.Message);
        //    }
        //}

        ////======================================================================================================
        //public void Excluir(string sSql)
        //{
        //    try
        //    {
        //        oConexao = new SqlConnection();
        //        oConexao.ConnectionString = sConn;
        //        oConexao.Open();
        //        oComando = new SqlCommand(sSql, oConexao);
        //        oTransacao = oConexao.BeginTransaction();
        //        oComando.Transaction = oTransacao;

        //        oComando.ExecuteNonQuery();
        //        oTransacao.Commit();
        //        oComando.Dispose();
        //        oTransacao.Dispose();
        //        oConexao.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        oTransacao.Rollback();
        //        oComando.Dispose();
        //        oTransacao.Dispose();
        //        oConexao.Dispose();
        //        throw new Exception(ex.Message);
        //    }
        //}

        ////======================================================================================================
        //public ArrayList Selecionar(string sSql)
        //{
        //    ArrayList arr = new ArrayList();
        //    try
        //    {
        //        using (oConexao = new SqlConnection(settings.CasaMendesConnectionString))
        //        {
        //            oConexao.Open();

        //            oComando = new SqlCommand(sSql, oConexao);
        //            oDr = oComando.ExecuteReader();
        //            while (oDr.HasRows)
        //            {
        //                while (oDr.Read())
        //                {
        //                    for (int i = 0; i < oDr.FieldCount; i++)
        //                    {
        //                        string x = oDr.GetValue(0).ToString();
        //                        if (x == null) continue;
        //                        arr.Add(x);
        //                    }
        //                }
        //                oDr.NextResult();
        //            }
        //        }
        //    }
        //    catch (Exception ex)//(ex.Message);
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        oConexao.Close();
        //        oComando.Dispose();
        //        oConexao.Dispose();
        //    }
        //    return arr;
        //}

        //#endregion Fim da região, manutenção de dados.

    }

}