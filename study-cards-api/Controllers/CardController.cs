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
            card.CardStackId = _context.Cards.Where(c => c.StackId == card.StackId).ToList().Count + 1;
            _context.Cards.Add(card);
            _context.SaveChanges();
            return Created("URI of the created entity", card);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Card card)
        {
            Card dbCard = _context.Cards.Where(c => c.StackId == card.StackId && c.CardStackId == card.Id).FirstOrDefault();
            if (dbCard == null)
                return BadRequest();
            dbCard.StackId = dbCard.StackId;
            dbCard.CardStackId = dbCard.CardStackId;
            dbCard.Word = card.Word;
            dbCard.Definition = card.Definition;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{stackId}/{cardStackId}")]
        public IActionResult Delete(int stackId, int cardStackId)
        {
            Card dbCard = _context.Cards.Where(c => c.StackId == stackId && c.CardStackId == cardStackId).FirstOrDefault();
            if (dbCard == null)
                return BadRequest();
            _context.Cards.Remove(dbCard);
            _context.SaveChanges();
            UpdateCardStackIds(stackId);
            return NoContent();
        }

        // Ensure Cards contain consecutive numbering
        private void UpdateCardStackIds(int stackId)
        {
            List<Card> cards = _context.Cards.Where(c => c.StackId == stackId).ToList();
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].CardStackId != i + 1)
                {
                    Card dbCard = _context.Cards.Find(cards[i].Id);
                    dbCard.StackId = cards[i].StackId;
                    dbCard.Word = cards[i].Word;
                    dbCard.Definition = cards[i].Definition;
                    dbCard.CardStackId = i + 1;
                    _context.SaveChanges();
                }
            }
        }
    }
}