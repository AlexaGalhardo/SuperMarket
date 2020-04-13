using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Database
{
    class ClienteDatabase
    {
        Models.supermarket_dbEntities2 db = new Models.supermarket_dbEntities2();

        public void Insert(Models.tb_cliente cliente)
        {
            db.tb_cliente.Add(cliente);
            db.SaveChanges();
        }
        public void InsertEndereco(Models.tb_enederecocliente endereco)
        {
            db.tb_enederecocliente.Add(endereco);
            db.SaveChanges();
        }
        public List<Models.tb_cliente> ListarTodos()
        {
            List<Models.tb_cliente> lista = db.tb_cliente.ToList();
            return lista;
        }
        public List<Models.tb_cliente> FiltrarPorNome(string nome)
        {
            List<Models.tb_cliente> lista = db.tb_cliente.Where(t => t.nm_cliente.Contains(nome))
                                                        .OrderBy(t => t.nm_cliente)
                                                        .ToList();
            return lista;
        }
        public List<Models.tb_cliente> FiltrarPorIdade(int idade)
        {
            List<Models.tb_cliente> lista = db.tb_cliente.Where(t => t.ds_idade == idade)
                                                         .ToList();
            return lista;
        }
        public void Alterar(Models.tb_cliente cliente)
        {
            Models.tb_cliente alterar = db.tb_cliente.First
                (t => t.idtb_cliente == cliente.idtb_cliente);
            if (alterar != null)
            {
                alterar.ds_cpf_cnpj = cliente.ds_cpf_cnpj;
                alterar.ds_idade = cliente.ds_idade;
                alterar.ds_sexo = cliente.ds_sexo;
                alterar.ds_tipo_pessoa = cliente.ds_tipo_pessoa;
                alterar.dt_cadastro = cliente.dt_cadastro;
                alterar.nm_cliente = cliente.nm_cliente;
            }
            db.SaveChanges();
        }
        public void AlterarEndereco(Models.tb_enederecocliente endereco)
        {
            Models.tb_enederecocliente alterar = db.tb_enederecocliente.FirstOrDefault
                (t => t.idtb_enderecocliente == endereco.idtb_enderecocliente);
            if (alterar != null)
            {
                alterar.ds_cep = endereco.ds_cep;
                alterar.ds_numero = endereco.ds_numero;
                alterar.nm_cidade = endereco.nm_cidade;
                alterar.nm_endereco = endereco.nm_endereco;
                alterar.nm_estado = endereco.nm_estado;
            }
            db.SaveChanges();
        }
        public void Remover(int id)
        {
            Models.tb_cliente remover = db.tb_cliente.First
                (t => t.idtb_cliente == id);
            db.tb_cliente.Remove(remover);
            db.SaveChanges();
        }
        public void RemoverEndereco(int id)
        {
            Models.tb_enederecocliente remover = db.tb_enederecocliente.First
                (t => t.idtb_enderecocliente == id);
            db.tb_enederecocliente.Remove(remover);
            db.SaveChanges();
        }
    }
    }
