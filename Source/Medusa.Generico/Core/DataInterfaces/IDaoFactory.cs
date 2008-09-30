using System;
using System.Collections.Generic;

namespace Medusa.Generico.Core.DataInterfaces
{
    public interface IDaoFactory
    {
        IRolDao GetRolDao();
        IUsuarioDao GetUsuarioDao();
        IUsuarioRolDao GetUsuarioRolDao();
    }
}
