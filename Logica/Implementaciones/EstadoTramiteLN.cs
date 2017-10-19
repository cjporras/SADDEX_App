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
    public class EstadoTramiteLN : clsInterfaceLogica<ESTADO_TRAMITES>
    {
        SADDEXEntities context;
        EstadoTramiteAD EstadoTramiteAD;

        public EstadoTramiteLN()
        {
            context = new SADDEXEntities();
            EstadoTramiteAD = new EstadoTramiteAD(context);
        }


        public void Agregar_L(ESTADO_TRAMITES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                EstadoTramiteAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(ESTADO_TRAMITES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                EstadoTramiteAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(ESTADO_TRAMITES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                EstadoTramiteAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<ESTADO_TRAMITES> devolverLISTA_L()
        {
            return EstadoTramiteAD.devolverLISTA_D();
        }

        public ESTADO_TRAMITES buscarporID_L(int id)
        {
            return EstadoTramiteAD.buscarporID(id);
        }
    }
}
