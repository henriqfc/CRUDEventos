using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Application.DTO.DTO;

namespace WebApi.Application.Interfaces
{
    public interface IApplicationServiceEvento
    {
        void Add(EventoDTO obj);

        EventoDTO GetById(int id);

        IEnumerable<EventoDTO> GetAll();

        void Update(EventoDTO obj);

        void Remove(EventoDTO obj);

        void Dispose();

        bool ExisteEventoNoHorario(EventoDTO EventoDTO);
    }
}
