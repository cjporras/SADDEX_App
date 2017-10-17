using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interface;
using Entidades;

namespace Datos.Implementaciones
{
 public   class UsuarioAD
    {
        SADDEXEntities context;

        public UsuarioAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void AgregarAD(USUARIOS obj)
        {
            this.context.USUARIOS.Add(obj);
        }

        public void EliminarAD(USUARIOS obj)
        {
            var usuario = context.USUARIOS.Where(com => com.ID_USUARIO == obj.ID_USUARIO).FirstOrDefault();
            if (usuario != null)
            {
                this.context.USUARIOS.Remove(usuario);
            }
        }

        public void ModificarAD(USUARIOS obj)
        {
            var usuario = context.USUARIOS.Where(com => com.ID_USUARIO == obj.ID_USUARIO).FirstOrDefault();
            if (usuario != null)
            {
                usuario.NOMBRE_USUARIO = obj.NOMBRE_USUARIO;
                usuario.CONTRASEÑA = obj.CONTRASEÑA;
                usuario.FK_FUNCIONARIO = obj.FK_FUNCIONARIO;
            }
        }

        public IEnumerable<USUARIOS> obtenerListaAD()
        {
            return this.context.USUARIOS;
        }

        public USUARIOS obtenerPorID_AD(int id)
        {
            return this.context.USUARIOS.Where(com => com.ID_USUARIO == id).FirstOrDefault();
        }
    }
}
