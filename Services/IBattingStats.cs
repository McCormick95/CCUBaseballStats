using System.Collections.Generic;
using CCUBaseball.Models;

namespace CCUBaseball.Services{
    public interface IBattingStats
    {
        public IEnumerable<Player> GetAll();
        public IEnumerable<Player> GetPlayerByName(string name);
        public IEnumerable<Player> GetPlayersBySeason(int season);
        public decimal AvgTeamBattingAvgBySeason(int s);
        public IEnumerable<Player> GetPlayerByNumber(int num);
        public IEnumerable<String> PercentageOfGamesStarted();

        
        //public void CreatePlayer();

        //public void UpdatePlayer();

        //public void DeletePlayer();
        
    }
}