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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancelarAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair sem salvar?", "Confirmação", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //
            }
            else
            {
                this.Close();
            }
            
        }

        private void lbModelo_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection();

            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO pessoa (id, cpf, nome, sexo, rua, bairro, numero, cep, cidade, uf)", conn);
            cmd.Parameters.AddWithValue("cpf", txtCpf.Text.Trim());
            cmd.Parameters.AddWithValue("nome", txtNome.Text.Trim());
            cmd.Parameters.AddWithValue("sexo", rbtnFem.Name.Trim());
            cmd.Parameters.AddWithValue("sexo", rbtnMasc.Name.Trim());
            cmd.Parameters.AddWithValue("rua", txtRua.Text.Trim());
            cmd.Parameters.AddWithValue("bairro", txtBairro.Text.Trim());
            cmd.Parameters.AddWithValue("numero", txtNro.Text.Trim());
            cmd.Parameters.AddWithValue("cep", txtCep.Text.Trim());
            cmd.Parameters.AddWithValue("cidade", txtCidade.Text.Trim());
            cmd.Parameters.AddWithValue("uf", txtUf.Text.Trim());
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente salvo com sucesso!");
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar registro: " + ex.Message);
            }
        }
    }
}
