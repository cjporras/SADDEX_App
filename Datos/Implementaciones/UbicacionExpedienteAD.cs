using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
 public class UbicacionExpedienteAD
    {
        SADDEXEntities context;

        public UbicacionExpedienteAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void AgregarAD(UBICACION_EXPEDIENTES obj)
        {
            this.context.UBICACION_EXPEDIENTES.Add(obj);
        }

        public void EliminarAD(UBICACION_EXPEDIENTES obj)
        {
            var ubicacion = context.UBICACION_EXPEDIENTES.Where(com => com.ID_UBICACION_EXPEIENTE == obj.ID_UBICACION_EXPEIENTE).FirstOrDefault();
            if (ubicacion != null)
            {
                this.context.UBICACION_EXPEDIENTES.Remove(ubicacion);
            }
        }

        public void ModificarAD(UBICACION_EXPEDIENTES obj)
        {
            var ubicacion = context.UBICACION_EXPEDIENTES.Where(com => com.ID_UBICACION_EXPEIENTE == obj.ID_UBICACION_EXPEIENTE).FirstOrDefault();
            if (ubicacion != null)
            {
                ubicacion.NOMBRE_UBICACION = obj.NOMBRE_UBICACION;
                ubicacion.FK_USUARIO = obj.FK_USUARIO;
                ubicacion.DETALLE_UBICACION = obj.DETALLE_UBICACION;
                ubicacion.FK_EXPEDIENTE = obj.FK_EXPEDIENTE;
            }
        }

        public IEnumerable<UBICACION_EXPEDIENTES> obtenerListaAD()
        {
            return this.context.UBICACION_EXPEDIENTES;
        }

        public UBICACION_EXPEDIENTES obtenerPorID_AD(int id)
        {
            return this.context.UBICACION_EXPEDIENTES.Where(com => com.ID_UBICACION_EXPEIENTE == id).FirstOrDefault();
        }
    }
}
