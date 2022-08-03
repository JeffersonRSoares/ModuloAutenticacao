using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAutenticacao.Desktop
{
    public partial class TelaCadUsuario : Form
    {
        public TelaCadUsuario()
        {
            InitializeComponent();
        }

        private void TelaCadUsuario_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtLogin.Enabled = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("O leave foi acionado");
            txtLogin.Text = "O Leave foi acionado";
            txtLogin.BackColor = Color.Red;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TelaNivel().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
