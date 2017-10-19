using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
  public  class TipoBonoAD : clsInterfaceDatos<TIPO_BONOS>
    {
        SADDEXEntities context;

        public TipoBonoAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void Agregar_D(TIPO_BONOS obj)
        {
            this.context.TIPO_BONOS.Add(obj);
        }

        public void Eliminar_D(TIPO_BONOS obj)
        {
            var tipoBono = context.TIPO_BONOS.Where(tip_bon => tip_bon.ID_TIPO_BONO == obj.ID_TIPO_BONO).FirstOrDefault();
            if (tipoBono != null)
            {
                this.context.TIPO_BONOS.Remove(tipoBono);
            }
        }

        public void Modificar_D(TIPO_BONOS obj)
        {
            var tipoBono = context.TIPO_BONOS.Where(tip_bon => tip_bon.ID_TIPO_BONO == obj.ID_TIPO_BONO).FirstOrDefault();
            if (tipoBono != null)
            {
                tipoBono.NOMBRE_TIPO_BONO = obj.NOMBRE_TIPO_BONO;
                tipoBono.DETALLE_TIPO_BONO = obj.DETALLE_TIPO_BONO;
                tipoBono.FK_CLIENTE = obj.FK_CLIENTE;
            }
        }

        public IEnumerable<TIPO_BONOS> devolverLISTA_D()
        {
            return this.context.TIPO_BONOS;
        }

        public TIPO_BONOS buscarporID(int id)
        {
            return this.context.TIPO_BONOS.Where(tip_bon => tip_bon.ID_TIPO_BONO == id).FirstOrDefault();
        }
    }
}
