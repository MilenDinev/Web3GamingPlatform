﻿namespace JaxWorld.Services.AutoMapperProfiles.Utility
{
    using AutoMapper;
    using Data.Entities.Blockchain.Properties;
    using Models.Requests.BlockchainRequests.PropertiesModels;
    using Models.Responses.BlockchainResponses.PropertiesModels.Utility;

    internal class UtilityMappingProfile : Profile
    {
        internal UtilityMappingProfile()
        {
            this.CreateMap<CreateUtilityModel, Utility>()
                .ForMember(e => e.NormalizedName, m => m.MapFrom(m => m.Name.ToUpper()));
            this.CreateMap<Utility, CreatedUtilityModel>();
            this.CreateMap<Utility, EditedUtilityModel>();
            this.CreateMap<Utility, DeletedUtilityModel>();
            this.CreateMap<Utility, UtilityListingModel>();
        }
    }
}
