using Microsoft.AspNetCore.Mvc;

namespace cw2.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        /* cw 4
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            } else if (id == 2)
            {
                return Ok("Malewski");
            }
            

            return NotFound("Nie znaleziono studenta");
        }
    
          cw 5   */

        [HttpGet]
        public string GetStudent(string orderBy)
        {



            return $"Kowalski, Malewski, Andrzejewski sortowanie={orderBy}";
        }


    }
}