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
    public partial class TelaNivel : Form
    {
        public TelaNivel()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Inserir(txtNome.Text));
            CarregarTabelaNivel();
        }

        private void TelaNivel_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            CarregarNivel();
        }

        private void CarregarTabelaNivel()
        {
            NivelDAO nivelPesquisa = new NivelDAO();
            dgvNivel.DataSource = nivelPesquisa.Pesquisar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NivelDAO nivelPesquisa = new NivelDAO();
            dgvNivel.DataSource = nivelPesquisa.PesquisarPorNome(txtNome.Text);

            if (txtNome.Text.Equals(""))
            {

                CarregarNivel();
                txtID.Clear();
            }
        }

       

        private void CarregarNivel()
        {
            NivelDAO nivelPesquisa = new NivelDAO();
            dgvNivel.DataSource = nivelPesquisa.Pesquisar();
        }



        private void dgvNivel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dgvNivel.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvNivel.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            NivelDAO nivel = new NivelDAO();
            MessageBox.Show(nivel.Deletar(txtID.Text));
            CarregarNivel();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
}


