using CoreDependencyInjection.Models;
using CoreDependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookReviewRepository _repository;
        private readonly IReviewAggregator _aggregator;
 
        public HomeController(IBookReviewRepository repository, IReviewAggregator aggregator)
        {
            _repository = repository;
            _aggregator = aggregator;
        }

        public IActionResult Index()
        {
            return View(_repository.All);
        }

        public IActionResult Summary()
        {
            return View("Index", _aggregator.Summary);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
