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
    
    public partial class CLIENTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTES()
        {
            this.EXPEDIENTES_DIGITALES = new HashSet<EXPEDIENTES_DIGITALES>();
            this.FACTURAS = new HashSet<FACTURAS>();
            this.REQUISITOS_INICIALES = new HashSet<REQUISITOS_INICIALES>();
            this.TIPO_BONOS = new HashSet<TIPO_BONOS>();
        }
    
        public int ID_CLIENTE { get; set; }
        public int CEDULA { get; set; }
        public string NOMBRE_COMPLETO { get; set; }
        public string PRIMER_APELLIDO { get; set; }
        public string SEGUNDO_APELLIDO { get; set; }
        public string PROVINCIA { get; set; }
        public string CANTON { get; set; }
        public string DISTRITO { get; set; }
        public string OTRAS_SEÑAS { get; set; }
        public string CORREO_ELECTRONICO { get; set; }
        public string NACIONALIDAD { get; set; }
        public int TELEFONO_1 { get; set; }
        public int TELEFONO_2 { get; set; }
        public System.DateTime FECHA_NACIMIENTO { get; set; }
        public string SEXO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXPEDIENTES_DIGITALES> EXPEDIENTES_DIGITALES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURAS> FACTURAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUISITOS_INICIALES> REQUISITOS_INICIALES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIPO_BONOS> TIPO_BONOS { get; set; }
    }
}
