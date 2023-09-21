using System.Collections.Generic;
using System.Collections;
using CCUBaseball.Models;
using CCUBaseball.Repository;
using System.ComponentModel;

namespace CCUBaseball.Services{
    public class BattingStatsServices : IBattingStats
    {
        private IStatsRepo _repo;

        public BattingStatsServices(IStatsRepo repo){
            _repo = repo;
        }
        public IEnumerable<Player> GetAll()
        {
            IEnumerable<Player> playerList =  _repo.GetAll();

            return playerList;
        }

        public IEnumerable<Player> GetPlayerByName(string name)
        {
           IEnumerable<Player> playerList =  _repo.GetPlayerByName(name);

            return playerList;
        }

        public IEnumerable<Player> GetPlayersBySeason(int s)
        {
            List<Player> playersBySeason = new();

            IEnumerable<Player> playerList =  _repo.GetAll();
            foreach(Player p in playerList){
                if(p.Season==s){
                    playersBySeason.Add(p);
                }
            }
            return playersBySeason;
        }

        public decimal AvgTeamBattingAvgBySeason(int s){
            decimal teamAverage = 0;
            int playerCount=0;

            IEnumerable<Player> playerList =  _repo.GetAll();
            
            foreach(Player p in playerList){
                if(p.Season==s){
                   teamAverage += p.BattingAvg; 
                    playerCount++;
                }
            }

            return teamAverage/playerCount;
        }
    }
}