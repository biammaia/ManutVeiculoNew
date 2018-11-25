using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace manutVeiculo
{
    public partial class ConsultaCliente : Form
    {
        private PessoaDAO pessoadao = new PessoaDAO();
        List<Pessoa> lista_pessoa;
        private Pessoa p;

        public ConsultaCliente()
        {
            InitializeComponent();
        }

        public ConsultaCliente(String cpf)
        {
            InitializeComponent();
            txtNome.Text = "";
            rbtnMasc.Checked = false;
            rbtnFem.Checked = false;
            txtTelefone.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtNro.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            lista_pessoa = pessoadao.ListAll();
            btnConfirm.Visible = true;
        }

        private void btnCancelCli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar essa operação?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //
            }
            else
            {
                this.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarCli_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastroCliente = new CadastrarCliente();
            adiciona_paciente.ShowDialog();
            if (adiciona_paciente.adicionou())
            {
                grid_pacientes.DataSource = pacientedao.ListAll();
                MessageBox.Show("Cadastro Alterado com sucesso!");
            }

        }
    }
}
