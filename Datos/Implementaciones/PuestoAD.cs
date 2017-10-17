using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
 public   class PuestoAD
    {
        SADDEXEntities context;

        public PuestoAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void AgregarAD(PUESTOS obj)
        {
            this.context.PUESTOS.Add(obj);
        }

        public void EliminarAD(PUESTOS obj)
        {
            var puesto = context.PUESTOS.Where(com => com.ID_PUESTO == obj.ID_PUESTO).FirstOrDefault();
            if (puesto != null)
            {
                this.context.PUESTOS.Remove(puesto);
            }
        }

        public void ModificarAD(PUESTOS obj)
        {
            var puesto = context.PUESTOS.Where(com => com.ID_PUESTO == obj.ID_PUESTO).FirstOrDefault();
            if (puesto != null)
            {
                puesto.NOMBRE_PUESTO = obj.NOMBRE_PUESTO;
                puesto.DETALLE_PUESTO = obj.DETALLE_PUESTO;
            }
        }

        public IEnumerable<PUESTOS> obtenerListaAD()
        {
            return this.context.PUESTOS;
        }

        public PUESTOS obtenerPorID_AD(int id)
        {
            return this.context.PUESTOS.Where(com => com.ID_PUESTO == id).FirstOrDefault();
        }
    }
}
