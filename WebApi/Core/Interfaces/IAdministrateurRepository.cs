using WebApi.Models;

namespace WebApi.Core.Interfaces
{
    public interface IAdministrateurRepository : IGenericRepository<AdministrateurModel>
    {
        Task<AdministrateurModel?> GetByAdminNb(int adminNb);
    }
}
