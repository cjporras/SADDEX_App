using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Interface
{
    public interface clsInterfaceLogica<T>
    {
        void Agregar_L(T obj);
        void Modificar_L(T obj);
        void Eliminar_L(T obj);
        IEnumerable<T> devolverLISTA_L();
        T buscarporID_L(int id);
    }
}
