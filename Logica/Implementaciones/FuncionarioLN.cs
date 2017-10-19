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
    public class FuncionarioLN: clsInterfaceLogica<FUNCIONARIOS>
    {
        SADDEXEntities context;
        FuncionarioAD FuncionarioAD;

        public FuncionarioLN()
        {
            context = new SADDEXEntities();
            FuncionarioAD = new FuncionarioAD(context);
        }


        public void Agregar_L(FUNCIONARIOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                FuncionarioAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(FUNCIONARIOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                FuncionarioAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(FUNCIONARIOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                FuncionarioAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<FUNCIONARIOS> devolverLISTA_L()
        {
            return FuncionarioAD.devolverLISTA_D();
        }

        public FUNCIONARIOS buscarporID_L(int id)
        {
            return FuncionarioAD.buscarporID(id);
        }
    }
}
