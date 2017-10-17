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
    class PuestoLN
    {
        SADDEXEntities context;
        PuestoAD PuestoAD;

        public PuestoLN()
        {
            context = new SADDEXEntities();
            PuestoAD = new PuestoAD(context);
        }

        public void AgregarAD(PUESTOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                PuestoAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(PUESTOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                PuestoAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(PUESTOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                PuestoAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<PUESTOS> obtenerListaAD()
        {
            return PuestoAD.obtenerListaAD();
        }

        public PUESTOS obtenerPorID_AD(int id)
        {
            return PuestoAD.obtenerPorID_AD(id);
        }
    }
}
