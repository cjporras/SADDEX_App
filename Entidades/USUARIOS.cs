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
    
    public partial class USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIOS()
        {
            this.EXPEDIENTES_DIGITALES = new HashSet<EXPEDIENTES_DIGITALES>();
            this.FACTURAS = new HashSet<FACTURAS>();
            this.OBRAS = new HashSet<OBRAS>();
            this.OUTSOURCING_S = new HashSet<OUTSOURCING_S>();
            this.PAGOS_X_PROVEEDORES = new HashSet<PAGOS_X_PROVEEDORES>();
            this.UBICACION_EXPEDIENTES = new HashSet<UBICACION_EXPEDIENTES>();
        }
    
        public int ID_USUARIO { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string CONTRASEÑA { get; set; }
        public int FK_FUNCIONARIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXPEDIENTES_DIGITALES> EXPEDIENTES_DIGITALES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }
        public virtual FUNCIONARIOS FUNCIONARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBRAS> OBRAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OUTSOURCING_S> OUTSOURCING_S { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOS_X_PROVEEDORES> PAGOS_X_PROVEEDORES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UBICACION_EXPEDIENTES> UBICACION_EXPEDIENTES { get; set; }
    }
}