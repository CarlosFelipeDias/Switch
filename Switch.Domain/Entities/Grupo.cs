using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class Grupo
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string UrlFoto { get; private set; }
        public virtual ICollection<Postagem> Postagens { get; private set; }
        public virtual ICollection<UsuarioGrupo> UsuarioGrupos { get; private set; }

    }
}
