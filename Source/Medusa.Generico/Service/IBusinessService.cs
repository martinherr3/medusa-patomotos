using System;
using System.Collections.Generic;
using System.Text;

namespace Medusa.Generico.Service
{
    /// <summary>
    /// Interfaz que representa un servicio de negocio abstracto. Es la clase de la que deben heredar todas aquellas clases que sean implementaciones de servicios de negocio.
    /// </summary>
    /// <remarks>Las clases que heredan de esta Interfaz son las encargadas de orquestrar las llamadas a los distintos componentes de negocio y de la integración con otros sistemas.</remarks>
    public interface IBusinessService<TRequest, TResponse>
    {
        /// <summary>
        /// Ejecuta el servicio de negocio.
        /// </summary>
        /// <param name="pServiceRequest">Solicitud</param>
        TResponse Execute(TRequest pServiceRequest);
    }
}
