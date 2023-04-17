using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.core.DTO
{
    public class MensagemDTO
    {
        public int? Id { get; set; }
        public string? Assunto { get; set; }
        public string? Texto { get; set; }
        public string? UrlRecurso { get; set; }
        public DateTime? DataCriacao { get; set; }
    }
}
