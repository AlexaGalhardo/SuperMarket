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
        public List<Models.tb_produto> FiltrarPorNome(string nome)
        {
            List<Models.tb_produto> lista = db.FiltrarPorNome(nome);
            return lista;
        }
        public List<Models.tb_produto> FiltrarPorOrigem(string origem)
        {
            List<Models.tb_produto> lista = db.FiltrarPorOrigem(origem);
            return lista;
        }
        public List<Models.tb_produto> FiltrarPorValidade(DateTime data)
        {
            List<Models.tb_produto> lista = db.FiltrarPorValidade(data);
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
