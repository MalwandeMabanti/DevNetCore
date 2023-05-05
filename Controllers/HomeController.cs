namespace DevNetCore.Controllers
{
    using DevExtreme.AspNet.Data;
    using DevExtreme.AspNet.Mvc;

    using DevNetCore.Interfaces;

    using Microsoft.AspNetCore.Mvc;
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeService _employeeService;

        public HomeController(ILogger<HomeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions)
        {
            return this.Json(DataSourceLoader.Load(_employeeService.Employees(), loadOptions));
        }
    }
}