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
    
    public partial class OBRAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OBRAS()
        {
            this.EXPEDIENTES_DIGITALES = new HashSet<EXPEDIENTES_DIGITALES>();
            this.OUTSOURCING_S = new HashSet<OUTSOURCING_S>();
        }
    
        public int ID_OBRA { get; set; }
        public int FK_USUARIO { get; set; }
        public string LUGAR_OBRA { get; set; }
        public System.DateTime FECHA_INICIO_OBRA { get; set; }
        public Nullable<System.DateTime> FECHA_FINAL_OBRA { get; set; }
        public Nullable<int> COSTO_OBRA { get; set; }
        public int FK_CLIENTE { get; set; }
        public string DETALLE_OBRA { get; set; }
    
        public virtual CLIENTES CLIENTES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXPEDIENTES_DIGITALES> EXPEDIENTES_DIGITALES { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OUTSOURCING_S> OUTSOURCING_S { get; set; }
    }
}