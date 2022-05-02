// Because this controller class is named PizzaController, this controller handles requests to https://localhost:{PORT}/pizza
using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase {
    public PizzaController() {

    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetALl() => PizzaService.GetAll();

    // GET by Id action

    // POST action

    // PUT action

    // DELETE action
}