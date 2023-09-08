﻿namespace JaxWorld.Data.Entities
{
    using Interfaces.IEntities;
    using Microsoft.AspNetCore.Identity;
    using System;
    using Wallets;

    public class User : IdentityUser<int>, IEntity
    {
        public User()
        {
            this.Wallets = new HashSet<Wallet>();
        }
        public int CreatorId { get; set; }
        public virtual User Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public int LastModifierId { get; set; }
        public virtual User LastModifier { get; set; }
        public DateTime LastModificationDate { get; set; }
        public string NormalizedTag { get; set; }
        public bool Deleted { get; set; }
        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
