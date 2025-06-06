﻿using Atividade_UC_12.DubrasaSkateDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Atividade_UC_12.DubrasaSkateDataSet;


namespace Atividade_UC_12
{
    public partial class ItensPedido: Form
    {
        private void atualizarBanco()
        {
            lboDadosItensPedido.Items.Clear();
            ItensPedidoTableAdapter itensPedido = new ItensPedidoTableAdapter();
            var dados = from linha in itensPedido.GetData() select linha;

            foreach (var item in dados)
            {
                lboDadosItensPedido.Items.Add(item);
            }
        }

        private void limparcampos()
        {
            txtID.Clear();
            txtIDProduto.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtIdPedido.Clear();
        }

        public ItensPedido()
        {
            InitializeComponent();
            atualizarBanco();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)
              && string.IsNullOrEmpty(txtIdPedido.Text) && string.IsNullOrEmpty(txtQuantidade.Text) && string.IsNullOrEmpty(txtPreco.Text)
              && string.IsNullOrEmpty(txtIDProduto.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ItensPedidoTableAdapter itensPedido = new ItensPedidoTableAdapter();
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            int idProduto = Convert.ToInt32(txtIDProduto.Text);
            int idPedido = Convert.ToInt32(txtIdPedido.Text);
            decimal preco = Convert.ToDecimal(txtPreco.Text);
            itensPedido.Insert(idProduto, idPedido, preco, quantidade);
            atualizarBanco();
            limparcampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lboDadosItensPedido.SelectedItem == null)
            {
                MessageBox.Show("Selecione qual campo sera excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ItensPedidoRow excluiritemPedido = lboDadosItensPedido.SelectedItem as ItensPedidoRow;
            ItensPedidoTableAdapter itensPedido = new ItensPedidoTableAdapter();


            itensPedido.Delete(excluiritemPedido.Id_itensPedido, excluiritemPedido.Id_produto, excluiritemPedido.Id_pedido, excluiritemPedido.Preco, excluiritemPedido.Quantidade);
            atualizarBanco();
            limparcampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (lboDadosItensPedido.SelectedItem == null)
            {
                MessageBox.Show("Selecione qual elemento você quer atualizar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            ItensPedidoRow dadosAtualizar = lboDadosItensPedido.SelectedItem as ItensPedidoRow;
            ItensPedidoTableAdapter atualizar = new ItensPedidoTableAdapter();

            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            int idProduto = Convert.ToInt32(txtIDProduto.Text);
            int idPedido = Convert.ToInt32(txtIdPedido.Text);
            decimal preco = Convert.ToDecimal(txtPreco.Text);
            // Atualizando os dados 
            dadosAtualizar.Id_pedido = idPedido;
            dadosAtualizar.Quantidade = quantidade;
            dadosAtualizar.Id_produto = idProduto;
            dadosAtualizar.Preco = preco;
            atualizar.Update(dadosAtualizar);
            atualizarBanco();
            limparcampos();

            MessageBox.Show("Atualizado com sucesso", "PRONTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)
              && string.IsNullOrEmpty(txtIdPedido.Text) && string.IsNullOrEmpty(txtQuantidade.Text) && string.IsNullOrEmpty(txtPreco.Text)
              && string.IsNullOrEmpty(txtIDProduto.Text))
            {
                MessageBox.Show("Não ha campos para limpar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            limparcampos();
            atualizarBanco();
        }

        private void lboDadosItensPedido_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lboDadosItensPedido.SelectedItem == null) return;
            ItensPedidoRow itensPedido = lboDadosItensPedido.SelectedItem as ItensPedidoRow;
            txtID.Text = itensPedido.Id_itensPedido.ToString();
            txtIdPedido.Text = itensPedido.Id_pedido.ToString();
            txtIDProduto.Text = itensPedido.Id_produto.ToString();
            txtPreco.Text = itensPedido.Preco.ToString();
            txtQuantidade.Text = itensPedido.Quantidade.ToString();
        }
    }
}
