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
    class UbicacionExpedienteLN
    {
        SADDEXEntities context;
        UbicacionExpedienteAD UbicacionExpedienteAD;

        public UbicacionExpedienteLN()
        {
            context = new SADDEXEntities();
            UbicacionExpedienteAD = new UbicacionExpedienteAD(context);
        }


        public void AgregarAD(UBICACION_EXPEDIENTES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                UbicacionExpedienteAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(UBICACION_EXPEDIENTES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                UbicacionExpedienteAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(UBICACION_EXPEDIENTES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                UbicacionExpedienteAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<UBICACION_EXPEDIENTES> obtenerListaAD()
        {
            return UbicacionExpedienteAD.obtenerListaAD();
        }

        public UBICACION_EXPEDIENTES obtenerPorID_AD(int id)
        {
            return UbicacionExpedienteAD.obtenerPorID_AD(id);
        }
    }
}
