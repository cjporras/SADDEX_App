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
    class ExpedienteDigitalLN
    {
        SADDEXEntities context;
        ExpedienteDigitalAD ExpedienteDigitalAD;

        public ExpedienteDigitalLN()
        {
            context = new SADDEXEntities();
            ExpedienteDigitalAD = new ExpedienteDigitalAD(context);
        }


        public void AgregarAD(EXPEDIENTES_DIGITALES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ExpedienteDigitalAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(EXPEDIENTES_DIGITALES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ExpedienteDigitalAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(EXPEDIENTES_DIGITALES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ExpedienteDigitalAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<EXPEDIENTES_DIGITALES> obtenerListaAD()
        {
            return ExpedienteDigitalAD.obtenerListaAD();
        }

        public EXPEDIENTES_DIGITALES obtenerPorID_AD(int id)
        {
            return ExpedienteDigitalAD.obtenerPorID_AD(id);
        }
    }
}
