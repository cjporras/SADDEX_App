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
    class CategoriaBonoLN
    {
        SADDEXEntities context;
        CategoriaBonoAD CategoriaBonoAD;

        public CategoriaBonoLN()
        {
            context = new SADDEXEntities();
            CategoriaBonoAD = new CategoriaBonoAD(context);
        }


        public void AgregarAD(CATEGORIA_BONOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                CategoriaBonoAD.AgregarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void EliminarAD( CATEGORIA_BONOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                CategoriaBonoAD.EliminarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void ModificarAD(CATEGORIA_BONOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                CategoriaBonoAD.ModificarAD(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<CATEGORIA_BONOS> obtenerListaAD()
        {
            return CategoriaBonoAD.obtenerListaAD();
        }

        public CATEGORIA_BONOS obtenerPorID_AD(int id)
        {
            return CategoriaBonoAD.obtenerPorID_AD(id);
        }
    }
}
