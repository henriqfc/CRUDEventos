using Modelo.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Application.DTO.DTO;
using WebApi.Application.Interfaces;
using WebApi.Infra.Cross.Adapter.Interfaces;

namespace WebApi.Application.Service
{
    public class ApplicationServiceEvento : IApplicationServiceEvento
    {
        private readonly IServiceEvento _serviceEvento;
        private readonly IMapperEvento _mapperEvento;

        public ApplicationServiceEvento(IServiceEvento ServiceEvento
                                                 , IMapperEvento MapperEvento)

        {
            _serviceEvento = ServiceEvento;
            _mapperEvento = MapperEvento;
        }


        public void Add(EventoDTO obj)
        {
            var objEvento = _mapperEvento.MapperToEntity(obj);
            _serviceEvento.Add(objEvento);
        }

        public void Dispose()
        {
            _serviceEvento.Dispose();
        }

        public IEnumerable<EventoDTO> GetAll()
        {
            var objProdutos = _serviceEvento.GetAll();
            return _mapperEvento.MapperListEventos(objProdutos);
        }

        public EventoDTO GetById(int id)
        {
            var objEvento = _serviceEvento.GetById(id);
            return _mapperEvento.MapperToDTO(objEvento);
        }

        public void Remove(EventoDTO obj)
        {
            var objEvento = _mapperEvento.MapperToEntity(obj);
            _serviceEvento.Remove(objEvento);
        }

        public void Update(EventoDTO obj)
        {
            var objEvento = _mapperEvento.MapperToEntity(obj);
            _serviceEvento.Update(objEvento);
        }
        public bool ExisteEventoNoHorario(EventoDTO EventoDTO)
        {
            var objEvento = _mapperEvento.MapperToEntity(EventoDTO);
            return _serviceEvento.ExisteEventoNoHorario(objEvento);
        }
    }
}