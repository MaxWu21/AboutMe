using AboutMe.Domain.Entities;

namespace AboutMe.Domain.Abstract.Repositories
{
    public interface IMyInfoRepository
    {
        Task<MyInfo> GetMyInfoAsync();
    }
}