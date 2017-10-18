using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
 public   class EstadoTramiteAD : clsInterfaceDatos<ESTADO_TRAMITES>
    {
        SADDEXEntities context;

        public EstadoTramiteAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void Agregar_D(ESTADO_TRAMITES obj)
        {
            this.context.ESTADO_TRAMITES.Add(obj);
        }

        public void Eliminar_D(ESTADO_TRAMITES obj)
        {
            var estadoTramite = context.ESTADO_TRAMITES.Where(com => com.ID_ESTADO_TRAMITE == obj.ID_ESTADO_TRAMITE).FirstOrDefault();
            if (estadoTramite != null)
            {
                this.context.ESTADO_TRAMITES.Remove(estadoTramite);
            }
        }

        public void Modificar_D(ESTADO_TRAMITES obj)
        {
            var estadoTramite = context.ESTADO_TRAMITES.Where(com => com.ID_ESTADO_TRAMITE == obj.ID_ESTADO_TRAMITE).FirstOrDefault();
            if (estadoTramite != null)
            {
                estadoTramite.ESTADO_DOCUMENTO_PERITO = obj.ESTADO_DOCUMENTO_PERITO;
                estadoTramite.ESTADO_SOLICITUD = obj.ESTADO_SOLICITUD;
                estadoTramite.ESTADO_PERMISO_CONSTRUCCION = obj.ESTADO_PERMISO_CONSTRUCCION;
                estadoTramite.ESTADO_ARQUITECTURA = obj.ESTADO_ARQUITECTURA;
                estadoTramite.ESTADO_BANHVI = obj.ESTADO_BANHVI;
                estadoTramite.ESTADO_MUCAP = obj.ESTADO_MUCAP;
                estadoTramite.DIS = obj.DIS;
                estadoTramite.DESEMBOLSOS = obj.DESEMBOLSOS;
                estadoTramite.CASOS_FORMALIZADOS = obj.CASOS_FORMALIZADOS;
                estadoTramite.APC = obj.APC;
            }
        }
    
        public IEnumerable<ESTADO_TRAMITES> devolverLISTA_D()
        {
            return this.context.ESTADO_TRAMITES;
        }

        public ESTADO_TRAMITES buscarporID(int id)
        {
            return this.context.ESTADO_TRAMITES.Where(com => com.ID_ESTADO_TRAMITE == id).FirstOrDefault();
        }
    }
}
