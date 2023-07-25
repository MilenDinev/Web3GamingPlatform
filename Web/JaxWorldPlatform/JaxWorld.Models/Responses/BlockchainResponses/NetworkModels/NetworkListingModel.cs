﻿namespace JaxWorld.Models.Responses.BlockchainResponses.NetworkModels
{
    public class NetworkListingModel
    {
        public int Id { get; set; }
        public string Name { get; init; }
        public string RpcUrl { get; init; }
        public string ChainId { get; init; }
        public string Symbol { get; init; }
        public string ExplorerUrl { get; init; }
    }
}
