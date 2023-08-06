﻿namespace JaxWorld.Data.Interfaces.IEntities.IBlockchain
{
    internal interface INetwork
    {
        string Name { get; set; }
        string RpcUrl { get; set; }
        string ChainId { get; set; }
        string Symbol { get; set; }
        string? ExplorerUrl { get; set; }
    }
}
