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
    public class ObraLN : clsInterfaceLogica<OBRAS>
    {
        SADDEXEntities context;
        ObraAD ObraAD;

        public ObraLN()
        {
            context = new SADDEXEntities();
            ObraAD = new ObraAD(context);
        }


        public void Agregar_L(OBRAS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ObraAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(OBRAS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ObraAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(OBRAS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ObraAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<OBRAS> devolverLISTA_L()
        {
            return ObraAD.devolverLISTA_D();
        }

        public OBRAS buscarporID_L(int id)
        {
            return ObraAD.buscarporID(id);
        }
    }
}
