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
    class FuncionarioLN
    {
        SADDEXEntities context;
        FuncionarioAD FuncionarioAD;

        public FuncionarioLN()
        {
            context = new SADDEXEntities();
            FuncionarioAD = new FuncionarioAD(context);
        }


        public void AgregarAD(FUNCIONARIOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                FuncionarioAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(FUNCIONARIOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                FuncionarioAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(FUNCIONARIOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                FuncionarioAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<FUNCIONARIOS> obtenerListaAD()
        {
            return FuncionarioAD.obtenerListaAD();
        }

        public FUNCIONARIOS obtenerPorID_AD(int id)
        {
            return FuncionarioAD.obtenerPorID_AD(id);
        }
    }
}
