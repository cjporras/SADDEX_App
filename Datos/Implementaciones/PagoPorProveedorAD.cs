using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
  public  class PagoPorProveedorAD
    {
        SADDEXEntities context;

        public PagoPorProveedorAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void AgregarAD(PAGOS_X_PROVEEDORES obj)
        {
            this.context.PAGOS_X_PROVEEDORES.Add(obj);
        }

        public void EliminarAD(PAGOS_X_PROVEEDORES obj)
        {
            var pagoProveedor = context.PAGOS_X_PROVEEDORES.Where(com => com.ID_PAGO_X_PROVEEDOR == obj.ID_PAGO_X_PROVEEDOR).FirstOrDefault();
            if (pagoProveedor != null)
            {
                this.context.PAGOS_X_PROVEEDORES.Remove(pagoProveedor);
            }
        }

        public void ModificarAD(PAGOS_X_PROVEEDORES obj)
        {
            var pagoProveedor = context.PAGOS_X_PROVEEDORES.Where(com => com.ID_PAGO_X_PROVEEDOR == obj.ID_PAGO_X_PROVEEDOR).FirstOrDefault();
            if (pagoProveedor != null)
            {
                pagoProveedor.FK_NOMBRE_PROVEEDOR = obj.FK_NOMBRE_PROVEEDOR;
                pagoProveedor.MONTO_CHEQUE = obj.MONTO_CHEQUE;
                pagoProveedor.FECHA_CHEQUE = obj.FECHA_CHEQUE;
                pagoProveedor.NUMERO_CHEQUE = obj.NUMERO_CHEQUE;
                pagoProveedor.FK_USUARIO = obj.FK_USUARIO;
            }
        }

        public IEnumerable<PAGOS_X_PROVEEDORES> obtenerListaAD()
        {
            return this.context.PAGOS_X_PROVEEDORES;
        }

        public PAGOS_X_PROVEEDORES obtenerPorID_AD(int id)
        {
            return this.context.PAGOS_X_PROVEEDORES.Where(com => com.ID_PAGO_X_PROVEEDOR == id).FirstOrDefault();
        }
    }
}
