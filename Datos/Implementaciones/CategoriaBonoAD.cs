using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
  public  class CategoriaBonoAD : clsInterfaceDatos<CATEGORIA_BONOS>
    {

        SADDEXEntities context;

        public CategoriaBonoAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void Agregar_D(CATEGORIA_BONOS obj)
        {
            this.context.CATEGORIA_BONOS.Add(obj);
        }

        public void Eliminar_D(CATEGORIA_BONOS obj)
        {
            var categoriaBono = context.CATEGORIA_BONOS.Where(com => com.ID_CATEGORIA_BONO == obj.ID_CATEGORIA_BONO).FirstOrDefault();
            if (categoriaBono != null)
            {
                this.context.CATEGORIA_BONOS.Remove(categoriaBono);
            }
        }

        public void Modificar_D(CATEGORIA_BONOS obj)
        {
            var categoriaBono = context.CATEGORIA_BONOS.Where(com => com.ID_CATEGORIA_BONO == obj.ID_CATEGORIA_BONO).FirstOrDefault();
            if (categoriaBono != null)
            {
                categoriaBono.NOBRE_CATEGORIA_BONO = obj.NOBRE_CATEGORIA_BONO;
                categoriaBono.DETALLE_CATEGORIA_BNO = obj.DETALLE_CATEGORIA_BNO;
                categoriaBono.FK_CLIENTE = obj.FK_CLIENTE;
            }
        }

        public IEnumerable<CATEGORIA_BONOS> devolverLISTA_D()
        {
            return this.context.CATEGORIA_BONOS;
        }

        public CATEGORIA_BONOS buscarporID(int id)
        {
            return this.context.CATEGORIA_BONOS.Where(com => com.ID_CATEGORIA_BONO == id).FirstOrDefault();
        }
}
}
