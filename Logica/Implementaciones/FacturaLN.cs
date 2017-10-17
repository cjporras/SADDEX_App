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
    class FacturaLN
    {
        SADDEXEntities context;
        FacturaAD FacturaAD;

        public FacturaLN()
        {
            context = new SADDEXEntities();
            FacturaAD = new FacturaAD(context);
        }

        public void AgregarAD(FACTURAS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                FacturaAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(FACTURAS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                FacturaAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(FACTURAS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                FacturaAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<FACTURAS> obtenerListaAD()
        {
            return FacturaAD.obtenerListaAD();
        }

        public FACTURAS obtenerPorID_AD(int id)
        {
            return FacturaAD.obtenerPorID_AD(id);
        }
    }
}
