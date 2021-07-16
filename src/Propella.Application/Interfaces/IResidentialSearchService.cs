using System.Threading.Tasks;

namespace Propella.Application.Interfaces
{
    public interface IResidentialSearchService
    {
        Task<int> GetCountAsync();
    }
}