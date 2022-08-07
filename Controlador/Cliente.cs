using CasaMendes.Controlador.Interfaces;
using CasaMendes.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CasaMendes.Controlador
{
    public sealed class Cliente : ClsDados, ICliente
    {
        private ClienteProp pCliente;
        public Cliente()
        {
        }

        public Cliente(ClienteProp cliente)
        {
            pCliente = cliente;
        }

        ~Cliente() => Dispose();

        public bool AtribuirDados(ClienteProp cliente)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(ClienteProp cliente)
        {
            throw new NotImplementedException();
        }

        public void Deletar(ClienteProp cliente)
        {
            throw new NotImplementedException();
        }

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }

        public bool Inserir(ClienteProp cliente)
        {
            throw new NotImplementedException();
        }

        public void Selecionar(string sSql,ref ArrayList arr)
        {
            try
            {
                arr = Selecionar(sSql);
            }
            catch (Exception ex)//(ex.Message);
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool ValidarDados(ClienteProp cliente)
        {
            throw new NotImplementedException();
        }
    }
}
