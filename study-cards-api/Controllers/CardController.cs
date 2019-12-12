using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using study_cards_api.Data;
using study_cards_api.Models;

namespace study_cards_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private ApplicationDbContext _context;
        public CardController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Card card)
        {
            _context.Cards.Add(card);
            _context.SaveChanges();
            return Created("URI of the created entity", card);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Card card)
        {
            if (card.Id > 0)
            {
                Card dbCard = _context.Cards.Find(card.Id);
                if (dbCard == null)
                    return BadRequest();
                dbCard.StackId = dbCard.StackId;
                dbCard.Word = card.Word;
                dbCard.Definition = card.Definition;
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                Card dbCard = _context.Cards.Find(id);
                if (dbCard == null)
                    return BadRequest();
                _context.Cards.Remove(dbCard);
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }
}