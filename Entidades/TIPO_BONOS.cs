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
    
    public partial class TIPO_BONOS
    {
        public int ID_TIPO_BONO { get; set; }
        public string NOMBRE_TIPO_BONO { get; set; }
        public string DETALLE_TIPO_BONO { get; set; }
        public int FK_CLIENTE { get; set; }
    
        public virtual CLIENTES CLIENTES { get; set; }
    }
}
