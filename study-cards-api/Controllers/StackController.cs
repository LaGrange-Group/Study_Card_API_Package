using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using study_cards_api.Data;
using study_cards_api.Models;

namespace study_cards_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StackController : ControllerBase
    {
        private ApplicationDbContext _context;
        public StackController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Stack stack)
        {
            _context.Stacks.Add(stack);
            _context.SaveChanges();
            return Created("URI of the created entity", stack);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Stack stack)
        {
            Stack dbStack = _context.Stacks.Find(stack.Id);
            if (dbStack == null)
                return BadRequest();
            dbStack.Title = stack.Title;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Stack stack)
        {
            Stack dbStack = _context.Stacks.Find(stack.Id);
            if (dbStack == null)
                return BadRequest();
            _context.Stacks.Remove(dbStack);
            _context.SaveChanges();
            return NoContent();
        }
    }
}