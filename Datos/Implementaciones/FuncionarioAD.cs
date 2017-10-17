using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
 public  class FuncionarioAD
    {
        SADDEXEntities context;

        public FuncionarioAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void AgregarAD(FUNCIONARIOS obj)
        {
            this.context.FUNCIONARIOS.Add(obj);
        }

        public void EliminarAD(FUNCIONARIOS obj)
        {
            var funcionario = context.FUNCIONARIOS.Where(com => com.ID_FUNCIONARIO == obj.ID_FUNCIONARIO).FirstOrDefault();
            if (funcionario != null)
            {
                this.context.FUNCIONARIOS.Remove(funcionario);
            }
        }

        public void ModificarAD(FUNCIONARIOS obj)
        {
            var funcionario = context.FUNCIONARIOS.Where(com => com.ID_FUNCIONARIO == obj.ID_FUNCIONARIO).FirstOrDefault();
            if (funcionario != null)
            {
                funcionario.CEDULA = obj.CEDULA;
                funcionario.NOMBRE_COMPLETO = obj.NOMBRE_COMPLETO;
                funcionario.PRIMER_APELLIDO = obj.PRIMER_APELLIDO;
                funcionario.SEGUNDO_APELLIDO = obj.SEGUNDO_APELLIDO;
                funcionario.FK_PUESTO = obj.FK_PUESTO;
                funcionario.PROVINCIA = obj.PROVINCIA;
                funcionario.CANTON = obj.CANTON;
                funcionario.DISTRITO = obj.DISTRITO;
                funcionario.OTRAS_SEÑAS = obj.OTRAS_SEÑAS;
                funcionario.CORREO_ELECTRONICO = obj.CORREO_ELECTRONICO;
                funcionario.NACIONALIDAD = obj.NACIONALIDAD;
                funcionario.FECHA_NACIMIENTO = obj.FECHA_NACIMIENTO;
                funcionario.FECHA_INGRESO = obj.FECHA_INGRESO;
                funcionario.TELEFONO_1 = obj.TELEFONO_1;
                funcionario.TELEFONO_2 = obj.TELEFONO_2;
            }
        }

        public IEnumerable<FUNCIONARIOS> obtenerListaAD()
        {
            return this.context.FUNCIONARIOS;
        }

        public FUNCIONARIOS obtenerPorID_AD(int id)
        {
            return this.context.FUNCIONARIOS.Where(com => com.ID_FUNCIONARIO == id).FirstOrDefault();
        }
    }
}
