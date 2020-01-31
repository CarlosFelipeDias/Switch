using Switch.Domain.Enuns;
using System;
using System.Collections.Generic;

namespace Switch.Domain.Entities
{
    public class Usuario
    {
        public Usuario()
        {
            Postagens = new List<Postagem>();
            UsuarioGrupos = new List<UsuarioGrupo>();
            LocaisTrabalho = new List<LocalTrabalho>();
            InstituicoesEnsino = new List<InstituicaoEnsino>();
            Amigos = new List<Amigo>();
        }

        public Usuario(string nome, string sobreNome, string email, string senha, DateTime dataNascimento, SexoEnum sexo, string urlFoto)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Email = email;
            Senha = senha;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            UrlFoto = urlFoto;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public SexoEnum Sexo { get; private set; }
        public string UrlFoto { get; private set; }

        public virtual Identificacao Identificacao { get; set; }
        public virtual StatusRelacionamento StatusRelacionamento { get; set; }
        public virtual ProcurandoPor ProcurandoPor { get; set; }


        public virtual ICollection<Postagem> Postagens { get; set; }
        public virtual ICollection<UsuarioGrupo> UsuarioGrupos { get; set; }
        public virtual ICollection<LocalTrabalho> LocaisTrabalho { get; set; }
        public virtual ICollection<InstituicaoEnsino> InstituicoesEnsino { get; set; }
        public virtual ICollection<Amigo> Amigos { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }





    }
}
