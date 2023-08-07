﻿namespace JaxWorld.Data.Entities.Transactions
{
    using Units;
    using Contracts;
    using Entities.Wallets;
    using Interfaces.IEntities.ITransactions;

    public class Transaction : Entity, ITransaction
    {
        public string TxnHash { get; set; }
        public int StateId { get; set; }
        public virtual TransactionState State { get; set; }
        public virtual Wallet Creator { get; set; }
        public int? ContractId { get; set; }
        public virtual Contract Contract { get; set; }
        public int NetworkId { get; set; }
        public virtual Network Network { get; set; }
        public int? Erc721aUnitId { get; set; }
        public virtual Erc721aUnit Erc721aUnit { get; set; }
    }
}
