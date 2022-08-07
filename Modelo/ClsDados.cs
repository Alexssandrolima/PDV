
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Data.Common;
using System.Linq;
using CasaMendes.Properties;

namespace CasaMendes.Modelo
{
    //Esta classe recebeu o modificador static, portanto, não pode se instãnciada.
    public abstract class ClsDados
    {
        //======================================================================================================
        #region Variáveis

        private Settings settings = new Settings();
        //======================================================================================================
        private SqlConnection oConexao;
        private SqlCommand oComando;
        private SqlDataAdapter oDa;
        private SqlDataReader oDr;
        private SqlTransaction oTransacao;

        string path = Application.StartupPath;
        [System.ComponentModel.SettingsBindable(true)]
        public string ConnectionString => @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "\\Modelo\\db\\CasaMDBase.mdf;Integrated Security=True";
        //                                 "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="F:\Projects\PDV Casa Mendes - novo\Modelo\db\CasaMDBase.mdf";Integrated Security=True";
        //======================================================================================================

        #endregion Fim da região das vriáveis

        //======================================================================================================
        #region CRUD
        string sConn = "";
        //======================================================================================================
        public void Novo(string sSql)
        {
            try
            {
                oConexao = new SqlConnection();
                oConexao.ConnectionString = sConn;
                oConexao.Open();
                oComando = new SqlCommand(sSql, oConexao);
                oTransacao = oConexao.BeginTransaction();
                oComando.Transaction = oTransacao;

                oComando.ExecuteNonQuery();
                oTransacao.Commit();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
            }
            catch (Exception ex)
            {
                oTransacao.Rollback();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
                throw new Exception(ex.Message);
            }
        }

        //======================================================================================================
        public void Atualizar(string sSql)
        {
            try
            {
                oConexao = new SqlConnection();
                oConexao.ConnectionString = sConn;
                oConexao.Open();
                oComando = new SqlCommand(sSql, oConexao);
                oTransacao = oConexao.BeginTransaction();
                oComando.Transaction = oTransacao;

                oComando.ExecuteNonQuery();
                oTransacao.Commit();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
            }
            catch (Exception ex)
            {
                oTransacao.Rollback();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
                throw new Exception(ex.Message);
            }
        }

        //======================================================================================================
        public void Excluir(string sSql)
        {
            try
            {
                oConexao = new SqlConnection();
                oConexao.ConnectionString = sConn;
                oConexao.Open();
                oComando = new SqlCommand(sSql, oConexao);
                oTransacao = oConexao.BeginTransaction();
                oComando.Transaction = oTransacao;

                oComando.ExecuteNonQuery();
                oTransacao.Commit();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
            }
            catch (Exception ex)
            {
                oTransacao.Rollback();
                oComando.Dispose();
                oTransacao.Dispose();
                oConexao.Dispose();
                throw new Exception(ex.Message);
            }
        }

        //======================================================================================================
        public ArrayList Selecionar(string sSql)
        {
            ArrayList arr = new ArrayList();
            try
            {
                using (oConexao = new SqlConnection(settings.CasaMendesConnectionString))
                {
                    oConexao.Open();

                    oComando = new SqlCommand(sSql, oConexao);
                    oDr = oComando.ExecuteReader();
                    while (oDr.HasRows)
                    {
                        while (oDr.Read())
                        {
                            for (int i = 0; i < oDr.FieldCount; i++)
                            {
                                string x = oDr.GetValue(0).ToString();
                                if (x == null) continue;
                                arr.Add(x);
                            }
                        }
                        oDr.NextResult();
                    }

                    //    while (reader.HasRows)
                    //{
                    //    Console.WriteLine("\t{0}\t{1}", reader.GetName(0),
                    //    reader.GetName(1));
                    //    // Obtain a row from the query result.
                    //    while (reader.Read())
                    //    {
                    //        Console.WriteLine("\t{0}\t{1}", reader.GetInt32(0),
                    //        reader.GetString(1));
                    //    }
                    //    // Hop to the next result-set.
                    //    reader.NextResult();
                    //}

                }
            }
            catch (Exception ex)//(ex.Message);
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                oConexao.Close();
                oComando.Dispose();
                oConexao.Dispose();
            }
            return arr;
        }

