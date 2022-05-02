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
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id) {
        var pizza = PizzaService.Get(id);

        if (pizza == null) 
            return NotFound();

        return pizza;
    }

    // POST action

    // PUT action

    // DELETE action
}