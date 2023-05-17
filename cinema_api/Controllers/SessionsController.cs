using Data;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cinema_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase

    {
        private readonly CinemaDbContext context;

        public SessionsController(CinemaDbContext context)

        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Sessions.ToList());

        }

        //deteils 
        [HttpGet("details/{id}")]

        public IActionResult Get(int id)
        {
            if (id < 0) return BadRequest();
            var session = context.Sessions.Find(id);
            if (session == null) return NotFound();
            return Ok(session);

        }

        //create
        [HttpPost]
        public IActionResult Create(Session session)
        {
            if (!ModelState.IsValid) return BadRequest();
            context.Sessions.Add(session);
            context.SaveChanges();
            return Ok();          

        }
        // edit
        [HttpPut]
        public IActionResult Edit(Session session)
        {
            if (!ModelState.IsValid) return BadRequest();
            context.Sessions.Update(session);
            context.SaveChanges();
            return Ok();

        }
        //  delete
        [HttpDelete]
        public IActionResult Delete( int id)
        {
            if (id < 0 ) return BadRequest();
            var session = context.Sessions.Find(id);
            if (session == null) return NotFound();
            context.Sessions.Remove(session);
            context.SaveChanges();
            return Ok();

        }


    }
}
