
using System.ComponentModel.DataAnnotations;

namespace ExaminationProjectA_F.Domain.Models;

public class PurchaseRecordForm
{
    [Required(ErrorMessage = "You must enter a product name")]

    public string ProductName { get; set; } = null!;

    [Required(ErrorMessage = "You must enter a product description")]

    public string ProductDescription { get; set; } = null!;

    [Required(ErrorMessage = "You must enter a product price")]

    public decimal ProductPrice { get; set; }
}


