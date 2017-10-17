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
    class RequisitoInicialLN
    {
        SADDEXEntities context;
        RequisitoInicialAD RequisitoInicialAD;

        public RequisitoInicialLN()
        {
            context = new SADDEXEntities();
            RequisitoInicialAD = new RequisitoInicialAD(context);
        }


        public void AgregarAD(REQUISITOS_INICIALES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                RequisitoInicialAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD(REQUISITOS_INICIALES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                RequisitoInicialAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(REQUISITOS_INICIALES obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                RequisitoInicialAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<REQUISITOS_INICIALES> obtenerListaAD()
        {
            return RequisitoInicialAD.obtenerListaAD();
        }

        public REQUISITOS_INICIALES obtenerPorID_AD(int id)
        {
            return RequisitoInicialAD.obtenerPorID_AD(id);
        }
    }
}
