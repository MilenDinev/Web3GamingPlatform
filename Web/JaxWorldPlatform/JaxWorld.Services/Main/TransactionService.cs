﻿namespace JaxWorld.Services.Main
{
    using AutoMapper;
    using Base;
    using Interfaces;
    using Data;
    using Data.Entities.Transactions;
    using Models.Requests.BlockchainRequests.TransactionModels;

    public class TransactionService : BaseService<Transaction>, ITransactionService
    {
        private readonly IMapper mapper;

        public TransactionService(JaxWorldDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<Transaction> CreateAsync(CreateTransactionModel transactionModel, int creatorId)
        {
            var transaction = mapper.Map<Transaction>(transactionModel);


            await CreateEntityAsync(transaction, creatorId);

            return transaction;
        }

        public async Task UpdateStateAsync(Transaction transaction, int state, int modifierId)
        {
            var transactionState = await dbContext.TransactionStates.FindAsync(state);

            transaction.State = transactionState;

            await SaveModificationAsync(transaction, modifierId);
        }
    }
}