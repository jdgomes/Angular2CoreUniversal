using AspCoreServer.Data;
using AspCoreServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreServer.Controllers
{
  [Route("api/[controller]")]
  public class SearchController : Controller
  {
    private readonly AwsContext _context;

    public SearchController(AwsContext context)
    {
      _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get(int currentPageNo = 1, int pageSize = 20)
    {
      Random random = new Random();
      var users = await _context.SearchResults
          .OrderByDescending(u => u.Id.ToString().Substring(random.Next(0, 12), 3)) //need to get random order
          .Skip((currentPageNo - 1) * pageSize)
          .Take(pageSize)
          .ToArrayAsync();

      if (!users.Any())
      {
        return NotFound("No Search Results");
      }
      else
      {
        return Ok(users);
      }
    }
  }
}
