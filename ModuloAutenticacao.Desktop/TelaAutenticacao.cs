using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloAutenticacao.Classes;

namespace ModuloAutenticacao.Desktop
{
    public partial class TelaAutenticacao : Form
    {
        public TelaAutenticacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaAutenticacao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Login = textLogin.Text;
            usuario.Senha = textSenha.Text;
            if (usuario.Login.Equals(""))
            {
                MessageBox.Show("Login obrigatório");
                textLogin.Focus();
            } else if (usuario.Senha.Equals(""))
            { 
                MessageBox.Show("Senha obrigatório");
                textSenha.Focus();
            }
            else {
                    MessageBox.Show($"Seja Bem Vindo {usuario.Login}!");
                    TelaCadUsuario tcu=new TelaCadUsuario();
                    tcu.Show();
            }
        }

        private void textlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
