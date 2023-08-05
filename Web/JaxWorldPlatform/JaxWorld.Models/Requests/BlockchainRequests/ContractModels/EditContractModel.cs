﻿namespace JaxWorld.Models.Requests.BlockchainRequests.ContractModels
{
    using System.ComponentModel.DataAnnotations;

    public class EditContractModel
    {
        [Required(ErrorMessage = "Contract name is required and must be between 2 and 15 symbols!")]
        [MaxLength(15, ErrorMessage = "Contract name is required and must be between 2 and 15 symbols!")]
        [MinLength(2, ErrorMessage = "Contract name is required and must be between 2 and 15 symbols!")]
        public string Name { get; set; }
    }
}
