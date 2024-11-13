
using ExaminationProjectA_F.Domain.Models;

namespace ExaminationProjectA_F.Domain.Factories;

public static class UserFactory
{
    public static UserEntity Create(UserRegistrationForm form)
    {
        try
        {
            return new UserEntity
            {
                FirstName = form.FirstName,
                LastName = form.LastName,
                Email = form.Email,
                Password = form.Password
            };
        }
        catch { }

        return null!;
    }

    public static User Create(UserEntity entity)
    {
        try
        {
            return new User
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email
            };
        }
        catch { }

        return null!;
    }

    public static IEnumerable<User> Create(List<UserEntity> entities)
    {
        var list = new List<User>();

        try
        {

            foreach (var entity in entities)
            {
                list.Add(new User
                {
                    Id = entity.Id,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Email = entity.Email
                });
            }
        }
        catch { }

        return list;
    }
}
