namespace ExaminationProjectA_F.Domain.Models;

public class Purchase
{
    public int PurchaseId { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public decimal ProductPrice { get; set; } 
}


