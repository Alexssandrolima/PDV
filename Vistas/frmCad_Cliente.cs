
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using CasaMendes.Controlador;

namespace CasaMendes.Vistas
{
    public partial class frmCad_Cliente : Form
    {
        public frmCad_Cliente()
        {
            InitializeComponent();
        }

        #region Instancias
        private Cliente oCliente = new Cliente();
        #endregion Fim de instancias

        private void frmCad_Cliente_Load(object sender, System.EventArgs e)
        {
            try
            {
                ArrayList arr = new ArrayList();
                oCliente.Selecionar("select * from Teste", ref arr);
                if (arr.Count > 0)
                {
                    this.DgvClientes.AutoGenerateColumns = true;
                    this.DgvClientes.DataSource = arr;
                }
            }
            catch { }
        }

        private void BtnExcluir_Click(object sender, System.EventArgs e)
        {
            //oCliente.Connect("SECECT * FROM artigos");
        }
    }
}
