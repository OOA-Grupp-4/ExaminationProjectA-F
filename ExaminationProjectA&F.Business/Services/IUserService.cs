using ExaminationProjectA_F.Domain.Models;

namespace ExaminationProjectA_F.Business.Services
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(UserRegistrationForm form);
        Task<bool> UserAlreadyExists(string email);
    }
}