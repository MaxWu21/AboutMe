using System.Threading.Tasks;
using AboutMe.Domain.Entities;

namespace AboutMe.Infrastructure.Repositories
{
    public interface IMyInfoRepository
    {
        Task<string?> GetMyInfoAsync();
    }
}