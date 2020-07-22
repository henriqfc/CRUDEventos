using Modelo.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Application.DTO.DTO;
using WebApi.Application.Interfaces;
using WebApi.Infra.Cross.Adapter.Interfaces;

namespace WebApi.Application.Service
{
    public class ApplicationServiceSala : IApplicationServiceSala
    {
        private readonly IServiceSala _serviceSala;
        private readonly IMapperSala _mapperSala;

        public ApplicationServiceSala(IServiceSala ServiceSala
                                                 , IMapperSala MapperSala)

        {
            _serviceSala = ServiceSala;
            _mapperSala = MapperSala;
        }


        public void Add(SalaDTO obj)
        {
            var objSala = _mapperSala.MapperToEntity(obj);
            _serviceSala.Add(objSala);
        }

        public void Dispose()
        {
            _serviceSala.Dispose();
        }

        public IEnumerable<SalaDTO> GetAll()
        {
            var objProdutos = _serviceSala.GetAll();
            return _mapperSala.MapperListSalas(objProdutos);
        }

        public SalaDTO GetById(int id)
        {
            var objSala = _serviceSala.GetById(id);
            return _mapperSala.MapperToDTO(objSala);
        }

        public void Remove(SalaDTO obj)
        {
            var objSala = _mapperSala.MapperToEntity(obj);
            _serviceSala.Remove(objSala);
        }

        public void Update(SalaDTO obj)
        {
            var objSala = _mapperSala.MapperToEntity(obj);
            _serviceSala.Update(objSala);
        }
    }
}