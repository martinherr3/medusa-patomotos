using System;
using System.Collections.Generic;
using Medusa.Generico.Core.DataInterfaces;
using Medusa.Generico.Domain;
using Medusa.Base.Business;

namespace Medusa.Generico.Business
{
    public class RolBusiness : AbstractBusiness<IRolDao, Rol, System.Int64>
    {
        public RolBusiness(IRolDao dao) : base(dao)
        {

        }
    }
}
