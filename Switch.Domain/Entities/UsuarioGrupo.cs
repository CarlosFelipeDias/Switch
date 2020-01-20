using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class UsuarioGrupo
    {

        public DateTime DataCriacao { get; private set; }
        public bool EhAdministrador { get; private set; }


        public virtual Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
        public virtual Grupo Grupo { get; set; }
        public int GrupoId { get; set; }
    }
}
