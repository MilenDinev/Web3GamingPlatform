﻿namespace JaxWorld.Data.Entities.Blockchain.Wallets
{
    using Tokens;
    using Entities;
    using Contracts;
    using Transactions;
    using Interfaces.IEntities.IBlockchain.IWallets;

    public class Wallet : IWallet
    {
        public Wallet()
        {
            Chains = new HashSet<Chain>();
            Transactions = new HashSet<Transaction>();
            CreatedContracts = new HashSet<Contract>();
            Tokens = new HashSet<TokenWalletBalance>();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }
        public int OwnerId { get; set; }
        public virtual User Owner { get; set; }
        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        public virtual ICollection<Chain> Chains { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Contract> CreatedContracts { get; set; }
        public virtual ICollection<TokenWalletBalance> Tokens { get; set; }
    }
}
