using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
 public   class RequisitoInicialAD : clsInterfaceDatos<REQUISITOS_INICIALES>
    {
        SADDEXEntities context;

        public RequisitoInicialAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void Agregar_D(REQUISITOS_INICIALES obj)
        {
            this.context.REQUISITOS_INICIALES.Add(obj);
        }

        public void Eliminar_D(REQUISITOS_INICIALES obj)
        {
            var requisito = context.REQUISITOS_INICIALES.Where(req => req.ID_REQUISITO == obj.ID_REQUISITO).FirstOrDefault();
            if (requisito != null)
            {
                this.context.REQUISITOS_INICIALES.Remove(requisito);
            }
        }

        public void Modificar_D(REQUISITOS_INICIALES obj)
        {
            var requisito = context.REQUISITOS_INICIALES.Where(req => req.ID_REQUISITO == obj.ID_REQUISITO).FirstOrDefault();
            if (requisito != null)
            {
                requisito.COPIA_CEDULA = obj.COPIA_CEDULA;
                requisito.PROPIEDADES = obj.PROPIEDADES;
                requisito.COPIA_RECIBOS_SERVICIOS_PUBLICOS = obj.COPIA_RECIBOS_SERVICIOS_PUBLICOS;
                requisito.BONOS_ANTERIORES = obj.BONOS_ANTERIORES;
                requisito.CERTIFICACION_IMPUESTOS = obj.CERTIFICACION_IMPUESTOS;
                requisito.EXAMEN_POZO = obj.EXAMEN_POZO;
                requisito.CERTIFICACION_ESTADO_CIVIL = obj.CERTIFICACION_ESTADO_CIVIL;
                requisito.TERRENO_LOTE = obj.TERRENO_LOTE;
                requisito.REPORTE_SICERE = obj.REPORTE_SICERE;
                requisito.CONSTANCIA_CONTADOR = obj.CONSTANCIA_CONTADOR;
                requisito.CONSTANCIA_SALARIO = obj.CONSTANCIA_SALARIO;
                requisito.ASADA = obj.ASADA;
                requisito.FK_CLIENTE = obj.FK_CLIENTE;
                requisito.PLANO_CATASTRO = obj.PLANO_CATASTRO;
            }
        }

        public IEnumerable<REQUISITOS_INICIALES> devolverLISTA_D()
        {
            return this.context.REQUISITOS_INICIALES;
        }

        public REQUISITOS_INICIALES buscarporID(int id)
        {
            return this.context.REQUISITOS_INICIALES.Where(req => req.ID_REQUISITO == id).FirstOrDefault();
        }
    }
}
