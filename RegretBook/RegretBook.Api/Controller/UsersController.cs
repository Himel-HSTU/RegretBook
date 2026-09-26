using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegretBook.Api.Dtos;
using RegretBook.Api.Data;
using RegretBook.Domain.Entities;
namespace TwitterClone.Api.Controllers
{

    // api/users
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class UsersController : ControllerBase
    {

        private readonly UserRepository _userRepository;

        public UsersController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        // /api/users
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetUsers()
        {

            //var userRepository = new UserRepository();

            List<User> users = _userRepository.GetUsers();

            return Ok(users);
        }

        // /api/users
        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateUser([FromBody] CreateUserDto createUserDto)
        {

            if (string.IsNullOrWhiteSpace(createUserDto.FirstName) || string.IsNullOrWhiteSpace(createUserDto.LastName) || string.IsNullOrWhiteSpace(createUserDto.Email))
            {
                return BadRequest("All fields are required to create a new user.");
            }

            var existingUser = _userRepository.GetUserByEmail(createUserDto.Email);
            if (existingUser != null)
            {
                return BadRequest("A user with this email already exists.");
            }

            //var userRepository = new UserRepository();

            var createdUser = _userRepository.AddUser(new User
            {
                FirstName = createUserDto.FirstName,
                LastName = createUserDto.LastName,
                Email = createUserDto.Email
            });

            return Ok(createdUser);
        }


        // /api/users/{id}
        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult GetUserById([FromRoute] Guid id)
        {

            var user = _userRepository.GetUserById(id);
            if (user==null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return Ok(user);
        }

        // PUT /api/users/{id}
        [HttpPut("{id}")]
        
        public IActionResult UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserDtos updateUserDto)
        {

            var user = _userRepository.GetUserById(id);
            if (user==null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            user.FirstName = updateUserDto.FirstName ?? user.FirstName;
            user.LastName = updateUserDto.LastName ?? user.LastName;
            // jodi name update dei tahole update hobe otherwise purono name thakbe
            _userRepository.UpdateUser(user);
            return Ok(user);
        }


        // PATCH /api/users/{id}/phoneNumber
        [HttpPatch("{id}/phoneNumber")]
        public IActionResult UpdateUserPhoneNumber([FromRoute] Guid id, [FromBody] string phoneNumber)
        {
            return Ok("hello");

        }

        // DELETE /api/users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            var isdeleted = _userRepository.DeleteUser(id);
            return Ok(isdeleted);   
        }

    }
}