using System;
using System.Collections.Generic;
using Medusa.Generico.Core.DataInterfaces;

namespace Medusa.Generico.Data
{
    public class NHibernateDaoFactory : IDaoFactory
    {
        private string sessionFactoryConfigPath;

        public NHibernateDaoFactory(string sessionFactoryConfigPath)
        {
            SessionFactoryConfigPath = sessionFactoryConfigPath;
        }

        protected string SessionFactoryConfigPath
        {
            get { return sessionFactoryConfigPath; }
            set { sessionFactoryConfigPath = value; }
        }

        public IRolDao GetRolDao()
        {
            return new RolDao(SessionFactoryConfigPath);
        }
        public IUsuarioDao GetUsuarioDao()
        {
            return new UsuarioDao(SessionFactoryConfigPath);
        }
        public IUsuarioRolDao GetUsuarioRolDao()
        {
            return new UsuarioRolDao(SessionFactoryConfigPath);
        }
    }
}
