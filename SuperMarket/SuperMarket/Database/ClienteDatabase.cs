using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Database
{
    class ClienteDatabase
    {
        Models.supermarket_dbEntities db = new Models.supermarket_dbEntities();

        public void Insert(Models.tb_cliente cliente)
        {
            db.tb_cliente.Add(cliente);
            db.SaveChanges();
        }
        public void InsertEndereco(Models.tb_enderecocliente endereco)
        {
            db.tb_enderecocliente.Add(endereco);
            db.SaveChanges();
        }
    }
}
