using ProjetoMVCA20.BLL;
using ProjetoMVCA20.DTO;
using ProjetoMVCA20.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMVCA20
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }



        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                tblClienteDTO objcliente = new tblClienteDTO();
                objcliente.Email_cliente = txtEmail.Text.Trim();
                objcliente.Senha_cliente = txtSenha.Text.Trim();
                this.Visible = false;
                tblClienteBLL bllCliente = new tblClienteBLL();
                if (bllCliente.Autenticar(objcliente.Email_cliente, objcliente.Senha_cliente))
                {
                    MessageBox.Show("Cliente Localizado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmUsuarioDados dados = new frmUsuarioDados();
                    dados.ShowDialog();
                    this.Visible = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cliente Não Localizado", "Falho!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Visible = true;
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

        private void lbl_EsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueciSenha senha = new EsqueciSenha();
            senha.ShowDialog();
        }
    }
}