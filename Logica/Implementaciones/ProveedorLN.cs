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
    public class ProveedorLN : clsInterfaceLogica<PROVEEDORES>
    {
        SADDEXEntities context;
        ProveedorAD ProveedorAD;

        public ProveedorLN()
        {
            context = new SADDEXEntities();
            ProveedorAD = new ProveedorAD(context);
        }

        public void Agregar_L(PROVEEDORES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ProveedorAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(PROVEEDORES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ProveedorAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(PROVEEDORES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ProveedorAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<PROVEEDORES> devolverLISTA_L()
        {
            return ProveedorAD.devolverLISTA_D();
        }

        public PROVEEDORES buscarporID_L(int id)
        {
            return ProveedorAD.buscarporID(id);
        }
    }
}
