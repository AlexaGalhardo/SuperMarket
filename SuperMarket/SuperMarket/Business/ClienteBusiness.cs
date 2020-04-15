using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Business
{
    class ClienteBusiness
    {
        Database.ClienteDatabase db = new Database.ClienteDatabase();

        public void Insert(Models.tb_cliente cliente)
        {
            db.Insert(cliente);
        }
        public void InsertEndereco(Models.tb_enederecocliente endereco)
        {
            db.InsertEndereco(endereco);
        }
        public List<Models.tb_cliente> ListarTodos()
        {
            List<Models.tb_cliente> lista = db.ListarTodos();
            return lista;
        }
        public void Alterar(Models.tb_cliente cliente)
        {
            db.Alterar(cliente);
        }
        public void AlterarEndereco(Models.tb_enederecocliente endereco)
        {
            db.AlterarEndereco(endereco);
        }
        public void Remover(int id)
        {
            db.Remover(id);
        }
        public void RemoverEndereco(int id)
        {
            db.RemoverEndereco(id);
        }
    }
}
