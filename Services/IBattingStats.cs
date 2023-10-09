using System.Collections.Generic;
using CCUBaseball.Models;

namespace CCUBaseball.Services{
    public interface IBattingStats
    {
        public IEnumerable<Player> GetAll();
        public IEnumerable<Player> GetPlayerByName(string name);
        public IEnumerable<Player> GetPlayersBySeason(int s);
        public List<string> AvgTeamBattingAvgBySeason(int season);
        public IEnumerable<Player> GetPlayerByNumber(int num);
        public List<string> PercentageOfGamesStarted();

        
        //public void CreatePlayer();

        //public void UpdatePlayer();

        //public void DeletePlayer();
        
    }
}