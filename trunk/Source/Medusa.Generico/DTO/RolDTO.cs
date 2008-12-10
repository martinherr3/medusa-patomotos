using System;
using System.Collections.Generic;
using Medusa.Base.Domain;

namespace Medusa.Generico.DTO
{
    /// <summary>
    /// Rol object for NHibernate mapped table Rol.
    /// </summary>
    [Serializable]
    public class RolDTO : DomainObject<System.Int64>
    {


        private System.String _Nombre;
        private System.String _Descripcion;
        private List<UsuarioRolDTO> _Usuarios = new List<UsuarioRolDTO>();

        public RolDTO()
        {
        }

        public RolDTO(System.Int64 id)
        {
            base.ID = id;
        }

        public virtual System.String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public virtual System.String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public virtual List<UsuarioRolDTO> Usuarios
        {
            get { return _Usuarios; }
            set { _Usuarios = value; }
        }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

    }
}
