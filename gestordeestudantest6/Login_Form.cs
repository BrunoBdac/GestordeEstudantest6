using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorDeEstudantesT6
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {                
                MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();
                MySqlDataAdapter meuAdaptadorSql = new MySqlDataAdapter();
                DataTable minhaTabela = new DataTable();
                MySqlCommand meuComandoSql = new MySqlCommand("SELECT * FROM `usuários` WHERE `nome_do_usuário` = @usuario AND `senha` = @senha", meuBancoDeDados.getConexao);

                meuComandoSql.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = textBoxUsuario.Text;
                meuComandoSql.Parameters.Add("@senha", MySqlDbType.VarChar).Value = textBoxSenha.Text;

                meuAdaptadorSql.SelectCommand = meuComandoSql;

            meuAdaptadorSql.Fill(minhaTabela);
            if (minhaTabela.Rows.Count > 0)
            {
               // MessageBox.Show("Existem dados!");
               this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos", 
                    "erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBoxUsuario_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
