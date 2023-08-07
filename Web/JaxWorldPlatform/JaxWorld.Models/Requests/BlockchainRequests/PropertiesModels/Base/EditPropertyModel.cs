﻿namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels.Base
{
    using Interfaces;
    using System.ComponentModel.DataAnnotations;

    public abstract class EditPropertyModel : IEditPropertyModel
    {
        [MaxLength(15, ErrorMessage = "TraitType must be between 2 and 15 symbols!")]
        [MinLength(2, ErrorMessage = "TraitType must be between 2 and 15 symbols!")]
        public string TraitType { get; set; }
    }
}
