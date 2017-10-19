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
    public class ExpedienteDigitalLN : clsInterfaceLogica<EXPEDIENTES_DIGITALES>
    {
        SADDEXEntities context;
        ExpedienteDigitalAD ExpedienteDigitalAD;

        public ExpedienteDigitalLN()
        {
            context = new SADDEXEntities();
            ExpedienteDigitalAD = new ExpedienteDigitalAD(context);
        }


        public void Agregar_L(EXPEDIENTES_DIGITALES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ExpedienteDigitalAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(EXPEDIENTES_DIGITALES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ExpedienteDigitalAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(EXPEDIENTES_DIGITALES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ExpedienteDigitalAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<EXPEDIENTES_DIGITALES> devolverLISTA_L()
        {
            return ExpedienteDigitalAD.devolverLISTA_D();
        }

        public EXPEDIENTES_DIGITALES buscarporID_L(int id)
        {
            return ExpedienteDigitalAD.buscarporID(id);
        }
    }
}
