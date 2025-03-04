using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace MvcApiCall.Controllers
{
  public class HomeController : Controller
  {
    private readonly string _apikey;

    public HomeController(IConfiguration configuration)
    {
        _apikey = configuration["NYT"];
    }

    public IActionResult Index()
    {
        List<Article> allArticles = Article.GetArticles(_apikey);
        return View(allArticles);
    }
  }
}