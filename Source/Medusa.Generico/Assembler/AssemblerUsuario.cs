using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Generico.Domain;
using Medusa.Generico.DTO;

namespace Medusa.Generico.Assembler
{
    public class AssemblerUsuario
    {
        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static Usuario DTOToEntity(UsuarioDTO pUsuarioDTO)
        {
            Usuario rReturn = new Usuario();

            rReturn.ID = pUsuarioDTO.ID;
            rReturn.Nombre = pUsuarioDTO.Nombre;
            rReturn.Password = pUsuarioDTO.Password;
            rReturn.Activo = pUsuarioDTO.Activo;
            rReturn.ForzarExpiracion = pUsuarioDTO.ForzarExpiracion;
            rReturn.CantidadDias = pUsuarioDTO.CantidadDias;
            rReturn.ProximaFechaExpiracion = pUsuarioDTO.ProximaFechaExpiracion;
            rReturn.MSTS = pUsuarioDTO.MSTS;
            
            //Para objetos complejos
            //if (pConsulta.IdHistoriaClinicaLookup != null)
            //{
            //    pReturn.IdHistoriaClinicaLookup = TransformerHistoriaClinica.DTOToEntity(pConsulta.IdHistoriaClinicaLookup);
            //}

            //Roles
            //if (pConsulta.Estudios != null)
            //{
            //    foreach (EstudioDTO pObj in pConsulta.Estudios)
            //    {
            //        pReturn.Estudios.Add(TransformerEstudio.DTOToEntity(pObj));
            //    }
            //}

            return rReturn;
        }

        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static UsuarioDTO EntityToDTO(Usuario pUsuario)
        {
            UsuarioDTO rReturn = new UsuarioDTO();

            rReturn.ID = pUsuario.ID;
            rReturn.Nombre = pUsuario.Nombre;
            rReturn.Password = pUsuario.Password;
            rReturn.Activo = pUsuario.Activo;
            rReturn.ForzarExpiracion = pUsuario.ForzarExpiracion;
            rReturn.CantidadDias = pUsuario.CantidadDias;
            rReturn.ProximaFechaExpiracion = pUsuario.ProximaFechaExpiracion;
            rReturn.MSTS = pUsuario.MSTS;

            //if (pConsulta.IdHistoriaClinicaLookup != null)
            //{
            //    pReturn.IdHistoriaClinicaLookup = TransformerHistoriaClinica.EntityToDTO(pConsulta.IdHistoriaClinicaLookup);
            //}

            //Roles
            //if (pConsulta.Estudios != null)
            //{
            //    foreach (Estudio pObj in pConsulta.Estudios)
            //    {
            //        pReturn.Estudios.Add(TransformerEstudio.EntityToDTO(pObj));
            //    }
            //}

            return rReturn;
        }
    }
}
