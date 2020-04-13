using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Database
{
    class CompraDatabase
    {
        Models.supermarket_dbEntities2 db = new Models.supermarket_dbEntities2();

        public void Insert (Models.tb_compra compra)
        {
            db.tb_compra.Add(compra);
            db.SaveChanges();
        }
        public List<Models.tb_compra> ListarTodos()
        {
            List<Models.tb_compra> lista = db.tb_compra.ToList();
            return lista;
        }
        public void Remover (int id)
        {
            Models.tb_compra remover = db.tb_compra.First
                (t => t.idtb_compra == id);
            db.tb_compra.Remove(remover);
        }


    }
}
