﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Entidades;
    
    public partial class SADDEXEntities : DbContext
    {
        public SADDEXEntities()
            : base("name=SADDEXEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORIA_BONOS> CATEGORIA_BONOS { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<ESTADO_TRAMITES> ESTADO_TRAMITES { get; set; }
        public virtual DbSet<EXPEDIENTES_DIGITALES> EXPEDIENTES_DIGITALES { get; set; }
        public virtual DbSet<FACTURAS> FACTURAS { get; set; }
        public virtual DbSet<FUNCIONARIOS> FUNCIONARIOS { get; set; }
        public virtual DbSet<LISTAS_OUTSOURCING> LISTAS_OUTSOURCING { get; set; }
        public virtual DbSet<OBRAS> OBRAS { get; set; }
        public virtual DbSet<OUTSOURCING_S> OUTSOURCING_S { get; set; }
        public virtual DbSet<PAGOS_X_PROVEEDORES> PAGOS_X_PROVEEDORES { get; set; }
        public virtual DbSet<PROVEEDORES> PROVEEDORES { get; set; }
        public virtual DbSet<PUESTOS> PUESTOS { get; set; }
        public virtual DbSet<REQUISITOS_INICIALES> REQUISITOS_INICIALES { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TIPO_BONOS> TIPO_BONOS { get; set; }
        public virtual DbSet<UBICACION_EXPEDIENTES> UBICACION_EXPEDIENTES { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
    }
}