        private static void CreateCommand(string queryString, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        static public int AddProductCategory(string newName, string connString)
        {
            Int32 newProdID = 0;
            string sql = "INSERT INTO Production.ProductCategory (Name) VALUES (@Name); SELECT CAST(scope_identity() AS int)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = newName;
                try
                {
                    conn.Open();
                    newProdID = (Int32)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return (int)newProdID;
        }

        static public void CriarProcedimentos()
        {
            // Assumes connection is a valid SqlConnection.
            //string queryString = "CREATE PROCEDURE InsertCategory " +
            //"@CategoryName nchar(15), " +
            //"@Identity int OUT " +
            //"AS " +
            //"INSERT INTO Categories (CategoryName) VALUES(@CategoryName) " +
            //"SET @Identity = @@Identity " +
            //"RETURN @@ROWCOUNT";
            //SqlCommand command = new SqlCommand(queryString, connection);
            //command.ExecuteNonQuery();
        }

        static void HasRows(SqlConnection connection)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand(
                "SELECT CategoryID, CategoryName FROM Categories;",
                connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                // Check if the DataReader has any row.
                if (reader.HasRows)
                {
                    // Obtain a row from the query result.
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                        reader.GetString(1));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                // Always call the Close method when you have finished using the DataReader object.
                reader.Close();
            }
        }

        static void RetrieveMultipleResults(SqlConnection connection)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand(
                "SELECT ID, Nome, Descricao FROM dbo.Categories;" +
                "SELECT EmployeeID, LastName FROM dbo.Employees",
                connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                // Check if the DataReader has any row.
                while (reader.HasRows)
                {
                    Console.WriteLine("\t{0}\t{1}", reader.GetName(0),
                    reader.GetName(1));
                    // Obtain a row from the query result.
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}", reader.GetInt32(0),
                        reader.GetString(1));
                    }
                    // Hop to the next result-set.
                    reader.NextResult();
                }
                // Always call the Close method when you have finished using the DataReader object.
                reader.Close();
            }
        }

        static void GetSchemaInfo(SqlConnection connection)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand(
                "SELECT CategoryID, CategoryName FROM Categories;",
                connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                // Retrieve schema information about the current result-set.
                DataTable schemaTable = reader.GetSchemaTable();
                foreach (DataRow row in schemaTable.Rows)
                {
                    foreach (DataColumn column in schemaTable.Columns)
                    {
                        Console.WriteLine(String.Format("{0} = {1}",
                        column.ColumnName, row[column]));
                    }
                }
                // Always call the Close method when you have finished using the DataReader object.
                reader.Close();
            }
        }

        static public void VariosDataSetes(string customerConnection, string orderConnection)
        { // Assumes that customerConnection and orderConnection are valid SqlConnection objects.
            SqlDataAdapter custAdapter = new SqlDataAdapter(
            "SELECT * FROM dbo.Customers", customerConnection);
            SqlDataAdapter ordAdapter = new SqlDataAdapter(
            "SELECT * FROM Orders", orderConnection);
            DataSet customerOrders = new DataSet();
            custAdapter.Fill(customerOrders, "Customers");
            ordAdapter.Fill(customerOrders, "Orders");
            DataRelation relation = customerOrders.Relations.Add("CustOrders",
            customerOrders.Tables["Customers"].Columns["CustomerID"],
            customerOrders.Tables["Orders"].Columns["CustomerID"]);
            foreach (DataRow pRow in customerOrders.Tables["Customers"].Rows)
            {
                Console.WriteLine(pRow["CustomerID"]);
                foreach (DataRow cRow in pRow.GetChildRows(relation))
                    Console.WriteLine("\t" + cRow["OrderID"]);
            }
        }

        private static void AdapterUpdate(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdpater = new SqlDataAdapter(
                "SELECT CategoryID, CategoryName FROM Categories",
                connection);
                dataAdpater.UpdateCommand = new SqlCommand(
                "UPDATE Categories SET CategoryName = @CategoryName " +
                "WHERE CategoryID = @CategoryID", connection);
                dataAdpater.UpdateCommand.Parameters.Add(
                "@CategoryName", SqlDbType.NVarChar, 15, "CategoryName");
                SqlParameter parameter = dataAdpater.UpdateCommand.Parameters.Add(
                "@CategoryID", SqlDbType.Int);
                parameter.SourceColumn = "CategoryID";
                parameter.SourceVersion = DataRowVersion.Original;
                DataTable categoryTable = new DataTable();
                dataAdpater.Fill(categoryTable);
                DataRow categoryRow = categoryTable.Rows[0];
                categoryRow["CategoryName"] = "New Beverages";
                dataAdpater.Update(categoryTable);
                Console.WriteLine("Rows after update.");
                foreach (DataRow row in categoryTable.Rows)
                {
                    {
                        Console.WriteLine("{0}: {1}", row[0], row[1]);
                    }
                }
            }
        }

        #endregion Fim da região, manutenção de dados.

        private static void CopiarData(DataSet dataSet, String connectionString, SqlCommand selectCommand, DataTableMapping[] tableMappings)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                selectCommand.Connection = connection;
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                {
                    adapter.TableMappings.AddRange(tableMappings);
                    // If set the AcceptChangesDuringFill as the false, AcceptChanges will not be called on a
                    // DataRow after it is added to the DataTable during any of the Fill operations.
                    adapter.AcceptChangesDuringFill = false;
                    adapter.Fill(dataSet);
                }
            }
        }

        // Roll back only one column or several columns data of the Course table by call ResetDataTable method.
        private static void ResetCourse(DataTable table, String connectionString,DataColumn[] primaryColumns, DataColumn[] resetColumns)
        {
            table.PrimaryKey = primaryColumns;
            // Build the query string
            String primaryCols = String.Join(",", primaryColumns.Select(col => col.ColumnName));
            //String resetCols = String.Join(",", resetColumns.Select(col => $"Max({col.ColumnName}) as { col.ColumnName}"));
            String selectString = $"Select {primaryCols}, from Teste Group by {primaryCols}";
            SqlCommand selectCommand = new SqlCommand(selectString);
            ResetDataTable(table, connectionString, selectCommand);
        }

        // RejectChanges will roll back all changes made to the table since it was loaded, or the last time  AcceptChanges
        // was called. When you copy from the database, you can lose all the data after calling RejectChanges
        // The ResetDataTable method rolls back one or more columns of data.
        private static void ResetDataTable(DataTable table, String connectionString, SqlCommand selectCommand)
        {
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    selectCommand.Connection = connection;
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
                    {
                        // The incoming values for this row will be written to the current version of each
                        // column. The original version of each column's data will not be changed.
                        adapter.FillLoadOption = LoadOption.Upsert;
                        adapter.Fill(table);
                    }
                }
            }
        }

        private static void BatchInsertUpdate(DataTable table, String connectionString, SqlCommand insertCommand, Int32 batchSize)
        {
           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               insertCommand.Connection = connection;
               // When setting UpdateBatchSize to a value other than 1, all the commands
               // associated with the SqlDataAdapter have to have their UpdatedRowSource
               // property set to None or OutputParameters. An exception is thrown otherwise.
               insertCommand.UpdatedRowSource = UpdateRowSource.None;
               connection.Open();
              using (SqlDataAdapter adapter = new SqlDataAdapter())
              {
                 adapter.InsertCommand = insertCommand;
                   // Gets or sets the number of rows that are processed in each round-trip to the server.
                   // Setting it to 1 disables batch updates, as rows are sent one at a time.
                   adapter.UpdateBatchSize = batchSize;
                   adapter.Update(table);
                   Console.WriteLine("Successfully to update the table.");
              }
           }
        }

        private static void ShowDataTable(DataTable table)
        {
            foreach (DataColumn col in table.Columns)
            {
                Console.Write("{0,-14}", col.ColumnName);
            }
            Console.WriteLine("{0,-14}", "RowState");
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn col in table.Columns)
                {
                    if (col.DataType.Equals(typeof(DateTime)))
                        Console.Write("{0,-14:d}", row[col]);
                    else if (col.DataType.Equals(typeof(Decimal)))
                        Console.Write("{0,-14:C}", row[col]);
                    else
                        Console.Write("{0,-14}", row[col]);
                }
                Console.WriteLine("{0,-14}", row.RowState);
            }
        }

    }

}


