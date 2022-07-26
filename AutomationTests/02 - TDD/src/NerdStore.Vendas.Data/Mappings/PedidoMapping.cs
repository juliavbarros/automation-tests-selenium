﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NerdStore.Vendas.Domain;

namespace NerdStore.Catalogo.Data.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Desconto)
              .IsRequired()
              .HasColumnType("decimal");

            builder.Property(c => c.ValorTotal)
             .IsRequired()
             .HasColumnType("decimal");

            builder.Property(c => c.Codigo)
                .HasDefaultValueSql("NEXT VALUE FOR MinhaSequencia");

            // 1 : N => Pedido : PedidoItens
            builder.HasMany(c => c.PedidoItens)
                .WithOne(c => c.Pedido)
                .HasForeignKey(c => c.PedidoId);

            builder.ToTable("Pedidos");
        }
    }
}