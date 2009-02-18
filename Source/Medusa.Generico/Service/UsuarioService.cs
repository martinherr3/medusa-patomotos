
using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Generico.Business;
using Medusa.Generico.Domain;
using Medusa.Generico.DTO;
using Medusa.Generico.Assembler;
using Medusa.Architecture.CommonEntities;
using Medusa.Generico.Core.DataInterfaces;
using Medusa.Base.Utils;

namespace Medusa.Generico.Service
{
    /// <summary>
    /// Servicio para Borrar Usuario
    /// </summary>
    class UsuarioDeleteService : IBusinessService<UsuarioDTO, ResponseService<Int32>>
    {
        /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

        #region IBusinessService<UsuarioDTO,ResponseService<Int32>> Members

        public ResponseService<Int32> Execute(UsuarioDTO pServiceRequest)
        {
            ResponseService<Int32> wRes = new ResponseService<Int32>();
            try
            {
                UsuarioBusiness _UsuarioBusiness;
                _UsuarioBusiness = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
                Usuario myUsuario;
                myUsuario = AssemblerUsuario.DTOToEntity(pServiceRequest);
                _UsuarioBusiness.Delete(myUsuario);
                wRes.ServiceData = 1;
            }
            catch (Exception ex)
            {
                wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
            }
            return wRes;
        }


        #endregion
    }


    /// <summary>
    /// Servicio para agregar Usuario
    /// </summary>
    class UsuarioSaveService : IBusinessService<UsuarioDTO, ResponseService<Int32>>
    {
        /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

        #region IBusinessService<UsuarioDTO,ResponseService<Int32>> Members

        public ResponseService<Int32> Execute(UsuarioDTO pServiceRequest)
        {
            ResponseService<Int32> wRes = new ResponseService<Int32>();
            try
            {
                UsuarioBusiness _UsuarioBusiness;
                _UsuarioBusiness = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
                Usuario myUsuario;
                myUsuario = AssemblerUsuario.DTOToEntity(pServiceRequest);
                _UsuarioBusiness.Insert(myUsuario);
                wRes.ServiceData = 1;
            }
            catch (Exception ex)
            {
                wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
            }
            return wRes;

        }

        #endregion
    }


    /// <summary>
    /// Servicio para consultar Usuario por su ID
    /// </summary>
    class UsuarioGetByIdService : IBusinessService<Int32, ResponseService<UsuarioDTO>>
    {
        /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

        #region IBusinessService<Int32,ResponseService<UsuarioDTO>> Members
        public ResponseService<UsuarioDTO> Execute(Int32 pServiceRequest)
        {
            ResponseService<UsuarioDTO> wRes = new ResponseService<UsuarioDTO>();
            try
            {
                UsuarioBusiness _UsuarioBusiness;
                _UsuarioBusiness = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
                UsuarioDTO _UsuarioReturn;

                _UsuarioReturn = AssemblerUsuario.EntityToDTO(_UsuarioBusiness.GetById(pServiceRequest));

                wRes.ServiceData = _UsuarioReturn;
            }
            catch (Exception ex)
            {
                wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
            }
            return wRes;


        }
        #endregion
    }


    /// <summary>
    /// Servicio para traer todos los usuarios
    /// </summary>
    class UsuarioGetAll : IBusinessService<UsuarioDTO, ResponseService<List<UsuarioDTO>>>
    {
        /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

        #region IBusinessService<UsuarioDTO,ResponseService<List<UsuarioDTO>>> Members
        public ResponseService<List<UsuarioDTO>> Execute(UsuarioDTO pServiceRequest)
        {
            ResponseService<List<UsuarioDTO>> wRes = new ResponseService<List<UsuarioDTO>>();
            try
            {
                UsuarioBusiness _UsuarioBusiness;
                _UsuarioBusiness = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
                List<Usuario> _Usuarios = _UsuarioBusiness.GetAll();
                List<UsuarioDTO> _UsuariosReturn = new List<UsuarioDTO>();
                foreach (Usuario item in _Usuarios)
                {
                    _UsuariosReturn.Add(AssemblerUsuario.EntityToDTO(item));
                }

                wRes.ServiceData = _UsuariosReturn;
            }
            catch (Exception ex)
            {
                wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
            }
            return wRes;


        }
        #endregion
    }


    /// <summary>
    /// Servicio para modificar Usuario
    /// </summary>
    class UsuarioUpdateService : IBusinessService<UsuarioDTO, ResponseService<Int32>>
    {
        /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

        #region IBusinessService<UsuarioDTO,ResponseService<Int32>> Members

        public ResponseService<Int32> Execute(UsuarioDTO pServiceRequest)
        {
            ResponseService<Int32> wRes = new ResponseService<Int32>();
            try
            {
                UsuarioBusiness _UsuarioBusiness;
                _UsuarioBusiness = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
                Usuario myUsuario;
                myUsuario = AssemblerUsuario.DTOToEntity(pServiceRequest);
                _UsuarioBusiness.Update(myUsuario);
                wRes.ServiceData = 1;
            }
            catch (Exception ex)
            {
                wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
            }
            return wRes;

        }

        #endregion
    }


}
