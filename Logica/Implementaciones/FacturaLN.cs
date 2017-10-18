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
    class FacturaLN : clsInterfaceLogica<FACTURAS>
    {
        SADDEXEntities context;
        FacturaAD FacturaAD;

        public FacturaLN()
        {
            context = new SADDEXEntities();
            FacturaAD = new FacturaAD(context);
        }

        public void Agregar_L(FACTURAS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                FacturaAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(FACTURAS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                FacturaAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(FACTURAS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                FacturaAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<FACTURAS> devolverLISTA_L()
        {
            return FacturaAD.devolverLISTA_D();
        }

        public FACTURAS buscarporID_L(int id)
        {
            return FacturaAD.buscarporID(id);
        }
    }
}
