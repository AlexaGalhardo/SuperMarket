using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Database
{
    class ProdutoDatabase
    {
        Models.supermarket_dbEntities db = new Models.supermarket_dbEntities();

        public void Insert (Models.tb_produto produto)
        {
            db.tb_produto.Add(produto);
            db.SaveChanges();
        }
        public List<Models.tb_produto> ListarTodos()
        {
            List<Models.tb_produto> lista = db.tb_produto.ToList();
            return lista;
        }
        public List<Models.tb_produto> FiltrarPorNome(string nome)
        {
            List<Models.tb_produto> lista = db.tb_produto.Where(t => t.nm_produto == nome)
                                                         .OrderBy(t => t.nm_produto)
                                                         .ToList();
            return lista;
        }
        public void Alterar (Models.tb_produto produto)
        {
            Models.tb_produto alterar = db.tb_produto
                .FirstOrDefault(t => t.idtb_produto == produto.idtb_produto);
            
            if(alterar != null)
            {
                alterar.ds_origem = produto.ds_origem;
                alterar.dt_fabricacao = produto.dt_fabricacao;
                alterar.dt_validade = produto.dt_validade;
                alterar.nm_produto = produto.nm_produto;
                alterar.vl_venda = produto.vl_venda;
            }
            db.SaveChanges();
        }
        public void Remover (int id)
        {
            Models.tb_produto remover = db.tb_produto.
                FirstOrDefault(t => t.idtb_produto == id);
            db.tb_produto.Remove(remover);
            db.SaveChanges();
        }

    }
}
