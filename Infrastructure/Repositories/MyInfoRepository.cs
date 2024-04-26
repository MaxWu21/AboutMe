using System.Threading.Tasks;
using AboutMe.Domain.Entities;

namespace AboutMe.Infrastructure.Repositories
{
    public class MyInfoRepository : IMyInfoRepository
    {
        public Task<MyInfo> GetMyInfoAsync()
        {
            // Simulate fetching MyInfo data asynchronously
            MyInfo myInfo = new MyInfo { Info = "Mocked MyInfo data" };
            return Task.FromResult(myInfo);
        }
    }
}