using BooksWebApp.Data;
using BooksWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksWebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }

        /// GET View of the Form
        public IActionResult Create()
        {
            return View();
        }


        /// POST the result of the Form <summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
		public IActionResult Create(Category category)
		{
            // Server Side Validation 
            if (category.DisplayOrder.ToString().Equals(category.Name))
            {
                ModelState.AddModelError("name", "The Category Name cannot exactly the same as DisplayOrder !!");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
			return View(category);
		}
	}
}
