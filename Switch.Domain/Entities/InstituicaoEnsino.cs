using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
   public class InstituicaoEnsino
    {
        public int Id { get; set; }
        public DateTime? AnoFormacao { get; set; }
        public string Nome { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; private set; }
    }
}
