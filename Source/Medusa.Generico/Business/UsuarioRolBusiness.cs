using System;
using System.Collections.Generic;
using Medusa.Generico.Core.DataInterfaces;
using Medusa.Generico.Domain;
using Medusa.Base.Business;

namespace Medusa.Generico.Business
{
    public class UsuarioRolBusiness : AbstractBusiness<IUsuarioRolDao, UsuarioRol, UsuarioRol.DomainObjectID>
    {
        public UsuarioRolBusiness(IUsuarioRolDao dao) : base(dao)
        {

        }
    }
}
