using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
 public   class ProveedorAD : clsInterfaceDatos<PROVEEDORES>
    {
        SADDEXEntities context;

        public ProveedorAD(SADDEXEntities context)
        {
            this.context = context;
        }

       public void Agregar_D(PROVEEDORES obj)
        {
            this.context.PROVEEDORES.Add(obj);
        }

        public void Modificar_D(PROVEEDORES obj)
        {
            //consulta para cuando se seleccione el id lo compare con el de la tabla de la base de datos
            var proveedor = context.PROVEEDORES.Where(prov => prov.ID_PROVEEDOR == obj.ID_PROVEEDOR).FirstOrDefault();
            if(proveedor != null)
            {
                proveedor.NOMBRE_PROVEEDOR = obj.NOMBRE_PROVEEDOR;
                proveedor.UBICACION = obj.UBICACION;
                proveedor.TELEFONO_1 = obj.TELEFONO_1;
                proveedor.TELEFONO_2 = obj.TELEFONO_2;
                proveedor.CEDULA_JURIDICA = obj.CEDULA_JURIDICA;
            }
        }

        public void Eliminar_D(PROVEEDORES obj)
        {
            var proveedor = context.PROVEEDORES.Where(prov => prov.ID_PROVEEDOR == obj.ID_PROVEEDOR).FirstOrDefault();
            if(proveedor != null)
            {
                this.context.PROVEEDORES.Remove(proveedor);
            }
        }

        public IEnumerable<PROVEEDORES> devolverLISTA_D()
        {
            return this.context.PROVEEDORES;
        }

        public PROVEEDORES buscarporID(int id)
        {
            return this.context.PROVEEDORES.Where(prov => prov.ID_PROVEEDOR == id).FirstOrDefault();
        }


        
    }
}
