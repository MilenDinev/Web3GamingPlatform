﻿namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Interfaces;
    using Data;
    using Data.Entities;
    using Models.Requests.BlockchainRequests.NetworkModels;

    public class NetworkService : BaseService<Network>, INetworkService
    {
        private readonly IMapper mapper;

        public NetworkService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Network> CreateAsync(CreateNetworkModel networkModel, int creatorId)
        {
            var network = mapper.Map<Network>(networkModel);
            await CreateEntityAsync(network, creatorId);
            return network;
        }

        public async Task EditAsync(Network network, EditNetworkModel networkModel, int modifierId)
        {
            network.Name = networkModel.Name;
            network.RpcUrl = networkModel.RpcUrl;
            network.ExplorerUrl = networkModel.ExplorerUrl;
            network.ChainId = networkModel.ChainId.ToString();
            network.NormalizedTag = networkModel.Name.ToUpper();
            network.Symbol = networkModel.Symbol;

            await SaveModificationAsync(network, modifierId);
        }
        public async Task DeleteAsync(Network network, int modifierId)
        {
            await DeleteEntityAsync(network, modifierId);
        }
    }
}

