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
    class ClienteLN : clsInterfaceLogica<CLIENTES>
    {
        SADDEXEntities context;
        ClienteAD ClienteAD;

        public ClienteLN()
        {
            context = new SADDEXEntities();
            ClienteAD = new ClienteAD(context);
        }

        public void Agregar_L(CLIENTES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ClienteAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L(CLIENTES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ClienteAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(CLIENTES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                ClienteAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<CLIENTES> devolverLISTA_L()
        {
            return ClienteAD.devolverLISTA_D();
        }

        public CLIENTES buscarporID_L(int id)
        {
            return ClienteAD.buscarporID(id);
        }
    }
}
