using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
 public class UbicacionExpedienteAD : clsInterfaceDatos<UBICACION_EXPEDIENTES>
    {
        SADDEXEntities context;

        public UbicacionExpedienteAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void Agregar_D(UBICACION_EXPEDIENTES obj)
        {
            this.context.UBICACION_EXPEDIENTES.Add(obj);
        }

        public void Eliminar_D(UBICACION_EXPEDIENTES obj)
        {
            var ubicacion = context.UBICACION_EXPEDIENTES.Where(ubc_exp => ubc_exp.ID_UBICACION_EXPEIENTE == obj.ID_UBICACION_EXPEIENTE).FirstOrDefault();
            if (ubicacion != null)
            {
                this.context.UBICACION_EXPEDIENTES.Remove(ubicacion);
            }
        }

        public void Modificar_D(UBICACION_EXPEDIENTES obj)
        {
            var ubicacion = context.UBICACION_EXPEDIENTES.Where(ubc_exp => ubc_exp.ID_UBICACION_EXPEIENTE == obj.ID_UBICACION_EXPEIENTE).FirstOrDefault();
            if (ubicacion != null)
            {
                ubicacion.NOMBRE_UBICACION = obj.NOMBRE_UBICACION;
                ubicacion.FK_USUARIO = obj.FK_USUARIO;
                ubicacion.DETALLE_UBICACION = obj.DETALLE_UBICACION;
                ubicacion.FK_EXPEDIENTE = obj.FK_EXPEDIENTE;
            }
        }

        public IEnumerable<UBICACION_EXPEDIENTES> devolverLISTA_D()
        {
            return this.context.UBICACION_EXPEDIENTES;
        }

        public UBICACION_EXPEDIENTES buscarporID(int id)
        {
            return this.context.UBICACION_EXPEDIENTES.Where(ubc_exp => ubc_exp.ID_UBICACION_EXPEIENTE == id).FirstOrDefault();
        }
    }
}
