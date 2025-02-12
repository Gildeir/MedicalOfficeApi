﻿using MedicalOfficeApi.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalOfficeApi.Configuration
{
    public class EspecialidadeConfiguration: IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            builder.Property(x => x.Ativa).HasColumnName("ativa");
        }
    }
}
