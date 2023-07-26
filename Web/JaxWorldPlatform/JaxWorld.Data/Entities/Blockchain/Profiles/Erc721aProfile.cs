﻿namespace JaxWorld.Data.Entities.Blockchain.Profiles
{
    using Base;
    using Units;
    using Interfaces.IEntities.IBlockchain.IProfiles;

    public class Erc721aProfile : Profile, IErc721aProfile
    {
        public Erc721aProfile()
        {
            Units = new HashSet<Erc721aUnit>();
        }

        public string Description { get; set; }
        public int TotalSupply { get; set; }
        public int TotalMinted { get; set; }
        public virtual ICollection<Erc721aUnit> Units { get; set; }
    }
}
