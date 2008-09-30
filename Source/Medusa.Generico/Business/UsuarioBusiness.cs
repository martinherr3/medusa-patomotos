using System;
using System.Collections.Generic;
using Medusa.Generico.Core.DataInterfaces;
using Medusa.Generico.Domain;
using Medusa.Base.Business;

namespace Medusa.Generico.Business
{
    public class UsuarioBusiness : AbstractBusiness<IUsuarioDao, Usuario, System.Int64>
    {
        public UsuarioBusiness(IUsuarioDao dao) : base(dao)
        {

        }
    }
}
