using Microsoft.AspNetCore.Mvc;
namespace MyPortfolio.Controllers;   
    public class HomeController : Controller  
    {
        [HttpGet]     
        [Route("")]    
        public ViewResult Index()
        {
            return View();
        }

    [HttpGet("Projects")]
    public ViewResult Projects()
    {
        return View("Projects");
    }

    [HttpGet("Contact")]
    public ViewResult Contact()
    {
        return View("Contact");
    }
    }