using ExaminationProjectA_F.Data.Interfaces;
using ExaminationProjectA_F.Data.Repositories;
using ExaminationProjectA_F.Domain.Factories;
using ExaminationProjectA_F.Domain.Models;

namespace ExaminationProjectA_F.Business.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    private IUserRepository _userRepository = userRepository;

    public async Task<bool> UserAlreadyExists(string email)
    {
        var exists = await _userRepository.GetAsync(x => x.Email == email);
        if (exists != null)
        {
            return true;
        }

        return false;
    }

    public async Task<User> CreateUserAsync(UserRegistrationForm form)
    {
        var result = UserAlreadyExists(form.Email);

        var entity = UserFactory.Create(form);
        await _userRepository.SaveAsync(entity);

        var user = UserFactory.Create(entity);
        return user;
    }
}
