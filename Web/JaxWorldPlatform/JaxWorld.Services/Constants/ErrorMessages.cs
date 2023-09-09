﻿namespace JaxWorld.Services.Constants
{
    public static class ErrorMessages
    {
        internal const string InvalidCredentials = "Invalid credentials, please try again!";
        internal const string AddresableEntityAlreadyExists = @"{0} with address:'{1}' already exists!";
        internal const string NamedEntityAlreadyExists = @"{0} with name:'{1}' already exists!";

        internal const string InvalidPublicationDate = "Please provide valid publication date in format 'dd/MM/yyyy'!";
        internal const string EntityDoesNotExist = @"{0} does not exist!";
        internal const string EntityIdDoesNotExist = @"{0} with id '{1}' does not exist!";
        internal const string EntityAlreadyExists = @"{0} already exists in our system!";
        internal const string EntityAlreadyAssignedId = @"{0} with id '{1}' has already been assigned to this {2}!";
        internal const string EntityAlreadyContained = @"{0} already exists in this collection!";
        internal const string ProviderDoesNotExists = @"{0} does not exists!";
        internal const string UserDoesNotOwnWallet = @"{0} does not own wallet: {1}!";
        internal const string WalletDoesNotHaveRightsToMint = @"{0} does not have right to mint from contract: {1}!";
        internal const string EntityHasBeenDeleted = @"{0} has already been deleted and cannot be modified!";
    }
}
