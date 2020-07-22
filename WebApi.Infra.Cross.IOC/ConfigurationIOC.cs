using Autofac;
using Modelo.Domain.Core.Interfaces.Repositorys;
using Modelo.Domain.Core.Interfaces.Services;
using Modelo.Domain.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Application.Interfaces;
using WebApi.Application.Service;
using WebApi.Infra.Cross.Adapter.Interfaces;
using WebApi.Infra.Cross.Adapter.Map;
using WebApi.Infra.Repository.Repositorys;

namespace WebApi.Infra.Cross.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceSala>().As<IApplicationServiceSala>();
            builder.RegisterType<ApplicationServiceEvento>().As<IApplicationServiceEvento>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceSala>().As<IServiceSala>();
            builder.RegisterType<ServiceEvento>().As<IServiceEvento>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositorySala>().As<IRepositorySala>();
            builder.RegisterType<RepositoryEvento>().As<IRepositoryEvento>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperSala>().As<IMapperSala>();
            builder.RegisterType<MapperEvento>().As<IMapperEvento>();
            #endregion

            #endregion

        }
    }
}
