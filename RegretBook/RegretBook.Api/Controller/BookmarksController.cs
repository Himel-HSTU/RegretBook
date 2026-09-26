using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegretBook.Domain.Entities;

namespace RegretBook.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookmarksController : ControllerBase
    {
        public BookmarksController()
        {
            
        }

        // GET: api/Bookmarks
        [HttpGet]
        public IActionResult GetBookmarks([FromQuery] Guid? userId) {

            return Ok(new List<object>
            {
                new { Id = Guid.NewGuid(), UserId = userId ?? Guid.NewGuid(), RegretId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow },
                new { Id = Guid.NewGuid(), UserId = userId ?? Guid.NewGuid(), RegretId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow },
            });
        }

        // GET: api/Bookmarks/{id}
        [HttpGet("{id}")]
        public IActionResult GetBookmarkById([FromRoute] Guid id)
        {
            return Ok(new { BookmarkId = id, UserId = Guid.NewGuid(), RegretId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow }
            );
        }

        // POST: api/Bookmarks
        [HttpPost]
        public IActionResult CreateBookmark() {             
            return Ok(new { BookmarkId = Guid.NewGuid(), UserId = Guid.NewGuid(), RegretId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow });}

        // DELETE: api/Bookmarks/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteBookmark([FromRoute] Guid id)
        {
            return Ok(new { BookmarkId = id, UserId = Guid.NewGuid(), RegretId = Guid.NewGuid(), CreatedAt = DateTime.UtcNow, Message = "Bookmark deleted successfully" });
        }

    }
}
