using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Business
{
    class ProdutoBusiness
    {
        Database.ProdutoDatabase db = new Database.ProdutoDatabase();

        public void InsertProduto(Models.tb_produto produto)
        {
            db.Insert(produto);
        }
        public List<Models.tb_produto> ListarTodos()
        {
            List<Models.tb_produto> lista = db.ListarTodos();
            return lista;
        }
        public void Alterar(Models.tb_produto produto)
        {
            db.Alterar(produto);
        }
        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
