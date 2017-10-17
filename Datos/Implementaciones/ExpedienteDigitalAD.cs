using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
   public class ExpedienteDigitalAD
    {

        SADDEXEntities context;

        public ExpedienteDigitalAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void AgregarAD(EXPEDIENTES_DIGITALES obj)
        {
            this.context.EXPEDIENTES_DIGITALES.Add(obj);
        }

        public void EliminarAD(EXPEDIENTES_DIGITALES obj)
        {
            var expedienteDigital = context.EXPEDIENTES_DIGITALES.Where(com => com.ID_EXPEDIENTE_DIGITAL == obj.ID_EXPEDIENTE_DIGITAL).FirstOrDefault();
            if (expedienteDigital != null)
            {
                this.context.EXPEDIENTES_DIGITALES.Remove(expedienteDigital);
            }
        }

        public void ModificarAD(EXPEDIENTES_DIGITALES obj)
        {
            var expedienteDigital = context.EXPEDIENTES_DIGITALES.Where(com => com.ID_EXPEDIENTE_DIGITAL == obj.ID_EXPEDIENTE_DIGITAL).FirstOrDefault();
            if (expedienteDigital != null)
            {
                expedienteDigital.FK_CATEGORIA_BONO = obj.FK_CATEGORIA_BONO;
                expedienteDigital.NOMBRE_EXPEDIENTE = obj.NOMBRE_EXPEDIENTE;
                expedienteDigital.FK_OBRA = obj.FK_OBRA;
                expedienteDigital.FK_USUARIO = obj.FK_USUARIO;
                expedienteDigital.FK_CLIENTE = obj.FK_CLIENTE;
            }
        }

        public IEnumerable<EXPEDIENTES_DIGITALES> obtenerListaAD()
        {
            return this.context.EXPEDIENTES_DIGITALES;
        }

        public EXPEDIENTES_DIGITALES obtenerPorID_AD(int id)
        {
            return this.context.EXPEDIENTES_DIGITALES.Where(com => com.ID_EXPEDIENTE_DIGITAL == id).FirstOrDefault();
        }
    }
}
