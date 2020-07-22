using Modelo.Domain.Core.Interfaces.Repositorys;
using Modelo.Domain.Core.Interfaces.Services;
using Modelo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Domain.Services.Services
{
    public class ServiceEvento : ServiceBase<Evento>, IServiceEvento
    {
        public readonly IRepositoryEvento _repositoryEvento;

        public ServiceEvento(IRepositoryEvento RepositoryEvento)
            : base(RepositoryEvento)
        {
            _repositoryEvento = RepositoryEvento;
        }
        public bool ExisteEventoNoHorario(Evento evento)
        {
            // se é na mesma sala && novo.DataInicio está entre antigos.DataInicio/DataFim
            // ou novo.DataFim está entre antigos.DataInicio/DataFim
            // ou evento começa antes e termina após outros eventos
            var existeEvento = _repositoryEvento.GetAll().Any(e => e.Id != evento.Id && e.SalaId == evento.SalaId &&
                                        ((evento.DataInicio.CompareTo(e.DataInicio) >= 0 && evento.DataInicio.CompareTo(e.DataFim) <= 0) ||
                                        (evento.DataFim.CompareTo(e.DataInicio) >= 0 && evento.DataFim.CompareTo(e.DataFim) <= 0) ||
                                        (evento.DataInicio.CompareTo(e.DataInicio) < 0 && evento.DataFim.CompareTo(e.DataFim) > 0)
                                        ));


            return existeEvento;
        }
    }
}
