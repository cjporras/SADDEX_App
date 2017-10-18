using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
 public  class FacturaAD : clsInterfaceDatos<FACTURAS>
    {
        SADDEXEntities context;

        public FacturaAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void Agregar_D(FACTURAS obj)
        {
            this.context.FACTURAS.Add(obj);
        }

        public void Eliminar_D(FACTURAS obj)
        {
            var factura = context.FACTURAS.Where(com => com.ID_FACTURA == obj.ID_FACTURA).FirstOrDefault();
            if (factura != null)
            {
                this.context.FACTURAS.Remove(factura);
            }
        }

        public void Modificar_D(FACTURAS obj)
        {
            var factura = context.FACTURAS.Where(com => com.ID_FACTURA == obj.ID_FACTURA).FirstOrDefault();
            if (factura != null)
            {
                factura.FK_CLIENTE = obj.FK_CLIENTE;
                factura.FK_PROVEEDOR = obj.FK_PROVEEDOR;
                factura.FK_OUTSOURCING = obj.FK_OUTSOURCING;
                factura.FK_USUARIO = obj.FK_USUARIO;
                factura.SUB_TOTAL = obj.SUB_TOTAL;
                factura.TOTAL = obj.TOTAL;
                factura.IMPUESTOS = obj.IMPUESTOS;
                factura.DETALLE = obj.DETALLE;
                factura.CONCEPTO = obj.CONCEPTO;
                factura.FECHA_FACTURA = obj.FECHA_FACTURA;
            }
        }

        public IEnumerable<FACTURAS> devolverLISTA_D()
        {
            return this.context.FACTURAS;
        }

        public FACTURAS buscarporID(int id)
        {
            return this.context.FACTURAS.Where(com => com.ID_FACTURA == id).FirstOrDefault();
        }
    }
}
