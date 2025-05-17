using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_UC_12
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fonnecedor = new Fornecedor();
            fonnecedor.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Produto produtos = new Produto();
            produtos.ShowDialog();
        }


        private void btnPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.ShowDialog();
        }

        private void btnItensPedido_Click(object sender, EventArgs e)
        {
            ItensPedido itens = new ItensPedido();
            itens.ShowDialog();
        }
    }
}
