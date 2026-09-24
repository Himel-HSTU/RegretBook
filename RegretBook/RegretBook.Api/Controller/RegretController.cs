using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RegretBook.Domain.Entities;


namespace RegretBook.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegretController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public RegretController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        //public void GetRegret()
        //{
        //    var connectionString = _configuration.GetValue<string>("Logging:LogLevel:Default");
        //}

        [HttpGet]
        public IActionResult GetRegrets()
        {
            var regrets = new List<Regret>
            {
                new Regret("I regret not learning to code earlier."){UserId = Guid.NewGuid(), Content = "I wish I had started learning to code when I was younger."},

                new Regret("I regret not traveling more when I was younger."){UserId = Guid.NewGuid(), Content = "I wish I had taken more trips and explored the world when I was younger."},

                new Regret("I regret not taking more risks in my career."){UserId =Guid.NewGuid(), Content = "I wish I had been more willing to take risks and pursue ambitious opportunities."},

                new Regret("I regret not spending more time with family and friends."){UserId = Guid.NewGuid(), Content = "I wish I had made more time for my loved ones and built stronger relationships."},

                new Regret("I regret not pursuing my passions sooner."){UserId = Guid.NewGuid(), Content = "I wish I had pursued my interests and dreams earlier in life."}
            };
            
            return Ok(regrets);
        }

        }
}
