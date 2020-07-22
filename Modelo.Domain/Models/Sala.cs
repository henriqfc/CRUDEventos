using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modelo.Domain.Models
{
    [Table("Sala")]
    public class Sala : Base
    {
        public string Nome { get; set; }
    }
}
