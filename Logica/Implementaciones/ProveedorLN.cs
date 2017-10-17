using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos.Implementaciones;
using Datos;
using Logica.Interface;

namespace Logica.Implementaciones
{
    class ProveedorLN
    {
        SADDEXEntities context;
        ProveedorAD ProveedorAD;

        public ProveedorLN()
        {
            context = new SADDEXEntities();
            ProveedorAD = new ProveedorAD(context);
        }

        public void AgregarAD(PROVEEDORES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ProveedorAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(PROVEEDORES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ProveedorAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(PROVEEDORES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ProveedorAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<PROVEEDORES> obtenerListaAD()
        {
            return ProveedorAD.obtenerListaAD();
        }

        public PROVEEDORES obtenerPorID_AD(int id)
        {
            return ProveedorAD.obtenerPorID_AD(id);
        }
    }
}
