using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Application.DTO.DTO
{
    public class EventoDTO
    {
        public int? Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string NomeResponsavel { get; set; }
        public int SalaId { get; set; }
    }
}
