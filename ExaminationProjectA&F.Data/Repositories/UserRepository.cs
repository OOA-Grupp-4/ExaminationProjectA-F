
using ExaminationProjectA_F.Data.Contexts;
using ExaminationProjectA_F.Data.Interfaces;
using ExaminationProjectA_F.Domain.Models;

namespace ExaminationProjectA_F.Data.Repositories;

public class UserRepository(DataContext context) : BaseRepository<UserEntity>(context), IUserRepository
{
}
