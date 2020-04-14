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
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
        public void Inserir()
        {
            Models.tb_produto produto = new Models.tb_produto();
            produto.ds_origem = cboOrigem.Text;
            produto.dt_fabricacao = dtpFabricação.Value;
            produto.dt_validade = dtpValidade.Value;
            produto.nm_produto = txtProduto.Text;
            produto.vl_venda = Convert.ToDouble(txtValorVenda.Text);
        }
        int id = 0;
        public void Alterar(Models.tb_produto produto)
        {
            id = produto.idtb_produto;
            produto.ds_origem = cboOrigem.Text;
            produto.dt_fabricacao = dtpFabricação.Value;
            produto.dt_validade = dtpValidade.Value;
            produto.nm_produto = txtProduto.Text;
            produto.vl_venda = Convert.ToDouble(txtValorVenda.Text);
        }
    }
}
