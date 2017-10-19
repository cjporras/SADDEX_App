using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
  public  class ObraAD : clsInterfaceDatos<OBRAS>
    {
        SADDEXEntities context;

        public ObraAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void Agregar_D(OBRAS obj)
        {
            this.context.OBRAS.Add(obj);
        }

        public void Eliminar_D(OBRAS obj)
        {
            var obra = context.OBRAS.Where(com => com.ID_OBRA == obj.ID_OBRA).FirstOrDefault();
            if (obra != null)
            {
                this.context.OBRAS.Remove(obra);
            }
        }

        public void Modificar_D(OBRAS obj)
        {
            var obra = context.OBRAS.Where(com => com.ID_OBRA == obj.ID_OBRA).FirstOrDefault();
            if (obra != null)
            {
                obra.FK_USUARIO = obj.FK_USUARIO;
                obra.LUGAR_OBRA = obj.LUGAR_OBRA;
                obra.FECHA_INICIO_OBRA = obj.FECHA_INICIO_OBRA;
                obra.FECHA_FINAL_OBRA = obj.FECHA_FINAL_OBRA;
                obra.COSTO_OBRA = obj.COSTO_OBRA;
                obra.DETALLE_OBRA = obj.DETALLE_OBRA;
                obra.FK_ID_EXPEDIENTE_DIGITAL = obj.FK_ID_EXPEDIENTE_DIGITAL;
                obra.FK_ID_OUTSOURCING = obj.FK_ID_OUTSOURCING;
            }
        }

        public IEnumerable<OBRAS> devolverLISTA_D()
        {
            return this.context.OBRAS;
        }

        public OBRAS buscarporID(int id)
        {
            return this.context.OBRAS.Where(com => com.ID_OBRA == id).FirstOrDefault();
        }
    }
}
