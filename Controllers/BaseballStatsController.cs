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

    [HttpGet("name/{name}", Name="GetPlayer")]
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
    
//Not Working: list is returning empty from BattingStatsServices.cs    
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
    [HttpGet("player/{number}", Name="GetByNumber")]
    public IActionResult GetPlayerByNumber(int number)
    {
        try{
            IEnumerable<Player> list = _service.GetPlayerByNumber(number);
            if(list != null)
                return Ok(list);
            else 
                return BadRequest();
        }catch(Exception ex){
            return StatusCode(500, "Internal Server Error");
        }
    }
    
//double check code in BattingStatsServices, percentages are incorrect!!!
    [HttpGet("percentage/", Name="PercentageStarted")]
    public IActionResult GetPercentageOfGamesStarted()
    {
        try{
            List<string> list = _service.PercentageOfGamesStarted();
            if(list != null)
                return Ok(list);
            else 
                return BadRequest();
        }catch(Exception ex){
            return StatusCode(500, "Internal Server Error");
        }
    }

//not working!!!!
     [HttpGet("teamAvg/{year}", Name="GetAvgTeamBattingAvg")]
    public IActionResult AvgTeamBattingAvg(int season)
    {
        decimal teamAvg =_service.AvgTeamBattingAvgBySeason(season);
        if(teamAvg != 0)
            return Ok(teamAvg);
        else 
            return BadRequest();
    } 

}