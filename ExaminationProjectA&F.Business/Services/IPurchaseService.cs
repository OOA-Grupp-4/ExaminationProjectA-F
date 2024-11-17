using ExaminationProjectA_F.Domain.Models;

namespace ExaminationProjectA_F.Business.Services
{
    public interface IPurchaseService
    {
        Task<Purchase> CreatePurchaseAsync(PurchaseRecordForm form);
        Task<bool> PurchaseAlreadyExists(string productName);
    }
}