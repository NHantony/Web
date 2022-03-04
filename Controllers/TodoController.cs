using Microsoft.AspNetCore.Mvc;
namespace Todo.Controllers;

public class TodoController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet] //ddee truy cập dô form
    public IActionResult TodoForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult TodoForm(Todo.Models.Todo _todo) //truyen len kieu gi thi no hứng kiểu đó --- ctroller /Models /View /teen bieens
    {
        return View();
    }
}