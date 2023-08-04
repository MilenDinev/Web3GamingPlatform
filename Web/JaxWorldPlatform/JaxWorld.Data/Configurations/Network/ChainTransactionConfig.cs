﻿namespace JaxWorld.Data.Configurations.Network
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Blockchain.Transactions;

    public class ChainTransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasOne(s => s.Network)
            .WithMany(u => u.Transactions)
            .HasForeignKey(s => s.NetworkId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}