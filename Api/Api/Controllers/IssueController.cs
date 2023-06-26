using Api.Data;
using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        private readonly IssueDbContext _context;

        public IssueController(IssueDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Isssue>> Get()
        {
            return await _context.Issues.ToListAsync(); 
        }

        [HttpGet("id")]
        [ProducesResponseType(typeof(Isssue),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
var issue=await _context.Issues.FindAsync(id);
            return issue==null ? NotFound() : Ok(issue);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Isssue issue)
        {
            await _context.Issues.AddAsync(issue);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = issue.Id }, issue);
        }


    }
}
