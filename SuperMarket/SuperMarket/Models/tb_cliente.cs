//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperMarket.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_cliente
    {
        public int idtb_cliente { get; set; }
        public string nm_cliente { get; set; }
        public string ds_cpf_cnpj { get; set; }
        public string ds_tipopessoa { get; set; }
        public string dt_cadastro { get; set; }
        public string ds_sexo { get; set; }
        public string ds_idade { get; set; }
        public int tb_enderecocliente_idtb_enderecocliente { get; set; }
        public string ds_telefone { get; set; }
        public string ds_celular { get; set; }
        public string ds_observacao { get; set; }
    
        public virtual tb_enderecocliente tb_enderecocliente { get; set; }
    }
}
