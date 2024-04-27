using System.Net.Http;
using AboutMe.Domain.Entities;

namespace AboutMe.Infrastructure.Repositories
{
    public class MyInfoRepository : IMyInfoRepository
    {
        public async Task<string> GetMyInfoAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5273");

                HttpResponseMessage response = await client.GetAsync("/api/myinfo");

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(data);
                    return "success";
                }
                else
                {
                    Console.WriteLine("Failed to make API call. Status code: " + response.StatusCode);
                    return "fail";
                }
            }
        }
    }
}
