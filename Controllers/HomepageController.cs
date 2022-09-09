namespace JonDJones.Net6.StarterKit.Controllers;

public class HomepageController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }
}
