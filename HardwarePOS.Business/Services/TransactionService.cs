using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.Entities;

namespace HardwarePOS.Business.Services
{
    public class TransactionService 
    {
        private readonly TransactionRepository _repository;

        public TransactionService(TransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TransactionHistory>> GetTransactionsAsync(string? type, DateTime? fromDate, DateTime? toDate, string? search)
        {
            return await _repository.GetTransactionsAsync(type, fromDate, toDate, search);
        }

        public async Task<bool> VoidTransactionAsync(string transactionType, int transactionId, int cancelledBy, string cancelReason)
        {
            if (string.IsNullOrWhiteSpace(transactionType))
                throw new ArgumentException("Transaction type is required.");

            transactionType = transactionType.Trim().ToUpper();

            if (transactionType != "SALE" &&
                transactionType != "PURCHASE")
            {
                throw new ArgumentException("Transaction type must be SALE or PURCHASE.");
            }

            if (transactionId <= 0) throw new ArgumentException("Invalid transaction ID.");

            if (cancelledBy <= 0) throw new ArgumentException("Invalid user.");

            if (string.IsNullOrWhiteSpace(cancelReason)) throw new ArgumentException("Cancellation reason is required.");

            return await _repository.VoidTransactionAsync(transactionType, transactionId, cancelledBy, cancelReason.Trim());
        }
    }
}
