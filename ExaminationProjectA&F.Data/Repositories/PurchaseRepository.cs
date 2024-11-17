
using ExaminationProjectA_F.Data.Contexts;
using ExaminationProjectA_F.Data.Interfaces;
using ExaminationProjectA_F.Domain.Models;

namespace ExaminationProjectA_F.Data.Repositories;

public class PurchaseRepository(DataContext context) : BaseRepository<PurchaseEntity>(context), IPurchaseRepository
{

}
