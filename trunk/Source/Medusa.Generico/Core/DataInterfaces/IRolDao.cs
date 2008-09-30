using System;
using System.Collections.Generic;
using Medusa.Generico.Domain;
using Medusa.Base.Data;

namespace Medusa.Generico.Core.DataInterfaces
{
    /// <summary>
    /// Since this extends the <see cref="IDao{TypeOfListItem, IdT}" /> behavior, it's a good idea to 
    /// place it in its own file for manageability.  In this way, it can grow further without
    /// cluttering up <see cref="IDaoFactory" />.
    /// </summary>
    public interface IRolDao : IDao<Rol, System.Int64>
    {

    }
}
