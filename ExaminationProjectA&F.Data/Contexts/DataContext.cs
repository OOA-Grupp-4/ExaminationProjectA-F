
using ExaminationProjectA_F.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ExaminationProjectA_F.Data.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; }
}
