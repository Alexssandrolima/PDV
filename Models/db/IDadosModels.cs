using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaMendes.Modelo
{
    internal interface IDados
    {
        /// <summary>
        /// Retorna o número de registros da tabela
        /// </summary>
        /// <param name="Tabela">Tabela a ser medida</param>
        /// <returns>Inteiro de 32 bits</returns>
        Int32 Count(string Tabela);

        /// <summary>
        /// Escreva na base de dados os valores passados via parâmetros. 
        /// </summary>
        /// <param name="Parametros">Parâmetros</param>
        /// <param name="_sSql">Query</param>
        /// <returns>True or false</returns>
        bool ExecutarQuery(List<String> Parametros = null, string _sSql = null);

        /// <summary>
        /// Ler dados do banco de dados com ou sem parâmetros 
        /// </summary>
        /// <param name="Parametros">Parâmetros</param>
        /// <param name="_sSql">Query</param>
        /// <returns>ArrayList</returns>
        ArrayList Selecionar(List<String> Parametros = null, string _sSql = null);

        /// <summary>
        /// Cadastra um novo registro segundo os valores passados via parâmetros
        /// </summary>
        /// <param name="Parametros">Parâmetros</param>
        /// <param name="_sSql">Query</param>
        /// <returns>True or false</returns>
        bool Cadastrar(List<String> Parametros = null, string _sSql = null);

        /// <summary>
        /// Atualiza registros na base de dados segundo os valores passados via parâmetros.
        /// </summary>
        /// <param name="Parametros">Parâmetros</param>
        /// <param name="_sSql">Query</param>
        /// <returns>True or false</returns>
        bool Atualizar(List<String> Parametros = null, string _sSql = null);

        /// <summary>
        /// Exclui um registro segundo os valores passados via parâmetros.
        /// </summary>
        /// <param name="Parametros">Parâmetros</param>
        /// <param name="_sSql">Query</param>
        /// <returns>True or false</returns>
        bool Excluir(List<String> Parametros = null, string _sSql = null);
    }
}
