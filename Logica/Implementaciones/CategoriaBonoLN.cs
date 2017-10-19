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
    public class CategoriaBonoLN : clsInterfaceLogica<CATEGORIA_BONOS>
    {
        SADDEXEntities context;
        CategoriaBonoAD CategoriaBonoAD;

        public CategoriaBonoLN()
        {
            context = new SADDEXEntities();
            CategoriaBonoAD = new CategoriaBonoAD(context);
        }


        public void Agregar_L(CATEGORIA_BONOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                CategoriaBonoAD.Agregar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Eliminar_L( CATEGORIA_BONOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                CategoriaBonoAD.Eliminar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public void Modificar_L(CATEGORIA_BONOS obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                CategoriaBonoAD.Modificar_D(obj);
                this.context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
        }

        public IEnumerable<CATEGORIA_BONOS> devolverLISTA_L()
        {
            return CategoriaBonoAD.devolverLISTA_D();
        }

        public CATEGORIA_BONOS buscarporID_L(int id)
        {
            return CategoriaBonoAD.buscarporID(id);
        }
    }
}
