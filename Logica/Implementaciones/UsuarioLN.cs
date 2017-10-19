using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos.Implementaciones;
using Datos;
using Logica.Interface;

    namespace Logica
{
  public class UsuarioLN  : clsInterfaceLogica<USUARIOS>
    {
        SADDEXEntities context;
        UsuarioAD UsuarioAD;

        public UsuarioLN()
        {
            context = new SADDEXEntities();
            UsuarioAD = new UsuarioAD(context);
        }

        public void Agregar_L(USUARIOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                UsuarioAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(USUARIOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                UsuarioAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(USUARIOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                UsuarioAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<USUARIOS> devolverLISTA_L()
        {
            return UsuarioAD.devolverLISTA_D();
        }

        public USUARIOS buscarporID_L(int id)
        {
            return UsuarioAD.buscarporID(id);
        }
    }
}
