using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foto_SanRemo
{
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cadastro_Escola_Click(object sender, EventArgs e)
        {
            Cadastro_Escola chamaCadastroEscolar = new Cadastro_Escola();
            chamaCadastroEscolar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido chamaPedido = new Pedido();
            chamaPedido.ShowDialog();
        }

        private void Btn_Fotografo_Click(object sender, EventArgs e)
        {
            Fotografo chamaFotografo = new Fotografo();
            chamaFotografo.ShowDialog();
        }

        private void Btn_Representante_Click(object sender, EventArgs e)
        {
            Representante chamaRepresentante = new Representante();
            chamaRepresentante.ShowDialog();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
