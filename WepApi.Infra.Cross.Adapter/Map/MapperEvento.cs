using Modelo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Application.DTO.DTO;
using WebApi.Infra.Cross.Adapter.Interfaces;

namespace WebApi.Infra.Cross.Adapter.Map
{
    public class MapperEvento : IMapperEvento
    {

        #region properties

        List<EventoDTO> EventoDTOs = new List<EventoDTO>();

        #endregion


        #region methods

        public Evento MapperToEntity(EventoDTO EventoDTO)
        {
            Evento Evento = new Evento
            {
                Id = EventoDTO.Id
                ,
                DataFim = EventoDTO.DataFim,
                DataInicio = EventoDTO.DataInicio,
                NomeResponsavel = EventoDTO.NomeResponsavel,
                SalaId = EventoDTO.SalaId
            };

            return Evento;

        }


        public IEnumerable<EventoDTO> MapperListEventos(IEnumerable<Evento> Eventos)
        {
            foreach (var item in Eventos)
            {


                EventoDTO EventoDTO = new EventoDTO
                {
                    Id = item.Id
                   ,
                    DataFim = item.DataFim,
                    DataInicio = item.DataInicio,
                    NomeResponsavel = item.NomeResponsavel,
                    SalaId = item.SalaId
                };



                EventoDTOs.Add(EventoDTO);

            }

            return EventoDTOs;
        }

        public EventoDTO MapperToDTO(Evento Evento)
        {

            EventoDTO EventoDTO = new EventoDTO
            {
                Id = Evento.Id
                ,
                DataFim = Evento.DataFim,
                DataInicio = Evento.DataInicio,
                NomeResponsavel = Evento.NomeResponsavel,
                SalaId = Evento.SalaId

            };

            return EventoDTO;

        }

        #endregion

    }
}
