using Data.Entities;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cinema_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly CinemaDbContext context;

        public ActorsController(CinemaDbContext context)

        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Actors.ToList());

        }

        //deteils 
        [HttpGet("details/{id}")]

        public IActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            var actor = context.Actors.Find(id);
            if (actor == null) return NotFound();
            return Ok(actor);

        }


        //create
        [HttpPost]
        public IActionResult Create(Actor actor)
        {
            if (!ModelState.IsValid) return BadRequest();
            context.Actors.Add(actor);
            context.SaveChanges();
            return Ok();

        }
        // edit
        [HttpPut]
        public IActionResult Edit(Actor actor)
        {
            if (!ModelState.IsValid) return BadRequest();
            context.Actors.Update(actor);
            context.SaveChanges();
            return Ok();

        }
        //  delete
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id < 0) return BadRequest();
            var actor = context.Actors.Find(id);
            if (actor == null) return NotFound();
            context.Actors.Remove(actor);
            context.SaveChanges();
            return Ok();

        }


    }
}
