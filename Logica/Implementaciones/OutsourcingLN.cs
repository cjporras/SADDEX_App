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
    class OutsourcingLN : clsInterfaceLogica<OUTSOURCING_S>
    {
        SADDEXEntities context;
        OutsourcingAD OutsourcingAD;

        public OutsourcingLN()
        {
            context = new SADDEXEntities();
            OutsourcingAD = new OutsourcingAD(context);
        }


        public void Agregar_L(OUTSOURCING_S obj)
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

        public void Eliminar_L(OUTSOURCING_S obj)
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

        public void Modificar_L(OUTSOURCING_S obj)
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

        public IEnumerable<OUTSOURCING_S> devolverLISTA_L()
        {
            return OutsourcingAD.devolverLISTA_D();
        }

        public OUTSOURCING_S buscarporID_L(int id)
        {
            return OutsourcingAD.buscarporID(id);
        }
    }
}
