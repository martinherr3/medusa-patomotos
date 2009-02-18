using System;
using System.Collections.Generic;
using Medusa.Base.Domain;
using Medusa.Architecture.ServiceInterfaceWrappers;
using Medusa.Architecture.CommonEntities;

namespace Medusa.Generico.DTO
{
    /// <summary>
    /// Usuario object for NHibernate mapped table Usuario.
    /// </summary>
    [Serializable]
    public class UsuarioDTO : DomainObject<System.Int64>
    {


        private System.String _Nombre;
        private System.String _Password;
        private System.Boolean? _Activo;
        private System.Boolean? _ForzarExpiracion;
        private System.Int32? _CantidadDias;
        private System.DateTime? _ProximaFechaExpiracion;
        private System.DateTime? _MSTS;
        private List<UsuarioRolDTO> _Rols = new List<UsuarioRolDTO>();

        public UsuarioDTO()
        {
        }

        public UsuarioDTO(System.Int64 id)
        {
            base.ID = id;
        }

        public virtual System.String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public virtual System.String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public virtual System.Boolean? Activo
        {
            get { return _Activo; }
            set { _Activo = value; }
        }

        public virtual System.Boolean? ForzarExpiracion
        {
            get { return _ForzarExpiracion; }
            set { _ForzarExpiracion = value; }
        }

        public virtual System.Int32? CantidadDias
        {
            get { return _CantidadDias; }
            set { _CantidadDias = value; }
        }

        public virtual System.DateTime? ProximaFechaExpiracion
        {
            get { return _ProximaFechaExpiracion; }
            set { _ProximaFechaExpiracion = value; }
        }

        public virtual System.DateTime? MSTS
        {
            get { return _MSTS; }
            set { _MSTS = value; }
        }

        public virtual List<UsuarioRolDTO> Rols
        {
            get { return _Rols; }
            set { _Rols = value; }
        }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        /// <summary>
        /// Inserta Usuario.
        /// </summary>
        /// <returns></returns>
        public Int32 Insertar()
        {
            ResponseService<Int32> wResul = new Wrapper().ExecuteService<UsuarioDTO, ResponseService<Int32>>("BDUsuarioInsertService", this);
            if (wResul.ServiceError.HasError)
            { 
                throw new Exception(wResul.ServiceError.Mensaje);
            }
            else
            {
                return wResul.ServiceData;
            }

        }

        /// <summary>
        /// Elimina Usuario.
        /// </summary>
        /// <returns></returns>
        public Int32 Eliminar()
        {
            ResponseService<Int32> wResul = new Wrapper().ExecuteService<UsuarioDTO, ResponseService<Int32>>("BDUsuarioDeleteService", this);
            if (wResul.ServiceError.HasError)
            {
                throw new Exception(wResul.ServiceError.Mensaje);
            }
            else
            {
                return wResul.ServiceData;
            }
        }

        /// <summary>
        /// Modifica Usuario.
        /// </summary>
        /// <returns></returns>
        public Int32 Modificar()
        {
            ResponseService<Int32> wResul = new Wrapper().ExecuteService<UsuarioDTO, ResponseService<Int32>>("BDUsuarioUpdateService", this);
            if (wResul.ServiceError.HasError)
            {
                throw new Exception(wResul.ServiceError.Mensaje);
            }
            else
            {
                return wResul.ServiceData;
            }
        }

        /// <summary>
        /// Llena una lista de Usuarios.
        /// </summary>
        /// <param name="pEntidad">Criterio de filtro.</param>
        public List<UsuarioDTO> GetAll()
        {

            ResponseService<List<UsuarioDTO>> wResul = new Wrapper().ExecuteService<UsuarioDTO, ResponseService<List<UsuarioDTO>>>("BDUsuarioSearchService", this);
            if (wResul.ServiceError.HasError)
            {
                throw new Exception(wResul.ServiceError.Mensaje);
            }
            else
            {
                return wResul.ServiceData;
            }
        }

        /// <summary>
        /// Devuelve una entidad segun el ID.
        /// </summary>
        /// <param name="pEntidad">Criterio de filtro.</param>
        public void GetById()
        {

            ResponseService<UsuarioDTO> wResul = new Wrapper().ExecuteService<long, ResponseService<UsuarioDTO>>("BDUsuarioSearchByIdService", this.ID);
            if (wResul.ServiceError.HasError)
            {
                throw new Exception(wResul.ServiceError.Mensaje);
            }
            else
            {
                this.ID = wResul.ServiceData.ID;
                this.Nombre = wResul.ServiceData.Nombre;
                this.Password = wResul.ServiceData.Password;
                this.Activo = wResul.ServiceData.Activo;
                this.CantidadDias = wResul.ServiceData.CantidadDias;
                this.ForzarExpiracion = wResul.ServiceData.ForzarExpiracion;
                this.ProximaFechaExpiracion = wResul.ServiceData.ProximaFechaExpiracion;
                this.Rols = wResul.ServiceData.Rols;
            }
        }
    }
}
