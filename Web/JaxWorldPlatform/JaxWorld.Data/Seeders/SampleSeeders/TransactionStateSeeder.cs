﻿namespace JaxWorld.Data.Seeders.SampleSeeders
{
    using Entities.Transactions;

    internal class TransactionStateSeeder
    {
        internal static async Task Seed(JaxWorldDbContext context)
        {

            var Pending = new TransactionState
            {
                State = "Pending",
                NormalizedTag = "Pending".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            var Confirmed = new TransactionState
            {
                State = "Confirmed",
                NormalizedTag = "Confirmed".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            var Rejected = new TransactionState
            {
                State = "Rejected",
                NormalizedTag = "Rejected".ToUpper(),
                CreatorId = 1,
                CreationDate = DateTime.Now,
                LastModifierId = 1,
                LastModificationDate = DateTime.Now
            };

            await context.TransactionStates.AddRangeAsync(Pending, Confirmed, Rejected);
            await context.SaveChangesAsync();
        }
    }
}
