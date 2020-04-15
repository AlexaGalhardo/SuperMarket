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
    public partial class frmConsultarProduto : Form
    {
        public frmConsultarProduto()
        {
            InitializeComponent();
            CarregarGrid();
        }
        Business.ProdutoBusiness business = new Business.ProdutoBusiness();

        public void CarregarGrid()
        {
            List<Models.tb_produto> lista = business.ListarTodos();

            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.DataSource = lista;
        }
        

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Models.tb_produto model = dgvProdutos.CurrentRow.DataBoundItem as Models.tb_produto;
                UI.Produto.frmProduto tela = new frmProduto();
                tela.CarregarTela(model);
                tela.ShowDialog();
                Hide();
            }
            
            if(e.ColumnIndex == 6)
            {
                Models.tb_produto model = dgvProdutos.CurrentRow.DataBoundItem as Models.tb_produto;
                DialogResult r = MessageBox.Show("Tem certeza que deseja remover?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(r == DialogResult.Yes)
                {
                    business.Remover(model.idtb_produto);
                    MessageBox.Show("Removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
