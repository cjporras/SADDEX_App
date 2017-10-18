using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
  public  class ListaOutsourcingAD : clsInterfaceDatos<LISTAS_OUTSOURCING>
    {
        SADDEXEntities context;

        public ListaOutsourcingAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void Agregar_D(LISTAS_OUTSOURCING obj)
        {
            this.context.LISTAS_OUTSOURCING.Add(obj);
        }

        public void Eliminar_D(LISTAS_OUTSOURCING obj)
        {
            var listaOutsourcing = context.LISTAS_OUTSOURCING.Where(com => com.ID_LISTA_OUTSOURCING == obj.ID_LISTA_OUTSOURCING).FirstOrDefault();
            if (listaOutsourcing != null)
            {
                this.context.LISTAS_OUTSOURCING.Remove(listaOutsourcing);
            }
        }

        public void Modificar_D(LISTAS_OUTSOURCING obj)
        {
            var listaOutsourcing = context.LISTAS_OUTSOURCING.Where(com => com.ID_LISTA_OUTSOURCING == obj.ID_LISTA_OUTSOURCING).FirstOrDefault();
            if (listaOutsourcing != null)
            {
                listaOutsourcing.NOMBRE_SERVICIO = obj.NOMBRE_SERVICIO;
                listaOutsourcing.SALARIO = obj.SALARIO;
            }
        }

        public IEnumerable<LISTAS_OUTSOURCING> devolverLISTA_D()
        {
            return this.context.LISTAS_OUTSOURCING;
        }

        public LISTAS_OUTSOURCING buscarporID(int id)
        {
            return this.context.LISTAS_OUTSOURCING.Where(com => com.ID_LISTA_OUTSOURCING == id).FirstOrDefault();
        }
    }
}
