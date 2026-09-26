using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{

    // api/reregrets
    [Route("api/[controller]")]
    [ApiController]
    public class ReregretController : ControllerBase
    {

        public ReregretController() { }


        // GET /api/reregrets?userId={userId}&regretId={regretId}
        [HttpGet]
        public IActionResult GetReregrets([FromQuery] Guid? userId, [FromQuery] Guid? regretId)
        {
            return Ok(new List<object>
            {
                new
                {
                    ReregretId = Guid.NewGuid(),
                    UserId = userId ?? Guid.NewGuid(),
                    RegretId = regretId ?? Guid.NewGuid(),
                    Comment = "Great point!",
                    CreatedAt = DateTime.UtcNow.AddHours(-3),
                },
                new
                {
                    ReregretId = Guid.NewGuid(),
                    UserId = userId ?? Guid.NewGuid(),
                    RegretId = regretId ?? Guid.NewGuid(),
                    Comment = "",
                    CreatedAt = DateTime.UtcNow.AddHours(-1),
                },
            });
        }

        // GET /api/reregrets/{id}
        [HttpGet("{id}")]
        public IActionResult GetReregretById([FromRoute] Guid id)
        {
            return Ok(new
            {
                ReregretId = id,
                UserId = Guid.NewGuid(),
                RegretId = Guid.NewGuid(),
                Comment = "reregret" + id.ToString(),
                CreatedAt = DateTime.UtcNow,
            });
        }

        // POST /api/reregrets
        [HttpPost]
        public IActionResult CreateReregret()
        {
            return Ok(new
            {
                ReregretId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                RegretId = Guid.NewGuid(),
                Comment = "New reregret comment.",
                CreatedAt = DateTime.UtcNow,
            });
        }

        // PUT /api/reregrets/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateReregret([FromRoute] Guid id)
        {
            return Ok(new
            {
                ReregretId = id,
                UserId = Guid.NewGuid(),
                RegretId = Guid.NewGuid(),
                Comment = "updatedcomment" + id.ToString(),
                ModifiedAt = DateTime.UtcNow,
            });
        }

        // DELETE /api/reregrets/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteReregret([FromRoute] Guid id)
        {
            return Ok(new
            {
                ReregretId = id,
                Message = "Reregret removed successfully.",
            });
        }
    }
}