
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


    //class UsuarioDeleteService : IBusinessService<Usuario, ResponseService<Int32>>
    //{
    //    /// <summary>
    //    /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
    //    /// </summary>
    //    public IDaoFactory DaoFactory
    //    {
    //        get
    //        {
    //            return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
    //        }
    //    }

    //    #region IBusinessService<Usuario,ResponseService<Int32>> Members

    //    public ResponseService<Int32> Execute(Usuario pServiceRequest)
    //    {
    //        ResponseService<Int32> wRes = new ResponseService<Int32>();
    //        try
    //        {
    //            UsuarioBusiness _UsuarioBusiness;
    //            _UsuarioBusiness = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
    //            Usuario myUsuario;
    //            myUsuario = TransformerUsuario.DTOToEntity(pServiceRequest);
    //            _UsuarioBusiness.Delete(myUsuario);
    //            wRes.ServiceData = 1;


    //            //wRes.ServiceData = UsuarioBC.Delete(pServiceRequest);
    //        }
    //        catch (Exception ex)
    //        {
    //            wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
    //        }
    //        return wRes;
    //    }


    //    #endregion
    //}


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
                _UsuarioBusiness.Delete(myUsuario);
                wRes.ServiceData = 1;
                //wRes.ServiceData = UsuarioBC.Save(pServiceRequest);
            }
            catch (Exception ex)
            {
                wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
            }
            return wRes;

        }

        #endregion
    }


    ///// <summary>
    ///// Servicio para consultar Usuario por atributos de la misma
    ///// </summary>
    //class UsuarioGetByEntityService : IBusinessService<Usuario, ResponseService<List<Usuario>>>
    //{
    //    /// <summary>
    //    /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
    //    /// </summary>
    //    public IDaoFactory DaoFactory
    //    {
    //        get
    //        {
    //            return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
    //        }
    //    }

    //    #region IBusinessService<Usuario,ResponseService<List<Usuario>>> Members
    //    public ResponseService<List<Usuario>> Execute(Usuario pServiceRequest)
    //    {
    //        ResponseService<List<Usuario>> wRes = new ResponseService<List<Usuario>>();
    //        try
    //        {
    //            UsuarioBusiness _UsuarioBusiness;
    //            _UsuarioBusiness = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
    //            Usuario myUsuario;
    //            myUsuario = TransformerUsuario.DTOToEntity(pServiceRequest);
    //            _UsuarioBusiness.Delete(myUsuario);
    //            wRes.ServiceData = 1;
    //            //wRes.ServiceData = UsuarioBC.GetByEntity(pServiceRequest);
    //        }
    //        catch (Exception ex)
    //        {
    //            wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
    //        }
    //        return wRes;


    //    }
    //    #endregion
    //}


    ///// <summary>
    ///// Servicio para consultar Usuario por su ID
    ///// </summary>
    //class UsuarioGetByIdService : IBusinessService<Int32, ResponseService<List<Usuario>>>
    //{
    //    /// <summary>
    //    /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
    //    /// </summary>
    //    public IDaoFactory DaoFactory
    //    {
    //        get
    //        {
    //            return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
    //        }
    //    }

    //    #region IBusinessService<Int32,ResponseService<List<Usuario>>> Members
    //    public ResponseService<List<Usuario>> Execute(Int32 pServiceRequest)
    //    {
    //        ResponseService<List<Usuario>> wRes = new ResponseService<List<Usuario>>();
    //        try
    //        {
    //            UsuarioBusiness _UsuarioBusiness;
    //            _UsuarioBusiness = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
    //            Usuario myUsuario;
    //            myUsuario = TransformerUsuario.DTOToEntity(pServiceRequest);
    //            _UsuarioBusiness.Delete(myUsuario);
    //            wRes.ServiceData = 1;
    //            //wRes.ServiceData = UsuarioBC.GetById(pServiceRequest);
    //        }
    //        catch (Exception ex)
    //        {
    //            wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
    //        }
    //        return wRes;


    //    }
    //    #endregion
    //}


    ///// <summary>
    ///// Servicio para consultar Usuario por su ID
    ///// </summary>
    //class UsuarioGetAll : IBusinessService<Int32, ResponseService<List<Usuario>>>
    //{
    //    /// <summary>
    //    /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
    //    /// </summary>
    //    public IDaoFactory DaoFactory
    //    {
    //        get
    //        {
    //            return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
    //        }
    //    }

    //    #region IBusinessService<Int32,ResponseService<List<Usuario>>> Members
    //    public ResponseService<List<Usuario>> Execute(Int32 pServiceRequest)
    //    {
    //        ResponseService<List<Usuario>> wRes = new ResponseService<List<Usuario>>();
    //        try
    //        {
    //            UsuarioBusiness _UsuarioBusiness;
    //            _UsuarioBusiness = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
    //            Usuario myUsuario;
    //            myUsuario = TransformerUsuario.DTOToEntity(pServiceRequest);
    //            _UsuarioBusiness.Delete(myUsuario);
    //            wRes.ServiceData = 1;
    //            //wRes.ServiceData = UsuarioBC.GetAll();
    //        }
    //        catch (Exception ex)
    //        {
    //            wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
    //        }
    //        return wRes;


    //    }
    //    #endregion
    //}


    ///// <summary>
    ///// Servicio para modificar Usuario
    ///// </summary>
    //class UsuarioUpdateService : IBusinessService<Usuario, ResponseService<Int32>>
    //{
    //    /// <summary>
    //    /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
    //    /// </summary>
    //    public IDaoFactory DaoFactory
    //    {
    //        get
    //        {
    //            return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
    //        }
    //    }

    //    #region IBusinessService<Usuario,ResponseService<Int32>> Members

    //    public ResponseService<Int32> Execute(Usuario pServiceRequest)
    //    {
    //        ResponseService<Int32> wRes = new ResponseService<Int32>();
    //        try
    //        {
    //            UsuarioBusiness _UsuarioBusiness;
    //            _UsuarioBusiness = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
    //            Usuario myUsuario;
    //            myUsuario = TransformerUsuario.DTOToEntity(pServiceRequest);
    //            _UsuarioBusiness.Delete(myUsuario);
    //            wRes.ServiceData = 1;
    //            //wRes.ServiceData = UsuarioBC.Update(pServiceRequest);
    //        }
    //        catch (Exception ex)
    //        {
    //            wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
    //        }
    //        return wRes;

    //    }

    //    #endregion
    //}


}
