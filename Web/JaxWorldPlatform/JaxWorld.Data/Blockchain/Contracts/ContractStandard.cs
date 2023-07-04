﻿namespace JaxWorld.Data.Blockchain.Contracts
{
    public class ContractStandard
    {
        public ContractStandard()
        {
            Contracts = new HashSet<Contract>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
