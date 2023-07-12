﻿namespace JaxWorld.Data.Blockchain.Configurations.ContractStandard
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Contracts;
    using JaxWorld.Data.Blockchain.Tokens;

    public class ContractStandardConfig : IEntityTypeConfiguration<Standard>
    {
        public void Configure(EntityTypeBuilder<Standard> builder)
        {
            builder.HasData(
                    new Standard
                    {
                        Id = 1,
                        Name = "ERC721"
                    });
            builder.HasData(
                    new Standard
                    {
                        Id = 2,
                        Name = "ERC721a"
                    });

            builder.HasData(
                    new Standard
                    {
                        Id = 3,
                        Name = "ERC20"
                    });

            builder.HasData(
                    new Standard
                    {
                        Id = 4,
                        Name = "ERC1155"
                    });
        }
    }
}

