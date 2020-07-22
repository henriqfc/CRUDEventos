using Modelo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Application.DTO.DTO;

namespace WebApi.Infra.Cross.Adapter.Interfaces
{
    public interface IMapperEvento
    {
        #region Mappers

        Evento MapperToEntity(EventoDTO EventoDTO);

        IEnumerable<EventoDTO> MapperListEventos(IEnumerable<Evento> Eventos);

        EventoDTO MapperToDTO(Evento Sala);

        #endregion

    }
}
