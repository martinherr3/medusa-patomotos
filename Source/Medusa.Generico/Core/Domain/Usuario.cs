using System;
using System.Collections.Generic;
using Medusa.Base.Domain;

namespace Medusa.Generico.Domain
{
    /// <summary>
    /// Usuario object for NHibernate mapped table Usuario.
    /// </summary>
    [Serializable]
    public class Usuario : DomainObject<System.Int64>
    {


        private System.String _Nombre;
        private System.String _Password;
        private System.Boolean? _Activo;
        private System.Boolean? _ForzarExpiracion;
        private System.Int32? _CantidadDias;
        private System.DateTime? _ProximaFechaExpiracion;
        private System.DateTime? _MSTS;
        private IList<UsuarioRol> _Rols = new List<UsuarioRol>();

        public Usuario()
        {
        }

        public Usuario(System.Int64 id)
        {
            base.ID = id;
        }

        public virtual System.String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public virtual System.String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public virtual System.Boolean? Activo
        {
            get { return _Activo; }
            set { _Activo = value; }
        }

        public virtual System.Boolean? ForzarExpiracion
        {
            get { return _ForzarExpiracion; }
            set { _ForzarExpiracion = value; }
        }

        public virtual System.Int32? CantidadDias
        {
            get { return _CantidadDias; }
            set { _CantidadDias = value; }
        }

        public virtual System.DateTime? ProximaFechaExpiracion
        {
            get { return _ProximaFechaExpiracion; }
            set { _ProximaFechaExpiracion = value; }
        }

        public virtual System.DateTime? MSTS
        {
            get { return _MSTS; }
            set { _MSTS = value; }
        }

        public virtual IList<UsuarioRol> Rols
        {
            get { return _Rols; }
            set { _Rols = value; }
        }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

    }
}
