using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RegretBook.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowsController : ControllerBase
    {
        public FollowsController()
        {
            
        }
        // GET: api/Follows?userId={userId}&followedUserId={followedUserId}
        [HttpGet]
        public IActionResult GetFollows([FromQuery] Guid? userId, [FromQuery] Guid? followedUserId)
        {
            return Ok(new List<object>
            {
                new { Id = Guid.NewGuid(), UserId = userId ?? Guid.NewGuid(), FollowedUserId = followedUserId ?? Guid.NewGuid(), CreatedAt = DateTime.UtcNow.AddDays(-12) },
                new { Id = Guid.NewGuid(), UserId = userId ?? Guid.NewGuid(), FollowedUserId = followedUserId ?? Guid.NewGuid(), CreatedAt = DateTime.UtcNow.AddDays(-10) },
            });
        }

        // GET: api/Follows/{id}
        [HttpGet("{id}")]
        public IActionResult GetFollowById([FromRoute] Guid id)
        {
            return Ok(new { FollowId = id, UserId = Guid.NewGuid(), FollowedUserId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow.AddDays(-5) });
        }
        // GET: api/Follows/following/{userId}
        [HttpGet("following/{userId}")]
        public IActionResult GetFollowing([FromRoute] Guid userId)
        {
            return Ok(new List<object>
            {
                new { UserId = userId, FollowedUserId = Guid.NewGuid(),
                UserName= "FollowedUser1"},
                new { UserId = userId, FollowedUserId = Guid.NewGuid(), UserName = "FollowedUser2" },
            });
        }

        // GET: api/Follows
        [HttpPost]
        public IActionResult CreateFollow()
        {
            return Ok(new { FollowId = Guid.NewGuid(), UserId = Guid.NewGuid(), FollowedUserId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow, Message = "Follow created successfully" });
        }

        // DELETE: api/Follows/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteFollow([FromRoute] Guid id)
        {
            return Ok(new { FollowId = id, UserId = Guid.NewGuid(), FollowedUserId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow, Message = "Unfollow  successfully" });
        }
    }
}
