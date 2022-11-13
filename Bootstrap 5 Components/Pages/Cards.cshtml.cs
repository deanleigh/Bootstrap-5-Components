using Bootstrap_5_Components.Models;
using Bootstrap_5_Components.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bootstrap_5_Components.Pages
{
    public class CardsModel : PageModel
    {
        private readonly ILogger<CardsModel> _logger;

        public CardsModel(ILogger<CardsModel> logger,
    JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }
        public IEnumerable<Product> Products { get; private set; }

        public void OnGet() => Products = ProductService.GetProducts();
    }
}
