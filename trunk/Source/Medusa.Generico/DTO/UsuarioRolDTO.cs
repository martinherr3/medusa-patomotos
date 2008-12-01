﻿using System;
using System.Collections.Generic;
using Medusa.Base.Domain;

namespace Medusa.Generico.DTO
{
    /// <summary>
    /// UsuarioRol object for NHibernate mapped table UsuarioRol.
    /// </summary>
    [Serializable]
    public class UsuarioRolDTO : DomainObject<UsuarioRolDTO.DomainObjectID>
    {

        [Serializable]
        public class DomainObjectID
        {
            public DomainObjectID() { }

            private System.Int64 _IdUsuario;
            private System.Int64 _IdRol;

            public DomainObjectID(System.Int64 idUsuario, System.Int64 idRol)
            {
                _IdUsuario = idUsuario;
                _IdRol = idRol;
            }

            public System.Int64 IdUsuario
            {
                get { return _IdUsuario; }
                protected set { _IdUsuario = value; }
            }

            public System.Int64 IdRol
            {
                get { return _IdRol; }
                protected set { _IdRol = value; }
            }


            public override bool Equals(object obj)
            {
                if (obj == this) return true;
                if (obj == null) return false;

                DomainObjectID that = obj as DomainObjectID;
                if (that == null)
                {
                    return false;
                }
                else
                {
                    if (this.IdUsuario != that.IdUsuario) return false;
                    if (this.IdRol != that.IdRol) return false;

                    return true;
                }

            }

            public override int GetHashCode()
            {
                return IdUsuario.GetHashCode() ^ IdRol.GetHashCode();
            }

        }

        private RolDTO _IdRolLookup;
        private UsuarioDTO _IdUsuarioLookup;

        public UsuarioRolDTO()
        {
        }

        public UsuarioRolDTO(DomainObjectID id)
        {
            base.ID = id;
        }

        public virtual System.Int64 IdUsuario
        {
            get { return base.id.IdUsuario; }
        }

        public virtual System.Int64 IdRol
        {
            get { return base.id.IdRol; }
        }

        public virtual RolDTO IdRolLookup
        {
            get { return _IdRolLookup; }
            set { _IdRolLookup = value; }
        }

        public virtual UsuarioDTO IdUsuarioLookup
        {
            get { return _IdUsuarioLookup; }
            set { _IdUsuarioLookup = value; }
        }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

    }
}
