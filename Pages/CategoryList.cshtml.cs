using Ecommerce.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Category.Pages
{
    public class CategoryListModel : PageModel
    {
        private const string BaseUrl = "http://localhost:5008";
        private readonly HttpClient _httpClient;

        public CategoryListModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<CategoryDto> Categories { get; set; } = new();

        public async void OnGetAsync()
        {
            Categories = await _httpClient.GetFromJsonAsync<List<CategoryDto>>($"{BaseUrl}/categories") ?? new List<CategoryDto>();


        }
    }
}
