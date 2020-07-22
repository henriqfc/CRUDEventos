using Modelo.Domain.Core.Interfaces.Repositorys;
using Modelo.Domain.Core.Interfaces.Services;
using Modelo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Services.Services
{
    public class ServiceSala : ServiceBase<Sala>, IServiceSala
    {
        public readonly IRepositorySala _repositorySala;

        public ServiceSala(IRepositorySala RepositorySala)
            : base(RepositorySala)
        {
            _repositorySala = RepositorySala;
        }
    }
}
