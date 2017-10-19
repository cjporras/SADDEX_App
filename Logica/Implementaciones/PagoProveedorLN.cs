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
    class PagoProveedorLN : clsInterfaceLogica<PAGOS_X_PROVEEDORES>
    {
        SADDEXEntities context;
        PagoPorProveedorAD PagoPorProveedorAD;

        public PagoProveedorLN()
        {
            context = new SADDEXEntities();
            PagoPorProveedorAD = new PagoPorProveedorAD(context);
        }


        public void Agregar_L(PAGOS_X_PROVEEDORES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                PagoPorProveedorAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(PAGOS_X_PROVEEDORES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                PagoPorProveedorAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(PAGOS_X_PROVEEDORES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                PagoPorProveedorAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<PAGOS_X_PROVEEDORES> devolverLISTA_L()
        {
            return PagoPorProveedorAD.devolverLISTA_D();
        }

        public PAGOS_X_PROVEEDORES buscarporID_L(int id)
        {
            return PagoPorProveedorAD.buscarporID(id);
        }
    }
}
