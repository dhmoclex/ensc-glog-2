using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[Controller]")]
public class ActionController : ControllerBase
{
    private readonly DataContext _context;

    public ActionController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Action>>> GetInbox()
    {
        return await _context.Actions.Where(a => a.IsInbox).ToListAsync();
    }
}