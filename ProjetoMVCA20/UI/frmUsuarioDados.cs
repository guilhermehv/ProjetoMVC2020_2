using ProjetoMVCA20.BLL;
using ProjetoMVCA20.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMVCA20.UI
{
    public partial class frmUsuarioDados : Form
    {
        public frmUsuarioDados()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                tblClienteDTO objcliente = new tblClienteDTO();
                objcliente.Cpf_cliente = txtCpfA20.Text.Trim();
                objcliente.Nome_cliente = txtNomeA20.Text.Trim();
                objcliente.Nome_mae = txtNomeMaeA20.Text.Trim();
                tblClienteBLL bllCliente = new tblClienteBLL();

                if (bllCliente.VerificarDados(objcliente.Nome_cliente, objcliente.Cpf_cliente, objcliente.Nome_mae))
                {
                    MessageBox.Show("Beneficiário Localizado no Banco de dados.", "Processo em Análise", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Beneficiário Não Localizado no Banco de dados.", "Benefício Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
