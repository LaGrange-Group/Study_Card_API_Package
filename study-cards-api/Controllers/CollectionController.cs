using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using study_cards_api.Data;
using study_cards_api.Models;

namespace study_cards_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionController : ControllerBase
    {
        private ApplicationDbContext _context;
        public CollectionController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public string Get()
        {
            var collections = _context.Stacks.Select(s => new { id = s.Id, title = s.Title, cards = _context.Cards.Where(c => c.StackId == s.Id).Select(c => new { id = c.Id, word = c.Word, definition = c.Definition }).ToArray() });
            string json = JsonConvert.SerializeObject(collections);
            return json;
        }
    }
}