using System.Threading.Tasks;

namespace Propella.Application.Interfaces
{
    public interface IDemographicsService
    {
        Task<int> GetCountAsync();
    }
}