using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
  public  class TipoBonoAD
    {
        SADDEXEntities context;

        public TipoBonoAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void AgregarAD(TIPO_BONOS obj)
        {
            this.context.TIPO_BONOS.Add(obj);
        }

        public void EliminarAD(TIPO_BONOS obj)
        {
            var tipoBono = context.TIPO_BONOS.Where(com => com.ID_TIPO_BONO == obj.ID_TIPO_BONO).FirstOrDefault();
            if (tipoBono != null)
            {
                this.context.TIPO_BONOS.Remove(tipoBono);
            }
        }

        public void ModificarAD(TIPO_BONOS obj)
        {
            var tipoBono = context.TIPO_BONOS.Where(com => com.ID_TIPO_BONO == obj.ID_TIPO_BONO).FirstOrDefault();
            if (tipoBono != null)
            {
                tipoBono.NOMBRE_TIPO_BONO = obj.NOMBRE_TIPO_BONO;
                tipoBono.DETALLE_TIPO_BONO = obj.DETALLE_TIPO_BONO;
                tipoBono.FK_CLIENTE = obj.FK_CLIENTE;
            }
        }

        public IEnumerable<TIPO_BONOS> obtenerListaAD()
        {
            return this.context.TIPO_BONOS;
        }

        public TIPO_BONOS obtenerPorID_AD(int id)
        {
            return this.context.TIPO_BONOS.Where(com => com.ID_TIPO_BONO == id).FirstOrDefault();
        }
    }
}
