﻿namespace JaxWorld.Data.Blockchain.Contracts
{
    using Wallets;
    using Tokens.Base;
    using Transactions;
    using Interfaces.IBlockchain.IContracts;

    public class Contract : IContract
    {
        public Contract()
        {

            Chains = new HashSet<Chain>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Balance { get; set; }
        public string EstimatedValue { get; set; }
        public int ProfileId { get; set; }
        public virtual ContractProfile Profile { get; set; }
        public int CreatedTxnId { get; set; }
        public virtual Transaction CreatedTxn { get; set; }
        public int CreatorId { get; set; }
        public virtual Wallet Creator { get; set; }
        public int OwnerId { get; set; }
        public virtual Wallet Owner { get; set; }
        public int ChainId { get; set; }
        public virtual ICollection<Chain> Chains { get; set; }
    }
}
