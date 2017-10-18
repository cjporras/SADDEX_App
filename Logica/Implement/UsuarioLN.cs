using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Implementaciones;
using Datos;
using Entidades;

namespace Logica.Implement
{
    class UsuarioLN
    {
        SADDEXEntities context;
        UsuarioAD UsuarioAD;

        public UsuarioLN()
        {
            context = new SADDEXEntities();
            UsuarioAD = new UsuarioAD(context);
        }

        public void AgregarAD(USUARIOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                UsuarioAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(USUARIOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                UsuarioAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(USUARIOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                UsuarioAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<USUARIOS> obtenerListaAD()
        {
            return UsuarioAD.obtenerListaAD();
        }

        public USUARIOS obtenerPorID_AD(int id)
        {
            return UsuarioAD.obtenerPorID_AD(id);
        }
    }
}
