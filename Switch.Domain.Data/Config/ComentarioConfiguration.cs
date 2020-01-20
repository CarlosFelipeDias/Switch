using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.DataPublicacao).IsRequired();
        builder.Property(c => c.Texto).HasMaxLength(600).IsRequired();
        //builder.HasOne(c => c.Usuario).WithOne(i => i.).HasForeignKey<Identificacao>(i => i.UsuarioID);
        //builder.HasMany(c => c.Postagens).WithOne(p => p.Usuario);
    }
}
}


