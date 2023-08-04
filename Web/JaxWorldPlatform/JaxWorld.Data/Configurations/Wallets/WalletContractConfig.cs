﻿namespace JaxWorld.Data.Configurations.Wallets
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Blockchain.Contracts;

    public class WalletContractConfig : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasOne(s => s.Creator)
                .WithMany(u => u.CreatedContracts)
                .HasForeignKey(s => s.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
