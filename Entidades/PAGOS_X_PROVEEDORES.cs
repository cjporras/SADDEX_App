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
    
    public partial class PAGOS_X_PROVEEDORES
    {
        public int ID_PAGO_X_PROVEEDOR { get; set; }
        public int FK_NOMBRE_PROVEEDOR { get; set; }
        public double MONTO_CHEQUE { get; set; }
        public System.DateTime FECHA_CHEQUE { get; set; }
        public string NUMERO_CHEQUE { get; set; }
        public int FK_USUARIO { get; set; }
    
        public virtual PROVEEDORES PROVEEDORES { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
    }
}
