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
    class OutsourcingLN
    {
        SADDEXEntities context;
        OutsourcingAD OutsourcingAD;

        public OutsourcingLN()
        {
            context = new SADDEXEntities();
            OutsourcingAD = new OutsourcingAD(context);
        }


        public void AgregarAD(OUTSOURCING_S obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                OutsourcingAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(OUTSOURCING_S obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                OutsourcingAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(OUTSOURCING_S obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                OutsourcingAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<OUTSOURCING_S> obtenerListaAD()
        {
            return OutsourcingAD.obtenerListaAD();
        }

        public OUTSOURCING_S obtenerPorID_AD(int id)
        {
            return OutsourcingAD.obtenerPorID_AD(id);
        }
    }
}
