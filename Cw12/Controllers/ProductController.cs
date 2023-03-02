using Cw12.DAL;
using Cw12.Views.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Cw12.Controllers
{
	public class ProductController : Controller
	{
		ProductRepository productRepository = new();
		[Route("List")]
		public IActionResult Index()
		{
			var products = productRepository.GetAllProduct();	
			return View(products);
		}
        [Route("Create")]
        public IActionResult CreatProduct()
		{
			return View();
		}
		[HttpPost]
        [Route("Create")]
        public IActionResult CreatProduct(ProducViewModel producViewModel)
        {
			productRepository.AddProduct(producViewModel);
            return RedirectToAction("Index");
        }
    }
}
