using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication2.model;
using WebApplication2.services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private Todoservice _todoserviceall;
        public TodosController()
        {
            _todoserviceall = new Todoservice();
        }
        [HttpGet("{id}")]
     public IActionResult Todos(int? id)
        {
            var Mytodos = _todoserviceall.Alltodo();
            if (id is null) 
                return Ok(Mytodos);
            Mytodos = Mytodos.Where(t => t.Id == id).ToList();

            return Ok(Mytodos);
        }

  

    }



}
