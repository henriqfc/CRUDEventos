using Modelo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Application.DTO.DTO;

namespace WebApi.Infra.Cross.Adapter.Interfaces
{
    public interface IMapperSala
    {
        #region Mappers

        Sala MapperToEntity(SalaDTO SalaDTO);

        IEnumerable<SalaDTO> MapperListSalas(IEnumerable<Sala> Salas);

        SalaDTO MapperToDTO(Sala Sala);

        #endregion

    }
}
