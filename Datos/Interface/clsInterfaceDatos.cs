using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interface
{
    public interface clsInterfaceDatos<T>
    {
        void Agregar_D(T obj);
        void Modificar_D(T obj);
        void Eliminar_D(T obj);
        IEnumerable<T> devolverLISTA_D();
        T buscarporID(int id);

    }
}
