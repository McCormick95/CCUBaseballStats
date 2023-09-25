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
        IEnumerable<Player> list = _service.GetAll();
        if(list != null)
            return Ok(list);
        else 
            return BadRequest();
    }

    // [HttpGet("{name}", Name="GetPlayer")]
    // public IActionResult GetPlayerByName(string name)
    // {
    //     IEnumerable<Player> list = _service.GetAll();
    //     if(list != null)
    //         return Ok(list);
    //     else 
    //         return BadRequest();
    // }

    [HttpGet("season/")]
    public IActionResult GetPlayerBySeason(int season)
    {
       IEnumerable<Player> list = _service.GetAll();
        if(list != null)
            return Ok(list);
        else 
            return BadRequest();
    }

//double check on if(condition)
    [HttpGet("{season}", Name="GetAvgTeamBattingAvg")]
    public IActionResult AvgTeamBattingAvg(int season)
    {
       decimal teamAvg =_service.AvgTeamBattingAvgBySeason(season);
        if(teamAvg != 0)
            return Ok(teamAvg);
        else 
            return BadRequest();
    }


    // [HttpPost]
    // public IActionResult CreateMovie(Movie m){

    //     _service.CreateMovie(m);
    //     //add code to determine the addition was succesfull

    //     return CreatedAtRoute("GetMovie", new {name=m.Name}, m);
    // }

    // [HttpPut ("{name}")]
    // public IActionResult UpdateMovie(string name, Movie movieIn){
    //     _service.UpdateMovie(name, movieIn);
    //     return NoContent();
    // }

    // [HttpDelete ("{name}")]
    // public IActionResult DeleteMovie(string name){
    //     _service.DeleteMovie(name);

    //     return NoContent();
    // }
}