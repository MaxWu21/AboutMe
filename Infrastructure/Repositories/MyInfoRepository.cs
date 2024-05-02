using System;
using System.Net.Http;
using AboutMe.Domain.Entities;

namespace AboutMe.Infrastructure.Repositories
{
    public class MyInfoRepository : IMyInfoRepository
    {
        public async Task<string?> GetMyInfoAsync()
        {
            MyInfoRepository mockDataLayer = new MyInfoRepository();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://dev-qj5ustyar7zvqbk.api.raw-labs.com");

                HttpResponseMessage response = await client.GetAsync("/api/myinfo");

                if (response.IsSuccessStatusCode)
                {
                    string info = await response.Content.ReadAsStringAsync();
                    return info;
                }
                else
                {
                    Console.WriteLine("Failed to make API call. Status code: " + response.StatusCode);
                    return null;
                }
            }
        }
    }
}