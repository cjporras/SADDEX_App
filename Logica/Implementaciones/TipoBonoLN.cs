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
    class TipoBonoLN
    {
        SADDEXEntities context;
        TipoBonoAD TipoBonoAD;

        public TipoBonoLN()
        {
            context = new SADDEXEntities();
            TipoBonoAD = new TipoBonoAD(context);
        }


        public void AgregarAD(TIPO_BONOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                TipoBonoAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(TIPO_BONOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                TipoBonoAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(TIPO_BONOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                TipoBonoAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<TIPO_BONOS> obtenerListaAD()
        {
            return TipoBonoAD.obtenerListaAD();
        }

        public TIPO_BONOS obtenerPorID_AD(int id)
        {
            return TipoBonoAD.obtenerPorID_AD(id);
        }
    }
}
