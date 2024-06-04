using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT6
{
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormInserirEstudante_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonEnviarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarImagem = new OpenFileDialog();
            selecionarImagem.Filter = "selecione a foto (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            selecionarImagem.ShowDialog();
        }

        private void ButtonEnviarFoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog selecionarImagem = new OpenFileDialog();
            selecionarImagem.Filter = "selecione a foto (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            selecionarImagem.ShowDialog();
        }

        private void ButtonCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
