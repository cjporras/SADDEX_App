using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
 public   class ProveedorAD
    {
        SADDEXEntities context;

        public ProveedorAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void AgregarAD(PROVEEDORES obj)
        {
            this.context.PROVEEDORES.Add(obj);
        }

        public void EliminarAD(PROVEEDORES obj)
        {
            var proveedor = context.PROVEEDORES.Where(com => com.ID_PROVEEDOR == obj.ID_PROVEEDOR).FirstOrDefault();
            if (proveedor != null)
            {
                this.context.PROVEEDORES.Remove(proveedor);
            }
        }

        public void ModificarAD(PROVEEDORES obj)
        {
            var proveedor = context.PROVEEDORES.Where(com => com.ID_PROVEEDOR == obj.ID_PROVEEDOR).FirstOrDefault();
            if (proveedor != null)
            {
                proveedor.NOMBRE_PROVEEDOR = obj.NOMBRE_PROVEEDOR;
                proveedor.UBICACION = obj.UBICACION;
                proveedor.TELEFONO_1 = obj.TELEFONO_1;
                proveedor.TELEFONO_2 = obj.TELEFONO_2;
                proveedor.CEDULA_JURIDICA = obj.CEDULA_JURIDICA;
            }
        }

        public IEnumerable<PROVEEDORES> obtenerListaAD()
        {
            return this.context.PROVEEDORES;
        }

        public PROVEEDORES obtenerPorID_AD(int id)
        {
            return this.context.PROVEEDORES.Where(com => com.ID_PROVEEDOR == id).FirstOrDefault();
        }
    }
}
