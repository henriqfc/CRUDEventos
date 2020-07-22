using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Application.DTO.DTO;

namespace WebApi.Application.Interfaces
{
    public interface IApplicationServiceSala
    {
        void Add(SalaDTO obj);

        SalaDTO GetById(int id);

        IEnumerable<SalaDTO> GetAll();

        void Update(SalaDTO obj);

        void Remove(SalaDTO obj);

        void Dispose();
    }
}