/*
 * Rstudio e Pytho com sqlserver
 * Página: 810
*
* --insert into Teste(nome) values('Pedro');
* --insert into Teste(nome) values('Carlos');
* --insert into Teste(nome,descricao) values('Paulo', 'Teste de inserção de dados N: 3');
* --insert into Teste(nome,descricao) values('João', 'Teste de inserção de dados N: 4');
* --insert into Teste(nome,descricao) values('José', 'Teste de inserção de dados N: 5');
* --insert into Teste(nome,descricao) values('Marcos', 'Teste de inserção de dados N4: 6');
*   select * from Teste
*   
*   insert into TabelaRelacao(IdTeste,relacao) values(1,'Pedro');
*   insert into TabelaRelacao(IdTeste,relacao) values(3, 'Carlos');
*   insert into TabelaRelacao(IdTeste,relacao) values(2, 'Teste de inserção de dados N: 3');
*   insert into TabelaRelacao(IdTeste,relacao) values(4,'Teste de inserção de dados N: 4');
*   insert into TabelaRelacao(IdTeste,relacao) values(6, 'Teste de inserção de dados N: 5');
*   insert into TabelaRelacao(IdTeste,relacao) values(5,'Teste de inserção de dados N4: 6');
*   select * from TabelaRelacao 
*/
