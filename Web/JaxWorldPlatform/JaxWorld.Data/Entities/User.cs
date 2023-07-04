﻿namespace JaxWorld.Data.Entities
{
    using System;
    using Microsoft.AspNetCore.Identity;
    using Blockchain.Wallets;
    using Blockchain.Transactions;
    using Interfaces.IEntities;
    using JaxWorld.Data.Interfaces.IEntities;

    public class User : IdentityUser<int>, IEntity
    {
        public User()
        {
            this.Wallets = new HashSet<Wallet>();
            this.Transactions = new HashSet<Transaction>();
        }
        public string Username { get; set; }
        public string NormalizedName { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastModifierId { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public bool Deleted { get; set; }

        public ICollection<Wallet> Wallets { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        
    }
}
