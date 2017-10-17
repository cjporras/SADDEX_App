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
    class ClienteLN
    {
        SADDEXEntities context;
        ClienteAD ClienteAD;

        public ClienteLN()
        {
            context = new SADDEXEntities();
            ClienteAD = new ClienteAD(context);
        }

        public void AgregarAD(CLIENTES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ClienteAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(CLIENTES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ClienteAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(CLIENTES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ClienteAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<CLIENTES> obtenerListaAD()
        {
            return ClienteAD.obtenerListaAD();
        }

        public CLIENTES obtenerPorID_AD(int id)
        {
            return ClienteAD.obtenerPorID_AD(id);
        }
    }
}
