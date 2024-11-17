
using ExaminationProjectA_F.Domain.Models;

namespace ExaminationProjectA_F.Domain.Factories;

public class PurchaseFactory
{
    public static PurchaseEntity Create(PurchaseRecordForm form)
    {
        try
        {
            return new PurchaseEntity
            {
                ProductName = form.ProductName,
                ProductDescription = form.ProductDescription,
                ProductPrice = form.ProductPrice
            };
        }
        catch { }
        return null!;
    }

    public static Purchase Create(PurchaseEntity entity)
    {
        try
        {
            return new Purchase
            {
                PurchaseId = entity.PurchaseId,
                ProductName = entity.ProductName,
                ProductDescription = entity.ProductDescription,
                ProductPrice = entity.ProductPrice
            };
        }
        catch { } 
        
        return null!;
    }

    public static IEnumerable<Purchase> Create(List<PurchaseEntity> entities)
    {
        var list = new List<Purchase>();

        try
        {
            foreach (var entity in entities)
            {
                list.Add(new Purchase
                {
                    PurchaseId = entity.PurchaseId,
                    ProductName = entity.ProductName,
                    ProductDescription = entity.ProductDescription,
                    ProductPrice = entity.ProductPrice
                });
            }
        }
        catch { }

        return list;
    }


}
