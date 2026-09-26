using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegretBook.Domain.Entities;

namespace RegretBook.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegretPostsController : ControllerBase
    {
        public RegretPostsController()
        {
            
        }

        // GET : api/Regret/{id}

        [HttpGet("{id}")]
        public IActionResult GetRegretById([FromRoute] Guid id)
        {
            var regret = new Regret("I regret not learning to code earlier.") { UserId = Guid.NewGuid(), Content = "I wish I had started learning to code when I was younger." };
            return Ok(regret);
        }

        // POST : api/Regret
        [HttpPost]
        public IActionResult CreateRegret()
        {
            var regret = new Regret("I regret not learning to code earlier.") { UserId = Guid.NewGuid(), Content = "I wish I had started learning to code when I was younger." };
            return Ok(regret);
        }

        // PUT : api/Regret/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateRegret([FromRoute] Guid id)
        {
            return Ok(new { Message = "Regret updated successfully", ModifiedAt = DateTime.UtcNow });
        }

        // DELETE : api/Regret/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteRegret([FromRoute] Guid id)
        {
            return Ok(new { Message = "Regret deleted successfully", DeletedAt = DateTime.UtcNow });
        }
    }
}
