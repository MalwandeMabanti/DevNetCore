using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevNetCore.Data;
using Microsoft.AspNetCore.Mvc;


namespace DevNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
        {
           
            return this.Json(DataSourceLoader.Load(MockData.Employees(), loadOptions));
        }
    }
}