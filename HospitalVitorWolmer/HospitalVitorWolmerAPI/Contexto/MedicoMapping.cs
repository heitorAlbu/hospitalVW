using HospitalVitorWolmerAPI.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalVitorWolmerAPI.Contexto
{
    public class MedicoMapping : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("idmedicos").HasColumnType("INT");
            builder.Property(p => p.Nome).HasColumnName("nomeMedico").HasColumnType("VARCHAR(45)");

            builder.ToTable("medicos");
        }
    }
}
