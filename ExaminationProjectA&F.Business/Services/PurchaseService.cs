
using ExaminationProjectA_F.Data.Interfaces;
using ExaminationProjectA_F.Domain.Factories;
using ExaminationProjectA_F.Domain.Models;

namespace ExaminationProjectA_F.Business.Services;

public class PurchaseService(IPurchaseRepository purchaseRepository) : IPurchaseService
{
    private readonly IPurchaseRepository _purchaseRepository = purchaseRepository;

    public async Task<bool> PurchaseAlreadyExists(string productName)
    {
        var exists = await _purchaseRepository.GetAsync(x => x.ProductName == productName);
        if (exists != null)
        {
            return true;
        }
        return false;
    }

    public async Task<Purchase> CreatePurchaseAsync(PurchaseRecordForm form)
    {
        var result = PurchaseAlreadyExists(form.ProductName);

        var entity = PurchaseFactory.Create(form);
        await _purchaseRepository.SaveAsync(entity);

        var purchase = PurchaseFactory.Create(entity);
        return purchase;
    }
}
