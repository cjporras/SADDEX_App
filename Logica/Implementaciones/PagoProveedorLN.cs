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
    class PagoProveedorLN
    {
        SADDEXEntities context;
        PagoPorProveedorAD PagoPorProveedorAD;

        public PagoProveedorLN()
        {
            context = new SADDEXEntities();
            PagoPorProveedorAD = new PagoPorProveedorAD(context);
        }


        public void AgregarAD(PAGOS_X_PROVEEDORES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                PagoPorProveedorAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(PAGOS_X_PROVEEDORES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                PagoPorProveedorAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(PAGOS_X_PROVEEDORES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                PagoPorProveedorAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<PAGOS_X_PROVEEDORES> obtenerListaAD()
        {
            return PagoPorProveedorAD.obtenerListaAD();
        }

        public PAGOS_X_PROVEEDORES obtenerPorID_AD(int id)
        {
            return PagoPorProveedorAD.obtenerPorID_AD(id);
        }
    }
}
