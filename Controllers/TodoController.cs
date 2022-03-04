using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers;
public class TodoController : Controller {
    
    public IActionResult Index(){
        return View();
    }
    public IActionResult TodoForm(){
        return View();
    }
}