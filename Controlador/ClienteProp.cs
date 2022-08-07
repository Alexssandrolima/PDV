using CasaMendes.Controlador.Interfaces;
using System;

namespace CasaMendes.Controlador
{
    public sealed class ClienteProp : IClienteProp
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Cep { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Status { get; set; }

    }
}
