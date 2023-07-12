﻿namespace JaxWorld.Data.Blockchain.Contracts
{
    public class ContractOverviewData
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public virtual Contract Contract { get; set; }
        public string Balance { get; set; }
        public string BalanceTokenSymbol { get; set; }
        public string BalanceEstimatedValue { get; set; }
    }
}