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
    class EstadoTramiteLN
    {
        SADDEXEntities context;
        EstadoTramiteAD EstadoTramiteAD;

        public EstadoTramiteLN()
        {
            context = new SADDEXEntities();
            EstadoTramiteAD = new EstadoTramiteAD(context);
        }


        public void AgregarAD(ESTADO_TRAMITES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                EstadoTramiteAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(ESTADO_TRAMITES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                EstadoTramiteAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(ESTADO_TRAMITES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                EstadoTramiteAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<ESTADO_TRAMITES> obtenerListaAD()
        {
            return EstadoTramiteAD.obtenerListaAD();
        }

        public ESTADO_TRAMITES obtenerPorID_AD(int id)
        {
            return EstadoTramiteAD.obtenerPorID_AD(id);
        }
    }
}
