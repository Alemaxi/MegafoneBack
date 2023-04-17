using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.core.Entity
{
    public class ReceptorXMegaFone
    {
        public int? Id { get; set; }

        [ForeignKey("IdUsuario")]
        public int? ReceptorId { get; set; }
        public int? MegaFoneId { get; set; }
        public Usuario? Receptor { get; set; }
        public MegaFone? MegaFone { get; set; }
    }
}
