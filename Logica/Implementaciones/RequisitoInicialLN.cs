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
    class RequisitoInicialLN : clsInterfaceLogica<REQUISITOS_INICIALES>
    {
        SADDEXEntities context;
        RequisitoInicialAD RequisitoInicialAD;

        public RequisitoInicialLN()
        {
            context = new SADDEXEntities();
            RequisitoInicialAD = new RequisitoInicialAD(context);
        }


        public void Agregar_L(REQUISITOS_INICIALES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                RequisitoInicialAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(REQUISITOS_INICIALES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                RequisitoInicialAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(REQUISITOS_INICIALES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                RequisitoInicialAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<REQUISITOS_INICIALES> devolverLISTA_L()
        {
            return RequisitoInicialAD.devolverLISTA_D();
        }

        public REQUISITOS_INICIALES buscarporID_L(int id)
        {
            return RequisitoInicialAD.buscarporID(id);
        }
    }
}
