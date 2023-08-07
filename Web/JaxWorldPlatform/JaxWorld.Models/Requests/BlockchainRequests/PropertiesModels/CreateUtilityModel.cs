﻿namespace JaxWorld.Models.Requests.BlockchainRequests.PropertiesModels
{
    using Base;
    using System.ComponentModel.DataAnnotations;

    public class CreateUtilityModel : CreatePropertyModel
    {
        [Required(ErrorMessage = "DisplayType is required!")]
        [MinLength(2, ErrorMessage = "DisplayType is required and must be between 2 and 10 symbols!")]
        [MaxLength(10, ErrorMessage = "DisplayType is required and must be between 2 and 10 symbols!")]
        public string DisplayType { get; set; }
        public decimal Value { get; set; }
    }
}
