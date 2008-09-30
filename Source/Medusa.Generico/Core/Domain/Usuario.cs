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
        private IList<UsuarioRol> _Rols = new List<UsuarioRol>();

        public Usuario()
        {
        }

        public Usuario(System.Int64 id)
        {
            base.ID = id;
        }

         public virtual System.String Nombre {
             get { return _Nombre; }
             set { _Nombre = value;}
         }

         public virtual System.String Password {
             get { return _Password; }
             set { _Password = value;}
         }

         public virtual IList<UsuarioRol> Rols{
             get { return _Rols; }
             set { _Rols = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
