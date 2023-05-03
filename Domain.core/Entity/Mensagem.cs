using Domain.core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.core.Entity
{
    public class Mensagem
    {
        public int? Id { get; set; }
        public string? Assunto { get; set; }
        public string? Texto { get; set; }
        public string? UrlRecurso { get; set; }
        public DuracaoMensagemEnum Duracao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public int? IdMegaFone { get; set; }
        public MegaFone? MegaFone { get; set; }
    }
}
