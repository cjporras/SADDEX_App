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
    class TipoBonoLN : clsInterfaceLogica<TIPO_BONOS>
    {
        SADDEXEntities context;
        TipoBonoAD TipoBonoAD;

        public TipoBonoLN()
        {
            context = new SADDEXEntities();
            TipoBonoAD = new TipoBonoAD(context);
        }


        public void Agregar_L(TIPO_BONOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                TipoBonoAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(TIPO_BONOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                TipoBonoAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(TIPO_BONOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                TipoBonoAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<TIPO_BONOS> devolverLISTA_L()
        {
            return TipoBonoAD.devolverLISTA_D();
        }

        public TIPO_BONOS buscarporID_L(int id)
        {
            return TipoBonoAD.buscarporID(id);
        }
    }
}
