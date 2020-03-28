using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Database
{
    class CompraProdutoItemDatabase
    {
        Models.supermarket_dbEntities1 db = new Models.supermarket_dbEntities1();

        public void Insert (Models.tb_compra_has_tb_produto item)
        {
            db.tb_compra_has_tb_produto.Add(item);
            db.SaveChanges(); 
        }
        public List<Models.tb_compra_has_tb_produto> ListarTodos()
        {
            List<Models.tb_compra_has_tb_produto> lista = db.tb_compra_has_tb_produto.ToList();
            return lista;
        }
    }
}
