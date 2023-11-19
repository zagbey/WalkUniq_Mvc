using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using WalkUniq.DataAccess.Repository.IRepository;
using WalkUniq.Models;
using WalkUniq.Models.ViewModels;
using WalkUniq.Utility;

namespace WalkUniq.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(ILogger<HomeController> logger,IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index(int? showAll)
        {
            //shoppingcartviewcomponent e bak
            int pageSize = 4; // Sayfa başına gösterilecek ürün sayısı
            IEnumerable<Product> productList;
            if (showAll.HasValue && showAll.Value == 1)
            {
                //tüm ürünleri göster 
                productList = _unitOfWork.Product.GetAll(includeProperties: "Category");
            }
            else
            {
                // Belirli sayıda ürünü getir
                productList = _unitOfWork.Product.GetAll(includeProperties: "Category")
                    .Take(pageSize);
            }
            return View(productList);
        }



        public IActionResult Details(int productId)
        {
            ShoppingCart cart = new()
            {
                Product = _unitOfWork.Product.Get(u => u.Id == productId, includeProperties: "Category"),
                Count = 1,
                ProductId = productId
            };
            return View(cart);
        }
        public IActionResult Men(int categoryId)
        {
            // Kategoriye ait ürünleri getir
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(
                filter: p => p.CategoryId == categoryId,
                includeProperties: "Category"
            );

            // Kategoriyi bul
            Category category = _unitOfWork.Category.Get(c => c.Id == categoryId);

            // Model oluştur
            ProductsByCategoryVM model = new ProductsByCategoryVM
            {
                Category = category,
                Products = productList,
                CategoryId = categoryId // CategoryId'yi ayarla
            };

            return View(model);
        }

        [HttpPost]
        [Authorize] // giriş yapan userID
        //new ıtems ford the card
        public IActionResult Details(ShoppingCart shoppingCart)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            shoppingCart.ApplicationUserId = userId;

            //aynı ıd den olan eklemelerin db de düzenlenmesi 
            ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.ApplicationUserId == userId &&
            u.ProductId == shoppingCart.ProductId);

            if (cartFromDb != null)
            {
                //shopping cart exists
                cartFromDb.Count += shoppingCart.Count;
                _unitOfWork.ShoppingCart.Update(cartFromDb);
                _unitOfWork.Save();
            }
            else
            {
                //add cart record
                _unitOfWork.ShoppingCart.Add(shoppingCart);
                _unitOfWork.Save();
                HttpContext.Session.SetInt32(SD.SessionCart,
                _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == userId).Count());
            }
            TempData["success"] = "Cart updated successfully";

            


            return RedirectToAction(nameof(Index));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
