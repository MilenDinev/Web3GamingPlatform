﻿namespace JaxWorld.Data.Entities.Units
{
    using Base;
    using Wallets;
    using Entities;
    using Properties;

    public class Erc721aUnit : Unit
    {
        public Erc721aUnit()
        {
            Attributes = new HashSet<Attribute>();
            Utilities = new HashSet<Utility>();
        }

        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? ExternalUrl { get; set; }
        public bool Minted { get; set; }
        public string? MintedTxnHash { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        public string DNA { get; set; }
        public int? HolderId { get; set; }
        public virtual Wallet? Holder { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<Utility> Utilities { get; set; }
    }
}

