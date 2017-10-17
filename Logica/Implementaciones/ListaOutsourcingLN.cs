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
    class ListaOutsourcingLN
    {
        SADDEXEntities context;
        ListaOutsourcingAD ListaOutsourcingAD;

        public ListaOutsourcingLN()
        {
            context = new SADDEXEntities();
            ListaOutsourcingAD = new ListaOutsourcingAD(context);
        }

        public void AgregarAD(LISTAS_OUTSOURCING obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ListaOutsourcingAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(LISTAS_OUTSOURCING obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ListaOutsourcingAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(LISTAS_OUTSOURCING obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ListaOutsourcingAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<LISTAS_OUTSOURCING> obtenerListaAD()
        {
            return ListaOutsourcingAD.obtenerListaAD();
        }

        public LISTAS_OUTSOURCING obtenerPorID_AD(int id)
        {
            return ListaOutsourcingAD.obtenerPorID_AD(id);
        }
    }
}
