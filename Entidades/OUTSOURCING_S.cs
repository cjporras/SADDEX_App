//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class OUTSOURCING_S
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OUTSOURCING_S()
        {
            this.FACTURAS = new HashSet<FACTURAS>();
            this.OBRAS = new HashSet<OBRAS>();
        }
    
        public int ID_OUTSOURCING { get; set; }
        public int FK_USUARIO { get; set; }
        public int FK_LISTA_OUTSOURCING { get; set; }
        public System.DateTime FECHA_CONTRATACION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }
        public virtual LISTAS_OUTSOURCING LISTAS_OUTSOURCING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBRAS> OBRAS { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
    }
}
