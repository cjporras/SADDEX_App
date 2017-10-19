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
    public class ListaOutsourcingLN : clsInterfaceLogica<LISTAS_OUTSOURCING>
    {
        SADDEXEntities context;
        ListaOutsourcingAD ListaOutsourcingAD;

        public ListaOutsourcingLN()
        {
            context = new SADDEXEntities();
            ListaOutsourcingAD = new ListaOutsourcingAD(context);
        }

        public void Agregar_L(LISTAS_OUTSOURCING obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ListaOutsourcingAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(LISTAS_OUTSOURCING obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ListaOutsourcingAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(LISTAS_OUTSOURCING obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ListaOutsourcingAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<LISTAS_OUTSOURCING> devolverLISTA_L()
        {
            return ListaOutsourcingAD.devolverLISTA_D();
        }

        public LISTAS_OUTSOURCING buscarporID_L(int id)
        {
            return ListaOutsourcingAD.buscarporID(id);
        }
    }
}
