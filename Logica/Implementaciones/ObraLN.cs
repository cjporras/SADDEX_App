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
    class ObraLN
    {
        SADDEXEntities context;
        ObraAD ObraAD;

        public ObraLN()
        {
            context = new SADDEXEntities();
            ObraAD = new ObraAD(context);
        }


        public void AgregarAD(OBRAS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ObraAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(OBRAS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ObraAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(OBRAS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ObraAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<OBRAS> obtenerListaAD()
        {
            return ObraAD.obtenerListaAD();
        }

        public OBRAS obtenerPorID_AD(int id)
        {
            return ObraAD.obtenerPorID_AD(id);
        }
    }
}
