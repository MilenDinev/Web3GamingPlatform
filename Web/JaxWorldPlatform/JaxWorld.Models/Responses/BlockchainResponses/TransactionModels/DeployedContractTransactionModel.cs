﻿namespace JaxWorld.Models.Responses.BlockchainResponses.TransactionModels
{
    public class DeployedContractTransactionModel
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string TxnHash { get; set; }
        public string State { get; set; }
    }
}
