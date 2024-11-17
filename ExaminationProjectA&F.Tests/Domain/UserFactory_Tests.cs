
using ExaminationProjectA_F.Domain.Factories;
using ExaminationProjectA_F.Domain.Models;

namespace ExaminationProjectA_F.Tests.Domain;


public class UserFactory_Tests
{
    [Theory]
    [InlineData("Fabrice", "Karenzi", "Fabrice.karenzi@example.com", "Osaker123!")]
    [InlineData("Eddy", "Dupond", "Eddy.Dupond@example.com", "Osaker123!")]

    public void Create_ShouldReturnUserEntity(string firstName, string lastName, string email, string password)
    {
        //Arrange
        var form = new UserRegistrationForm { FirstName = firstName, LastName = lastName, Email = email, Password = password };

        //Act
        var result = UserFactory.Create(form);

        //Assert
        Assert.NotNull(result);
        Assert.IsType<UserEntity>(result);
        Assert.Equal(firstName, result.FirstName);
        Assert.Equal(lastName, result.LastName);
        Assert.Equal(email, result.Email);
        Assert.Equal(password, result.Password);

    }

    [Theory]
    [InlineData(1, "Fabrice", "Karenzi", "Fabrice.karenzi@gmail.com", "Osaker123!")]
    [InlineData(2, "Eddy", "Dupond", "Eddy.Dupond@gmail.com", "Osaker123!")]

    public void Create_ShouldReturnUser(int id, string firstName, string lastName, string email, string password)
    {
        //Arrange
        var entity = new UserEntity { Id = id, FirstName = firstName, LastName = lastName, Email = email, Password = password };

        //Act
        var result = UserFactory.Create(entity);

        //Assert
        Assert.NotNull(result);
        Assert.IsType<User>(result);
        Assert.Equal(id, result.Id);
        Assert.Equal(firstName, result.FirstName);
        Assert.Equal(lastName, result.LastName);
        Assert.Equal(email, result.Email);
    }


    public static IEnumerable<object[]> GetUserEntities()
    {
        yield return new object[]
        {
            new List<UserEntity>
            {
                new() { Id = 1, FirstName = "Fabrice", LastName = "Karenzi", Email = "Fabrice.karenzi@example.com", Password = "Osaker123!" },
                new() { Id = 2, FirstName = "Eddy", LastName = "Dupond", Email = "Fabrice.Dupond@example.com", Password = "Osaker123!" }
            },
            new List<User>
            {
                new() { Id = 1, FirstName = "Fabrice", LastName = "Karenzi", Email = "Fabrice.karenzi@example.com" },
                new() { Id = 2, FirstName = "Eddy", LastName = "Dupond", Email = "Fabrice.Dupond@example.com" }
            }
        };
    }


    [Theory]
    [MemberData(nameof(GetUserEntities))]

    public void Create_ShouldReturnListOfUsers(List<UserEntity> entities, List<User> expectedUsers)
    {
        //Act
        var result = UserFactory.Create(entities);

        //Assert
        Assert.NotNull(result);
        Assert.Equal(expectedUsers.Count, result.Count());
        for (int i = 0; i < expectedUsers.Count; i++)
        {
            Assert.Equal(expectedUsers[i].Id, result.ElementAt(i).Id);
            Assert.Equal(expectedUsers[i].FirstName, result.ElementAt(i).FirstName);
            Assert.Equal(expectedUsers[i].LastName, result.ElementAt(i).LastName);
            Assert.Equal(expectedUsers[i].Email, result.ElementAt(i).Email);
        }
    }
}
