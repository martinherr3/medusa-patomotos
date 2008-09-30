using System;
using System.Collections.Generic;
using Medusa.Generico.Core.DataInterfaces;
using Medusa.Generico.Domain;
using Medusa.Base.Data;

namespace Medusa.Generico.Data
{
    public class RolDao : AbstractNHibernateDao<Rol, System.Int64>, IRolDao
    {
        public RolDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
