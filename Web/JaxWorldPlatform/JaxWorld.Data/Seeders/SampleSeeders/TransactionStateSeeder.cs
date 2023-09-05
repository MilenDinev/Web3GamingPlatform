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
                LastModifierId = 1
            };

            var Approved = new TransactionState
            {
                State = "Approved",
                NormalizedTag = "Approved".ToUpper(),
                CreatorId = 1,
                LastModifierId = 1
            };

            var Rejected = new TransactionState
            {
                State = "Rejected",
                NormalizedTag = "Rejected".ToUpper(),
                CreatorId = 1,
                LastModifierId = 1
            };

            await context.TransactionStates.AddRangeAsync(Pending, Approved, Rejected);
            await context.SaveChangesAsync();
        }
    }
}
