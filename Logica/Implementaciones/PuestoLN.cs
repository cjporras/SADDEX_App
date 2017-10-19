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
    class PuestoLN : clsInterfaceLogica<PUESTOS>
    {
        SADDEXEntities context;
        PuestoAD PuestoAD;

        public PuestoLN()
        {
            context = new SADDEXEntities();
            PuestoAD = new PuestoAD(context);
        }

        public void Agregar_L(PUESTOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                PuestoAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(PUESTOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                PuestoAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(PUESTOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                PuestoAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<PUESTOS> devolverLISTA_L()
        {
            return PuestoAD.devolverLISTA_D();
        }

        public PUESTOS buscarporID_L(int id)
        {
            return PuestoAD.buscarporID(id);
        }
    }
}
