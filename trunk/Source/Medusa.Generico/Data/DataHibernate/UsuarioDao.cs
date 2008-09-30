using System;
using System.Collections.Generic;
using Medusa.Generico.Core.DataInterfaces;
using Medusa.Generico.Domain;
using Medusa.Base.Data;

namespace Medusa.Generico.Data
{
    public class UsuarioDao : AbstractNHibernateDao<Usuario, System.Int64>, IUsuarioDao
    {
        public UsuarioDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
