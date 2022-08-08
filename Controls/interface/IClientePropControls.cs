using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaMendes.Controlador.Interfaces
{
  public interface IClientePropControls
    {
        int Codigo { get; set; }
        string Nome { get; set; }
        string Endereco { get; set; }
        int Cep { get; set; }
        string Cidade { get; set; }
        string Bairro { get; set; }
        string Estado { get; set; }
        string Pais { get; set; }
        DateTime DataNascimento { get; set; }
        Boolean Status { get; set; }
    }
}
