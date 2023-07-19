﻿namespace JaxWorld.Data.Entities.Blockchain.Tokens
{
    using Tokens.Base;

    public class Standard : Entity
    {
        public Standard()
        {
            ContractProfiles = new HashSet<ContractProfile>();
        }

        public string Name { get; set; }
        public virtual ICollection<ContractProfile> ContractProfiles { get; set; }
    }
}
