using Switch.Domain.Enuns;
using System;

namespace Switch.Domain.Entities
{
    public class Usuario
    {
        public int Id { get;private set; }
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime  DataNascimento { get; private set; }
        public SexoEnum Sexo { get; private set; }
        public string UrlFoto { get; private set; }

    }
}
