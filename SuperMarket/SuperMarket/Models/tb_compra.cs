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
    
    public partial class tb_compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_compra()
        {
            this.tb_compra_has_tb_produto = new HashSet<tb_compra_has_tb_produto>();
        }
    
        public int idtb_compra { get; set; }
        public double vl_desconto { get; set; }
        public double vl_frete { get; set; }
        public double vl_total { get; set; }
        public string nm_endereco { get; set; }
        public string nm_estado { get; set; }
        public string ds_cep { get; set; }
        public int ds_numero { get; set; }
        public string ds_formapagamento { get; set; }
        public int tb_cliente_idtb_cliente { get; set; }
    
        public virtual tb_cliente tb_cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_compra_has_tb_produto> tb_compra_has_tb_produto { get; set; }
    }
}
