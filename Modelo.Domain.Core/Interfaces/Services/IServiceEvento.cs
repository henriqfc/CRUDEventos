using Modelo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Core.Interfaces.Services
{
    public interface IServiceEvento  : IServiceBase<Evento>
    {
        public bool ExisteEventoNoHorario(Evento evento);
    }
}
