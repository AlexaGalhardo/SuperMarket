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
    
    public partial class tb_produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_produto()
        {
            this.tb_compra_has_tb_produto = new HashSet<tb_compra_has_tb_produto>();
        }
    
        public int idtb_produto { get; set; }
        public string nm_produto { get; set; }
        public System.DateTime dt_validade { get; set; }
        public System.DateTime dt_fabricacao { get; set; }
        public string ds_origem { get; set; }
        public string vl_venda { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_compra_has_tb_produto> tb_compra_has_tb_produto { get; set; }
    }
}
