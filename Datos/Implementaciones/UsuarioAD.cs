using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos.Interface;

namespace Datos.Implementaciones
{
 public class UsuarioAD : clsInterfaceDatos<USUARIOS>
    {
        SADDEXEntities context;

        public UsuarioAD(SADDEXEntities context)
        {
            this.context = context;
        }

        public void Agregar_D(USUARIOS obj)
        {
            this.context.USUARIOS.Add(obj);
        }

        public void Eliminar_D(USUARIOS obj)
        {
            var usuario = context.USUARIOS.Where(usu => usu.ID_USUARIO == obj.ID_USUARIO).FirstOrDefault();
            if (usuario != null)
            {
                this.context.USUARIOS.Remove(usuario);
            }
        }

        public void Modificar_D(USUARIOS obj)
        {
            var usuario = context.USUARIOS.Where(usu => usu.ID_USUARIO == obj.ID_USUARIO).FirstOrDefault();
            if (usuario != null)
            {
                usuario.NOMBRE_USUARIO = obj.NOMBRE_USUARIO;
                usuario.CONTRASEÑA = obj.CONTRASEÑA;
                usuario.FK_FUNCIONARIO = obj.FK_FUNCIONARIO;
            }
        }

        public IEnumerable<USUARIOS> devolverLISTA_D()
        {
            return this.context.USUARIOS;
        }

        public USUARIOS buscarporID(int id)
        {
            return this.context.USUARIOS.Where(usu => usu.ID_USUARIO == id).FirstOrDefault();
        }

        public USUARIOS validarIngreso_DD(USUARIOS usuario)
        {
            return this.context.USUARIOS.FirstOrDefault(usu => usu.NOMBRE_USUARIO.Equals(usuario.NOMBRE_USUARIO) && usu.CONTRASEÑA.Equals(usuario.CONTRASEÑA));
        }

    }
}
