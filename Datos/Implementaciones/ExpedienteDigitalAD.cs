using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
    public class ExpedienteDigitalAD : clsInterfaceDatos<EXPEDIENTES_DIGITALES>
    {

        SADDEXEntities context;

        public ExpedienteDigitalAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void Agregar_D(EXPEDIENTES_DIGITALES obj)
        {
            this.context.EXPEDIENTES_DIGITALES.Add(obj);
        }

        public void Eliminar_D(EXPEDIENTES_DIGITALES obj)
        {
            var expedienteDigital = context.EXPEDIENTES_DIGITALES.Where(com => com.ID_EXPEDIENTE_DIGITAL == obj.ID_EXPEDIENTE_DIGITAL).FirstOrDefault();
            if (expedienteDigital != null)
            {
                this.context.EXPEDIENTES_DIGITALES.Remove(expedienteDigital);
            }
        }

        public void Modificar_D(EXPEDIENTES_DIGITALES obj)
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

        public IEnumerable<EXPEDIENTES_DIGITALES> devolverLISTA_D()
        {
            return this.context.EXPEDIENTES_DIGITALES;
        }

        public EXPEDIENTES_DIGITALES buscarporID(int id)
        {
            return this.context.EXPEDIENTES_DIGITALES.Where(com => com.ID_EXPEDIENTE_DIGITAL == id).FirstOrDefault();
        }
    }
}
