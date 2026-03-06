using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mission_10_Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BowlerController : ControllerBase
    {
        private readonly BowlingLeagueContext _context;
        public BowlerController(BowlingLeagueContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IEnumerable<object> GetBowlers()
        {
            return (from b in _context.Bowlers // SQL Query to find requested info
                join t in _context.Teams
                    on b.TeamId equals t.TeamId
                where t.TeamName == "Marlins" || t.TeamName == "Sharks"
                select new
                {
                    b.BowlerId,
                    b.BowlerFirstName,
                    b.BowlerMiddleInit,
                    b.BowlerLastName,
                    t.TeamName,
                    b.BowlerAddress,
                    b.BowlerCity,
                    b.BowlerState,
                    b.BowlerZip,
                    b.BowlerPhoneNumber
                }).ToList();
        }
    }
}