
using ExaminationProjectA_F.Domain.Factories;
using ExaminationProjectA_F.Domain.Models;

namespace ExaminationProjectA_F.Tests;

public class PurchaseFactory_Tests
{
    [Theory]
    [InlineData("Panasonic TV", "GZ5500 OLED TV", 16000)]
    [InlineData("iPhone 16", "4K Skärm", 15000)]

    public void Create_ShouldReturnPurchaseEntity(string productName, string productDescription, decimal productPrice)
    {
        //Arrange
        var form = new PurchaseRecordForm { ProductName = productName, ProductDescription = productDescription, ProductPrice = productPrice };

        //Act 
        var result = PurchaseFactory.Create(form);

        //Assert
        Assert.NotNull(result);
        Assert.IsType<PurchaseEntity>(result);
        Assert.Equal(productName, result.ProductName);
        Assert.Equal(productDescription, result.ProductDescription);
        Assert.Equal(productPrice, result.ProductPrice);
    }

    public void Delete_ShouldReturnPurchaseEntity(string productName, string productDescription, decimal productPrice)
    {

    }
}

