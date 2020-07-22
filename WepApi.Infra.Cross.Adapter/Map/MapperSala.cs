using Modelo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Application.DTO.DTO;
using WebApi.Infra.Cross.Adapter.Interfaces;

namespace WebApi.Infra.Cross.Adapter.Map
{
    public class MapperSala : IMapperSala
    {

        #region properties

        List<SalaDTO> SalaDTOs = new List<SalaDTO>();

        #endregion


        #region methods

        public Sala MapperToEntity(SalaDTO SalaDTO)
        {
            Sala Sala = new Sala
            {
                Id = SalaDTO.Id
                ,
                Nome = SalaDTO.Nome
                ,
            };

            return Sala;

        }


        public IEnumerable<SalaDTO> MapperListSalas(IEnumerable<Sala> Salas)
        {
            foreach (var item in Salas)
            {


                SalaDTO SalaDTO = new SalaDTO
                {
                    Id = item.Id
                   ,
                    Nome = item.Nome
                   ,
                };



                SalaDTOs.Add(SalaDTO);

            }

            return SalaDTOs;
        }

        public SalaDTO MapperToDTO(Sala Sala)
        {

            SalaDTO SalaDTO = new SalaDTO
            {
                Id = Sala.Id
                ,
                Nome = Sala.Nome
                
            };

            return SalaDTO;

        }

        #endregion

    }
}
