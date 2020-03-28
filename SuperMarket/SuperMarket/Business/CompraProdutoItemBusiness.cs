using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Business
{
    class CompraProdutoItemBusiness
    {
        Database.CompraProdutoItemDatabase db = new Database.CompraProdutoItemDatabase();
        public void Insert (Models.tb_compra_has_tb_produto item)
        {
            db.Insert(item);
        }
        public List<Models.tb_compra_has_tb_produto> ListarTodos()
        {
            List<Models.tb_compra_has_tb_produto> lista = db.ListarTodos();
            return lista;
        }
    }
}
