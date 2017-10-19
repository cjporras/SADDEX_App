using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
 public   class PuestoAD : clsInterfaceDatos<PUESTOS>
    {
        SADDEXEntities context;

        public PuestoAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void Agregar_D(PUESTOS obj)
        {
            this.context.PUESTOS.Add(obj);
        }

        public void Eliminar_D(PUESTOS obj)
        {
            var puesto = context.PUESTOS.Where(puest => puest.ID_PUESTO == obj.ID_PUESTO).FirstOrDefault();
            if (puesto != null)
            {
                this.context.PUESTOS.Remove(puesto);
            }
        }

        public void Modificar_D(PUESTOS obj)
        {
            var puesto = context.PUESTOS.Where(puest => puest.ID_PUESTO == obj.ID_PUESTO).FirstOrDefault();
            if (puesto != null)
            {
                puesto.NOMBRE_PUESTO = obj.NOMBRE_PUESTO;
                puesto.DETALLE_PUESTO = obj.DETALLE_PUESTO;
            }
        }

        public IEnumerable<PUESTOS> devolverLISTA_D()
        {
            return this.context.PUESTOS;
        }

        public PUESTOS buscarporID(int id)
        {
            return this.context.PUESTOS.Where(puest => puest.ID_PUESTO == id).FirstOrDefault();
        }
    }
}
