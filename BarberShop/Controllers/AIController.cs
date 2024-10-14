using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Controllers
{
    public class AIController : Controller
    {
        private readonly HttpClient _httpClient;

        public AIController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> GetSuggestion(string query)
        {
            var response = await _httpClient.PostAsync("AI_API_URL",
                new StringContent(query, Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return Json(result);
            }

            return BadRequest();
        }
    }
}