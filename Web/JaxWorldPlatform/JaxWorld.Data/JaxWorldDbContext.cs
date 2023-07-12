﻿namespace JaxWorld.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Entities;
    using Blockchain;
    using Blockchain.Wallets;
    using Blockchain.Contracts;
    using Blockchain.Properties;
    using Blockchain.Transactions;
    using Blockchain.Tokens.Erc721.Units;
    using Blockchain.Tokens.Erc721.Profiles;

    public class JaxWorldDbContext: IdentityDbContext<User, IdentityRole<int>, int>
    {
        public JaxWorldDbContext(DbContextOptions<JaxWorldDbContext> options) : base(options)
        { }

        public virtual DbSet<Chain> Networks { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }
        public virtual DbSet<Erc721aProfile> Erc721aProfiles { get; set; }
        public virtual DbSet<Erc721aUnit> Erc721aUnits { get; set; } //Must COnfigure Erc721aToken Relations
        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<Utility> Utilities { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Wallet> Wallets { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assemblyWithConfigurations = GetType().Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assemblyWithConfigurations);
            base.OnModelCreating(modelBuilder);
        }
    }
}