using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.core.Entity
{
    public class MegaFone
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int? MensageiroId { get; set; }
        public Usuario? Mensageiro { get; set; }
        public IEnumerable<ReceptorXMegaFone> ReceptoresXMegaFones { get; set; }
        public IEnumerable<Mensagem> Mensagens { get; set; }
    }
}
