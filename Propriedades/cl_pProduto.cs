using System;
using System.Drawing;

namespace CasaMendes.Propriedades
{
    public class cl_pProduto
    {
        public decimal ID_Produto { get; set; }
        public string CodigoDeBarras { get; set; }
        public decimal CodigoDoFornecedor { get; set; }
        public string Produto { get; set; }
        public DateTime DataDeValidade { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Estoque { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal PrecoDeVenda { get; set; }
        public int Desconto { get; set; }
        public decimal ValorDesconto { get; set; }
        public string RazaoSocial { get; set; }
        public int CodigoDaNotaFiscal { get; set; }
    }
}
