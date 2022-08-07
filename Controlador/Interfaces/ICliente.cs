using CasaMendes.Classes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CasaMendes.Controlador.Interfaces
{
    public interface ICliente : IDisposable//, IEnumerable<IClienteProp>
    {
        /*
         * Construtor Cliente<Cliente>
         * Dados
         * validar dados<Cliente>
         * atribuir dados<Cliente>
         * 
         *    CRUD
         * Criar     insert<Cliente>
         * Ler       select<string nome>
         * Atualizar update<Cliente>
         * Apagar    delete<Cliente>
         * 
        */

        Boolean ValidarDados(ClienteProp cliente);
        Boolean AtribuirDados(ClienteProp cliente);

        //Criar
        Boolean Inserir(ClienteProp cliente);
        //Ler 
        void Selecionar(string sSql, ref ArrayList arr);
        //Atualizar 
        void Atualizar(ClienteProp cliente);
        //Apagar 
         void Deletar(ClienteProp cliente);
    }
}
