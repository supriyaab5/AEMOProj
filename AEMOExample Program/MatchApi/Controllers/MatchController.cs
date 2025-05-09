using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class MatchController : ControllerBase
{
    private readonly MatchService _matchService = new MatchService();

    [HttpPost]
    public IActionResult Find([FromBody] MatchRequest request)
    {
        var result = _matchService.FindMatches(request.Text, request.Subtext);
        return Ok(result);
    }
}

public class MatchRequest
{
    public string Text { get; set; }
    public string Subtext { get; set; }
}