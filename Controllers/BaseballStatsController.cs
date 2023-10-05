using Microsoft.AspNetCore.Mvc;
using CCUBaseball.Models;
using CCUBaseball.Services;

namespace CCUBaseball.Controllers;

[ApiController]
[Route("[controller]")]
public class BaseballStatsController : ControllerBase
{
    private readonly ILogger<BaseballStatsController> _logger;
    private IBattingStats _service; 

    public BaseballStatsController(ILogger<BaseballStatsController> logger, IBattingStats service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public IActionResult GetPlayers()
    {
        try{
            IEnumerable<Player> list = _service.GetAll();
            if(list != null)
                return Ok(list);
            else 
                return BadRequest();
        }catch(Exception ex){
            return StatusCode(500, "Internal Server Error");
        }
    }

     [HttpGet("{name}", Name="GetPlayer")]
     public IActionResult GetPlayerByName(string name)
     {
        try{
            IEnumerable<Player> list = _service.GetPlayerByName(name);
            if(list != null)
                return Ok(list);
            else 
                return BadRequest();
        }catch(Exception ex){
            return StatusCode(500, "Internal Server Error");
        }
    }

     [HttpGet("season/{year}")]
     public IActionResult GetPlayersBySeason(int season)
     {
        try{
            IEnumerable<Player> list = _service.GetPlayersBySeason(season);
            if(list != null)
                return Ok(list);
            else 
                return BadRequest();
        }catch(Exception ex){
            return StatusCode(500, "Internal Server Error");
        }
     }

// //double check on if(condition)
//     [HttpGet("{season}", Name="GetAvgTeamBattingAvg")]
//     public IActionResult AvgTeamBattingAvg(int season)
//     {
//        decimal teamAvg =_service.AvgTeamBattingAvgBySeason(season);
//         if(teamAvg != 0)
//             return Ok(teamAvg);
//         else 
//             return BadRequest();
//     }

}