using InventorySystem.helpers;
using InventorySystem.Models;

namespace InventorySystem.services
{
    public interface ICompanyService
    {
        void Create(CompanyDTO companyDTO);
        void Update(CompanyDTO companyDTO);
        PaginatedList<CompanyDTO> GetAll(int CurrentPage);
        CompanyDTO Get(int Id);
        void Delete(int Id);
    }
}
