﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Safeon.Mysql.Entities;

namespace Safeon.Mysql.Map
{
    public class OccurrenceStatusMap : IEntityTypeConfiguration<OccurrenceStatusEntity>
    {
        public void Configure(EntityTypeBuilder<OccurrenceStatusEntity> builder)
        {
            builder.ToTable("OccurrenceStatus");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasAnnotation("MySQL:AutoIncrement", true)
                .HasColumnType("INT(11)");

            builder.Property(x => x.Description)
                    .HasMaxLength(256)
                    .IsRequired();
        }
    }
}