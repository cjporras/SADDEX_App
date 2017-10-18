using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
  public class ClienteAD : clsInterfaceDatos<CLIENTES>
    {

        SADDEXEntities context;

        public ClienteAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void Agregar_D(CLIENTES obj)
        {
            this.context.CLIENTES.Add(obj);
        }

        public void Eliminar_D(CLIENTES obj)
        {
            var cliente = context.CLIENTES.Where(com => com.ID_CLIENTE == obj.ID_CLIENTE).FirstOrDefault();
            if (cliente != null)
            {
                this.context.CLIENTES.Remove(cliente);
            }
        }

        public void Modificar_D(CLIENTES obj)
        {
            var cliente = context.CLIENTES.Where(com => com.ID_CLIENTE == obj.ID_CLIENTE).FirstOrDefault();
            if (cliente != null)
            {
                cliente.CEDULA = obj.CEDULA;
                cliente.NOMBRE_COMPLETO = obj.NOMBRE_COMPLETO;
                cliente.PRIMER_APELLIDO = obj.PRIMER_APELLIDO;
                cliente.SEGUNDO_APELLIDO = obj.SEGUNDO_APELLIDO;
                cliente.PROVINCIA = obj.PROVINCIA;
                cliente.CANTON = obj.CANTON;
                cliente.DISTRITO = obj.DISTRITO;
                cliente.OTRAS_SEÑAS = obj.OTRAS_SEÑAS;
                cliente.CORREO_ELECTRONICO = obj.CORREO_ELECTRONICO;
                cliente.NACIONALIDAD = obj.NACIONALIDAD;
                cliente.TELEFONO_1 = obj.TELEFONO_1;
                cliente.TELEFONO_2 = obj.TELEFONO_2;
            }
        }

        public IEnumerable<CLIENTES> devolverLISTA_D()
        {
            return this.context.CLIENTES;
        }

        public CLIENTES buscarporID(int id)
        {
            return this.context.CLIENTES.Where(com => com.ID_CLIENTE == id).FirstOrDefault();
        }
    }
}
