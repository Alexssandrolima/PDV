using CasaMendes.Classes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CasaMendes.Controlador.Interfaces
{
    public interface IClienteControls : IDisposable//, IEnumerable<IClienteProp>
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

        Boolean ValidarDados(ClientePropControls cliente);
        Boolean AtribuirDados(ClientePropControls cliente);

        //Criar
        Boolean Inserir(ClientePropControls cliente);
        //Ler 
        void Selecionar(string sSql, ref ArrayList arr);
        //Atualizar 
        void Atualizar(ClientePropControls cliente);
        //Apagar 
         void Deletar(ClientePropControls cliente);
    }
}
