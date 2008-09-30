using System;
using System.Collections.Generic;
using Medusa.Generico.Core.DataInterfaces;
using Medusa.Generico.Domain;
using Medusa.Base.Data;

namespace Medusa.Generico.Data
{
    public class UsuarioRolDao : AbstractNHibernateDao<UsuarioRol, UsuarioRol.DomainObjectID>, IUsuarioRolDao
    {
        public UsuarioRolDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
