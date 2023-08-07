﻿namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Entities;

    public static class NetworksSampleSeeder
    {
        public static async Task Seed(JaxWorldDbContext context)
        {
            var avalancheMainet = new Network

            {
                Name = "Avalanche Mainnet Network",
                RpcUrl= "https://api.avax.network/ext/bc/C/rpc",
                ChainId= "43114",
                Symbol= "AVAX",
                ExplorerUrl= "https://snowtrace.io/ ",
                NormalizedTag = "Avalanche Mainnet Network".ToUpper(),
            };

            var avalancheFujiTestNet = new Network
            {
                Name = "Avalanche FUJI C-Chain",
                RpcUrl = "https://api.avax-test.network/ext/bc/C/rpc",
                ChainId = "43113",
                Symbol = "AVAX",
                ExplorerUrl = "https://testnet.snowtrace.io/",
                NormalizedTag = "Avalanche FUJI C-Chain".ToUpper(),
            };


            await context.Networks.AddRangeAsync(avalancheMainet, avalancheFujiTestNet);

            await context.SaveChangesAsync();
        }
    }
}