using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.UI.Produto
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }
        Business.ProdutoBusiness business = new Business.ProdutoBusiness();
        Models.tb_produto prodModel = new Models.tb_produto();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (prodModel != null && prodModel.idtb_produto > 0)
            {
                this.Alterar();
            }
            else
            {
                this.Inserir();
            }
        }
        public void Inserir()
        {
            prodModel = new Models.tb_produto();
            
            prodModel.ds_origem = cboOrigem.Text;
            prodModel.dt_fabricacao = dtpFabricação.Value;
            prodModel.dt_validade = dtpValidade.Value;
            prodModel.nm_produto = txtProduto.Text;
            prodModel.vl_venda = Convert.ToDouble(txtValorVenda.Text);
            business.InsertProduto(prodModel);

            DialogResult d = MessageBox.Show("Produto cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void Alterar()
        {
            prodModel.idtb_produto = prodModel.idtb_produto;
            prodModel.ds_origem = cboOrigem.Text;
            prodModel.dt_fabricacao = dtpFabricação.Value;
            prodModel.dt_validade = dtpValidade.Value;
            prodModel.nm_produto = txtProduto.Text;
            prodModel.vl_venda = Convert.ToDouble(txtValorVenda.Text);

            business.Alterar(prodModel);
            DialogResult d = MessageBox.Show("Produto alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void CarregarTela(Models.tb_produto produto)
        {
            prodModel = new Models.tb_produto();
            double venda = Convert.ToDouble(txtValorVenda.Text);

            txtProduto.Text = produto.nm_produto;
            venda = produto.vl_venda;
            cboOrigem.Text = produto.ds_origem;
            dtpFabricação.Value = produto.dt_fabricacao;
            dtpValidade.Value = produto.dt_validade;
            prodModel.idtb_produto = produto.idtb_produto;

            prodModel = produto;
        }
        public void LimparCampos()
        {
            dtpFabricação.Value = DateTime.Now;
            dtpValidade.Value = DateTime.Now;
            txtProduto.Text = string.Empty;
            txtValorVenda.Text = string.Empty;
            cboOrigem.Text = "Selecione";
        }

        
    }
}
