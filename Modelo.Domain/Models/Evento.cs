using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modelo.Domain.Models
{
    [Table("Evento")]
    public class Evento : Base
    {
        public string NomeResponsavel { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int SalaId { get; set; }
        public virtual Sala Sala { get; set; }
    }
}
