using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Business
{
    class CompraBusiness
    {
        Database.CompraDatabase db = new Database.CompraDatabase();

        public void Insert (Models.tb_compra compra)
        {
            db.Insert(compra);
        }
        public List<Models.tb_compra> ListarTodos()
        {
            List<Models.tb_compra> lista = db.ListarTodos();
            return lista;
        }
        public void Remover (int id)
        {
            db.Remover(id);
        }
    }
}
