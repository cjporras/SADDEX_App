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
    public class UbicacionExpedienteLN : clsInterfaceLogica<UBICACION_EXPEDIENTES>
    {
        SADDEXEntities context;
        UbicacionExpedienteAD UbicacionExpedienteAD;

        public UbicacionExpedienteLN()
        {
            context = new SADDEXEntities();
            UbicacionExpedienteAD = new UbicacionExpedienteAD(context);
        }


        public void Agregar_L(UBICACION_EXPEDIENTES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                UbicacionExpedienteAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(UBICACION_EXPEDIENTES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                UbicacionExpedienteAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(UBICACION_EXPEDIENTES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                UbicacionExpedienteAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<UBICACION_EXPEDIENTES> devolverLISTA_L()
        {
            return UbicacionExpedienteAD.devolverLISTA_D();
        }

        public UBICACION_EXPEDIENTES buscarporID_L(int id)
        {
            return UbicacionExpedienteAD.buscarporID(id);
        }
    }
}
