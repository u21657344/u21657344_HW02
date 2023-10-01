using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using u21657344_HW02.Models;
using u21657344_HW02.Models.Data;
using System.Linq;
using System.Diagnostics;
using u21657344_HW02.ViewModels;

namespace u21657344_HW02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // Retrieve the number of adopted pets
            var adoptedPetsCount = _context.Pets.Count(p => p.Status == "Adopted");

            // If you need a list of users who've adopted pets, you can use a query like:
            var usersWithAdoptedPets = _context.Pets
                .Where(p => p.Status == "Adopted")
                .Select(p => p.User)
                .Distinct()
                .ToList();  // This will give a list of distinct users who have adopted pets.

            // Pass this data to your view
            var viewModel = new HomeViewModel
            {
                AdoptedPetsCount = adoptedPetsCount,
                UsersWithAdoptedPets = usersWithAdoptedPets // or you could just pass the count
            };

            return View(viewModel);
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

        public IActionResult List()
        {
            var pets = _context.Pets.ToList();
            return View(pets);
        }
        public IActionResult Details(int id)
        {
            var pet = _context.Pets.FirstOrDefault(p => p.PetId == id);

            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }

    }
}
