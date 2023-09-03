﻿namespace JaxWorld.Services.Main
{
    using Microsoft.AspNetCore.Identity;
    using System.Globalization;
    using AutoMapper;
    using Base;
    using Main.Interfaces;
    using Data;
    using Data.Entities.Transactions;
    using Models.Requests.BlockchainRequests.BlockModels;

    public class BlockService : BaseService<Block>, IBlockService
    {
        private readonly IMapper mapper;

        public BlockService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Block> CreateAsync(CreateBlockModel blockModel, int creatorId)
        {
         
            var block = mapper.Map<Block>(blockModel);
            block.Hash = await CreateBlockHashAsync(blockModel.TxnHash);
            block.NormalizedTag = block.Hash.ToString().ToUpper();

            await CreateEntityAsync(block, creatorId);

            return block;
        }

        public async Task<Block> GetCurrentBlockAsync()
        {
            var currentBlock = await this.dbContext.Blocks.FirstOrDefaultAsync(x => x.Transactions.Count < 10 && x.GasUsed <= 15000000 - 275345);
            return currentBlock;
        }


        internal async Task<string> CreateBlockHashAsync(string hashKey)
        {
            var hasher = new PasswordHasher<string>();
            var timestamp = DateTime.UtcNow.ToString("F", CultureInfo.InvariantCulture);
            var blockHash = hasher.HashPassword(hashKey, timestamp);

            return await Task.Run(blockHash.ToString);
        }
    }
}
