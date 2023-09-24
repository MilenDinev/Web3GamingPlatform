﻿namespace JaxWorld.Services.Handlers.Interfaces.ITxnManagers
{
    using Data.Entities;
    using Models.Responses.BlockchainResponses.UnitModels;
    using Models.Requests.BlockchainRequests.UnitModels;
    using Models.Responses.BlockchainResponses.ProfileUnitModels;

    public interface IErc721UnitTxnDeployerManager : ITxnDeployerManager
    {
        Task<int> GetUnitNetworkIdAsync(int profileId);
        Task<CreatedErc721aUnitModel> CreateErc721UnitAsync(CreateErc721aUnitModel createErc721aUnitModel, User user);
        Task<ClaimedUnitModel> ClaimUnitAsync(ClaimUnitModel claimUnitModel, User user);
        Task<Profile> GetUnitProfileAsync(int unitId);
        Task<TransferedUnitModel> TransferUnitAsync(TransferUnitModel transferUnitModel, User user);
        Task<BoughtUnitModel> BuyUnitAsync(BuyUnitModel buyUnitModel,User user);
        Task<ListedSellUnitModel> ListUnitSell(ListSellUnitModel listSellUnitModel, User user);
    }
}
