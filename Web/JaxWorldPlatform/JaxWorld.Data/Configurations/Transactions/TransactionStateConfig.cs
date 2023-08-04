﻿namespace JaxWorld.Data.Configurations.Transactions
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Entities.Blockchain.Transactions;

    internal class TransactionStateConfig : IEntityTypeConfiguration<TransactionState>
    {
        public void Configure(EntityTypeBuilder<TransactionState> builder)
        {
            builder.HasData(
                    new TransactionState
                    {
                        Id = 1,
                        State = "Pending"
                    });
            builder.HasData(
                    new TransactionState
                    {
                        Id = 2,
                        State = "Approved"
                    });

            builder.HasData(
                    new TransactionState
                    {
                        Id = 3,
                        State = "Rejected"
                    });
        }
    }
}
